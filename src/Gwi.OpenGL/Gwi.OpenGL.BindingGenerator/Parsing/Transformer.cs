using System;
using System.Collections.Generic;
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

        public Transformer(ParseTree specification) : base(LogManager.GetCurrentClassLogger()) => ParseTree = specification;

        private ParseTree ParseTree { get; }

        public Specification Transform()
        {
            using (NewLogScope("Transform Parse Tree"))
            {
                IDictionary<string, OverloadedFunction> allfunctions;
                using (NewLogScope("Create Native Functions and overloads"))
                {
                    allfunctions = MakeFunctionsAndOverloads();
                    Log.Info($"{allfunctions.Count} functions and overloads were created");
                }

                var enumsByApi = new Dictionary<OutputApi, Dictionary<string, EnumGroupEntry>>();
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

                return new Specification(Array.Empty<OutputApiSpecification>());
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
                new Overload(null, null, nativeFunction.Parameters.ToArray(), nativeFunction, nativeFunction.ReturnType,
                    new NameTable(), "returnValue", Array.Empty<string>(), nativeFunction.Name),
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

        private void CreateEnums(IDictionary<OutputApi, Dictionary<string, EnumGroupEntry>> enumsByApi, HashSet<EnumGroupInfo> enumGroups)
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

                    var groupEntry = new EnumGroupEntry(NameMangler.MangleEnumName(entry.Name), entry.Value, entry.Groups, isFlags);
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
    }
}
