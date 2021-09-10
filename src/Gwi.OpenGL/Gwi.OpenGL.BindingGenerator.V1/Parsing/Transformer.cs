using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Gwi.OpenGL.BindingGenerator.Utils;
using NLog;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    internal sealed class Transformer : BaseProcessor
    {
        private sealed record OverloadedFunction(NativeFunction NativeFunction, Overload[] Overloads, bool ChangeNativeName);
        private sealed record EnumGroupInfo(string GroupName, bool IsFlags)
        {
            // To deduplicate these correctly we need special logic for the IsFlags bool
            // so we don't consider it in the equality check and hashcode to allow for that.
            //
            // Example:
            // PathFontStyle uses GL_NONE which is not marked as bitmask
            // but other entries such as GL_BOLD_BIT_NV is marked as bitmask.
            //
            // When this case happens we want to consider the entire group as a bitmask.
            //
            // In the current spec this case only happens for PathFontStyle.
            // - 2021-07-04
            public bool Equals(EnumGroupInfo? other) => other?.GroupName == GroupName;
            public override int GetHashCode() => HashCode.Combine(GroupName);
        };

        private sealed record ProcessedGLInformation(
            IDictionary<string, OverloadedFunction> Functions,
            IDictionary<OutputApi, Dictionary<string, EnumEntry>> EnumsByApi,
            IReadOnlyCollection<EnumGroupInfo> EnumGroupInfos);

        public Transformer(ParseTree specification) : base(LogManager.GetCurrentClassLogger()) => ParseTree = specification;

        private ParseTree ParseTree { get; }

        public Specification Transform()
        {
            using (NewLogScope("Transform Parse Tree"))
            {
                IDictionary<string, OverloadedFunction> functions;
                using (NewLogScope("Create Native Functions and overloads"))
                {
                    functions = MakeFunctionsAndOverloads();
                    Log.Info($"{functions.Count} functions and overloads were created");
                }

                var enumsByApi = new Dictionary<OutputApi, Dictionary<string, EnumEntry>>();
                var enumGroups = new HashSet<EnumGroupInfo>();
                using (NewLogScope("Create enums"))
                {
                    CreateEnums(enumsByApi, enumGroups);
                    foreach (var api in enumsByApi.Keys)
                        Log.Info($"API {api}: {enumsByApi[api].Count} enumerations were created");
                    Log.Info($"{enumGroups.Count} enumeration groups were created");
                }

                // Now that we have all of the functions and enums ready in dictionaries
                // we can start building all of the API versions.

                // Filter the features and extensions we actually want to output.
                var features = ParseTree.Features.Where(feature => feature.Api switch
                {
                    GLApi.GL or GLApi.GLES1 or GLApi.GLES2 => true,
                    _ => false
                });

                var extensions = ParseTree.Extensions.Where(extension => extension.SupportedApis.Any(api => api switch
                {
                    GLApi.GL or GLApi.GLES1 or GLApi.GLES2 => true,
                    _ => false
                }));

                var glRequires = GetRequireEntries(features, extensions, GLApi.GL);
                var gles1Requires = GetRequireEntries(features, extensions, GLApi.GLES1);
                var gles3Requires = GetRequireEntries(features, extensions, GLApi.GLES2);

                var glRemoves = GetRemoveEntries(features, GLApi.GL);
                var gles1Removes = GetRemoveEntries(features, GLApi.GLES1);
                var gles3Removes = GetRemoveEntries(features, GLApi.GLES2);

                var info = new ProcessedGLInformation(functions, enumsByApi, enumGroups.ToList());

                var gl = GetOutputApiSpecificationFromRequireTags(OutputApi.GL, glRequires, glRemoves, info);
                var glCompat = GetOutputApiSpecificationFromRequireTags(OutputApi.GLCompat, glRequires, new List<RemoveEntry>(), info);
                var gles1 = GetOutputApiSpecificationFromRequireTags(OutputApi.GLES1, gles1Requires, new List<RemoveEntry>(), info);
                var gles3 = GetOutputApiSpecificationFromRequireTags(OutputApi.GLES3, gles3Requires, gles3Removes, info);

                return new Specification(new[] { gl, glCompat, gles1, gles3 });
            }
        }

        private IDictionary<string, OverloadedFunction> MakeFunctionsAndOverloads()
        {
            var functions = new Dictionary<string, OverloadedFunction>(ParseTree.Commands.Count);
            foreach (var command in ParseTree.Commands)
            {
                var nativeFunction = MakeNativeFunction(command);
                var overloadedFunction = GenerateOverloads(nativeFunction);
                functions.Add(nativeFunction.EntryPoint, overloadedFunction);
            }

            return functions;
        }

        private static NativeFunction MakeNativeFunction(Command command)
        {
            var functionName = NameMangler.MangleFunctionName(command.EntryPoint);
            var referencedEnumGroups = new HashSet<string>();
            var parameters = new List<Parameter>();

            foreach (var glParameter in command.Parameters)
            {
                var csharpType = TypeTransformer.MakeCSType(glParameter.Type.Type, glParameter.Type.Handle, glParameter.Type.Group);
                parameters.Add(new Parameter(csharpType, NameMangler.MangleParameterName(glParameter.Name), glParameter.Length));
                if (!string.IsNullOrEmpty(glParameter.Type.Group))
                    _ = referencedEnumGroups.Add(glParameter.Type.Group);
            }

            var returnType = TypeTransformer.MakeCSType(command.ReturnType.Type, command.ReturnType.Handle, command.ReturnType.Group);
            if (!string.IsNullOrEmpty(command.ReturnType.Group))
                _ = referencedEnumGroups.Add(command.ReturnType.Group);

            return new NativeFunction(command.EntryPoint, functionName, parameters, returnType, referencedEnumGroups.ToArray());
        }

        // Maybe we can do the return type overloading in a post processing step?
        private static OverloadedFunction GenerateOverloads(NativeFunction nativeFunction)
        {
            static bool areSignaturesDifferent(NativeFunction nativeFunction, Overload overload)
            {
                if (nativeFunction.Parameters.Count != overload.InputParameters.Length)
                    return true;

                if (overload.OverloadName != nativeFunction.Name)
                    return true;

                for (var i = 0; i < nativeFunction.Parameters.Count; i++)
                {
                    if (!nativeFunction.Parameters[i].Type.Equals(overload.InputParameters[i].Type))
                        return true;
                }

                return false;
            }

            var currentOverloads = new List<Overload>
            {
                // Make a "base" overload
                new Overload(
                    null,
                    null,
                    nativeFunction.Parameters.ToArray(), 
                    nativeFunction, 
                    nativeFunction.ReturnType,
                    new NameTable(), 
                    "returnValue", 
                    Array.Empty<string>(), 
                    nativeFunction.Name,
                    typeof(Transformer))
            };

            var overloadedOnce = false;
            foreach (var overloader in IOverloader.Overloaders)
            {
                var newOverloads = new List<Overload>();
                foreach (var overload in currentOverloads)
                {
                    if (overloader.TryGenerateOverloads(overload, out var overloaderOverloads))
                    {
                        overloadedOnce = true;
                        newOverloads.AddRange(overloaderOverloads);
                    }
                    else newOverloads.Add(overload);
                }

                // Replace the old overloads with the new overloads
                currentOverloads = newOverloads;
            }

            var overloads = overloadedOnce ? currentOverloads.ToArray() : Array.Empty<Overload>();

            var changeNativeName = false;
            foreach (var overload in overloads)
            {
                if (!areSignaturesDifferent(nativeFunction, overload))
                    changeNativeName = true;
            }

            return new OverloadedFunction(nativeFunction, overloads, changeNativeName);
        }

        private void CreateEnums(IDictionary<OutputApi, Dictionary<string, EnumEntry>> enumsByApi, HashSet<EnumGroupInfo> enumGroups)
        {
            foreach (var enumerant in ParseTree.Enumerants)
            {
                var isFlags = enumerant.Type == EnumerantType.Bitmask;
                foreach (var entry in enumerant.Entries)
                {
                    foreach (var group in entry.Groups)
                    {
                        // If the enumerant inside which the entry appeared for the first time tag wasn't flagged as a bitmask,
                        // but now is, then we want the group to be considered a bitmask.
                        if (enumGroups.TryGetValue(new EnumGroupInfo(group, isFlags), out var actual))
                        {
                            // In the current spec, this case never happens, but theoretically, it could...
                            if (isFlags && !actual.IsFlags)
                            {
                                _ = enumGroups.Remove(actual);
                                _ = enumGroups.Add(actual with { IsFlags = true });
                            }
                        }
                        else _ = enumGroups.Add(new EnumGroupInfo(group, isFlags));
                    }

                    var groupEntry = new EnumEntry(NameMangler.MangleEnumName(entry.Name), entry.Value, entry.Groups, isFlags);
                    switch (entry.Api)
                    {
                        case GLApi.None:
                            enumsByApi.Add(OutputApi.GL, entry.Name, groupEntry);
                            enumsByApi.Add(OutputApi.GLCompat, entry.Name, groupEntry);
                            enumsByApi.Add(OutputApi.GLES1, entry.Name, groupEntry);
                            enumsByApi.Add(OutputApi.GLES3, entry.Name, groupEntry);
                            break;
                        case GLApi.GLES1:
                            enumsByApi.Add(OutputApi.GLES1, entry.Name, groupEntry);
                            break;
                        case GLApi.GLES2:
                            enumsByApi.Add(OutputApi.GLES3, entry.Name, groupEntry);
                            break;
                        case GLApi.GL:
                            enumsByApi.Add(OutputApi.GL, entry.Name, groupEntry);
                            enumsByApi.Add(OutputApi.GLCompat, entry.Name, groupEntry);
                            break;
                    }
                }
            }
        }

        private static List<(string vendor, RequireEntry entry)> GetRequireEntries(IEnumerable<Feature> features, IEnumerable<Extension> extensions, GLApi api)
        {
            var requireEntries = new List<(string vendor, RequireEntry entry)>();

            foreach (var require in features.Where(feature => feature.Api == api).SelectMany(feature => feature.Requires))
                requireEntries.Add(("", require));

            foreach (var extension in extensions.Where(extension => extension.SupportedApis.Contains(api)))
            {
                foreach (var require in extension.Requires)
                    requireEntries.Add((extension.Vendor, require));
            }

            return requireEntries;
        }

        private static List<RemoveEntry> GetRemoveEntries(IEnumerable<Feature> features, GLApi api) =>
            features.Where(feature => feature.Api == api).SelectMany(feature => feature.Removes).ToList();

        private static OutputApiSpecification GetOutputApiSpecificationFromRequireTags(
            OutputApi api,
            IEnumerable<(string vendor, RequireEntry requireEntry)> requireEntries,
            IEnumerable<RemoveEntry> removeEntries,
            ProcessedGLInformation glInformation)
        {
            var groupsReferencedByFunctions = new HashSet<string>();            
            var functionsByVendor = new Dictionary<string, HashSet<OverloadedFunction>>();
            var enums = new Dictionary<string, List<EnumEntry>>();
            var allEnumGroupEntries = new HashSet<EnumEntry>();

            // Go through all the functions that are required for this version and add them here.
            foreach (var (vendor, requireEntry) in requireEntries)
            {
                foreach (var command in requireEntry.Commands)
                {
                    if (glInformation.Functions.TryGetValue(command, out var function))
                    {
                        functionsByVendor.Add(vendor, function);
                        groupsReferencedByFunctions.UnionWith(function.NativeFunction.ReferencedEnumGroups);
                    }
                    else throw new ParsingException($"Could not find any function called '{command}'.");
                }

                foreach (var enumName in requireEntry.Enums)
                {
                    var enumGroupEntriesByEnumName = glInformation.EnumsByApi[api];
                    if (enumGroupEntriesByEnumName.TryGetValue(enumName, out var enumGroupEntry))
                    {
                        foreach (var group in enumGroupEntry.Groups)
                        {
                            if (!enums.TryGetValue(group, out var groupEntries))
                            {
                                groupEntries = new List<EnumEntry>();
                                enums.Add(group, groupEntries);
                            }

                            if (groupEntries.Find(g => g.Name == enumGroupEntry.Name) == null)
                                groupEntries.Add(enumGroupEntry);
                        }

                        if (enumGroupEntry.Value <= uint.MaxValue)
                            _ = allEnumGroupEntries.Add(enumGroupEntry);
                    }
                    else throw new ParsingException($"Could not find any enum called '{enumName}'.");
                }
            }

            foreach (var remove in removeEntries)
                foreach (var command in remove.Commands)
                    foreach (var functions in functionsByVendor.Values)
                        _ = functions.RemoveWhere(f => f.NativeFunction.EntryPoint == command);

            // Go through all of the enums and put them into their groups

            // Add keys + lists for all enum names
            var finalGroups = new List<EnumGroup>();
            foreach (var (groupName, isFlags) in glInformation.EnumGroupInfos)
            {
                _ = enums.TryGetValue(groupName, out var members);
                members ??= new List<EnumEntry>();

                // SpecialNumbers is not an enum group that we want to output.
                // We handle these entries differently as some of the entries don't fit in an int.
                if (groupName == "SpecialNumbers")
                    continue;

                // Remove all empty enum groups, except the empty groups referenced by included functions.
                // In GL 4.1 to 4.5 there are functions that use the group "ShaderBinaryFormat"
                // while not including any members for that enum group.
                // This is needed to solve that case.
                if (members.Count <= 0 && !groupsReferencedByFunctions.Contains(groupName))
                    continue;

                finalGroups.Add(new EnumGroup(groupName, isFlags, members));
            }

            var vendors = new Dictionary<string, GLVendorFunctions>();
            foreach (var (vendor, overloadedFunctions) in functionsByVendor)
                foreach (var overloadedFunction in overloadedFunctions)
                {
                    if (!vendors.TryGetValue(vendor, out var group))
                    {
                        group = new GLVendorFunctions(
                            new List<NativeFunction>(), 
                            new List<Overload[]>(), 
                            new HashSet<NativeFunction>());
                        vendors.Add(vendor, group);
                    }

                    group.NativeFunctions.Add(overloadedFunction.NativeFunction);
                    group.OverloadsGroupedByNativeFunctions.Add(overloadedFunction.Overloads);

                    if (overloadedFunction.ChangeNativeName)
                        _ = group.NativeFunctionsWithPostfix.Add(overloadedFunction.NativeFunction);
                }

            return new OutputApiSpecification(api, vendors, allEnumGroupEntries.ToList(), finalGroups);
        }
    }
}
