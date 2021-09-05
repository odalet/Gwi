using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gwi.OpenGL.BindingGenerator.Utils;
using NLog;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    internal sealed class CodeWriter : BaseProcessor
    {
        private const string baseNamespace = "Gwi";
        private const string rootNamespace = baseNamespace + ".OpenGL";

        public CodeWriter(string outputDirectory, bool debug) : base(LogManager.GetCurrentClassLogger())
        {
            OutputDirectory = Path.IsPathRooted(outputDirectory) ? outputDirectory : Path.Combine(Environment.CurrentDirectory, outputDirectory);
            EmitDebugComments = debug;
        }

        private string OutputDirectory { get; }
        private bool EmitDebugComments { get; }

        public void Write(Specification specification)
        {
            Log.Info($"Code will be produced in {OutputDirectory}");
            if (Directory.Exists(OutputDirectory))
            {
                // Cleanup contents
                Log.Debug($"Directory {OutputDirectory} exists; removing all previously generated code");

                // First let's remove all C# files in the root directory
                var toDelete = Directory.GetFiles(OutputDirectory, "*.cs", SearchOption.TopDirectoryOnly);
                foreach (var file in toDelete)
                    File.Delete(file);

                // Then remove everything in the sub-directories
                var dirs = Directory.GetDirectories(OutputDirectory);
                foreach (var dir in dirs)
                    Directory.Delete(dir, true);
            }
            else
            {
                Log.Debug($"Directory {OutputDirectory} does not exist; creating it");
                _ = Directory.CreateDirectory(OutputDirectory);
            }

            foreach (var api in specification.Apis)
            {
                var apiName = api.Api.GetNameInCode();
                var directory = Path.Combine(OutputDirectory, apiName);
                if (!Directory.Exists(directory))
                    _ = Directory.CreateDirectory(directory);

                using (NewLogScope($"Processing {api.Api} API"))
                {
                    LogScoped(() => WriteNativeFunctions(directory, api.Api, api.Vendors), "Write Functions");
                    LogScoped(() => WriteOverloads(directory, api.Api, api.Vendors), "Write Overloads");
                    LogScoped(() => WriteGLEnum(directory, api.Api, api.EnumEntries), "Write GLEnum");
                    LogScoped(() => WriteOtherEnums(directory, api.Api, api.EnumGroups), "Write other Enums");
                }
            }
        }

        private void WriteNativeFunctions(string directory, OutputApi api, IReadOnlyDictionary<string, GLVendorFunctions> groups)
        {
            WriteVTables(directory, api, groups);

            foreach (var vendor in groups.Keys)
            {
                var isGeneralGroup = string.IsNullOrEmpty(vendor);

                // Main file goes to generated/<api>/GL.api.cs
                var filename = Path.Combine(directory, $"GL.api.cs");
                if (!isGeneralGroup)
                {
                    var dir = Path.Combine(directory, vendor);
                    if (!Directory.Exists(dir))
                        _ = Directory.CreateDirectory(dir);

                    // Extensions files goes to generated/<vendor>/<api>/GL.<vendor>.cs
                    filename = Path.Combine(dir, $"GL.{vendor}.cs");
                }

                using var stream = File.CreateText(filename);
                using var writer = new IndentedTextWriter(stream);

                writer.WriteLine("// This file is auto generated, do not edit.");
                writer.WriteLine("using System;");
                writer.WriteLine();
                writer.WriteLine($"namespace {rootNamespace}.{api.GetNameInCode()}");

                using (writer.CsScope())
                {
                    // pragmas
                    writer.WriteLineNoTabs("#pragma warning disable IDE1006 // Naming Styles");
                    writer.WriteLineNoTabs("");

                    writer.WriteLine($"unsafe partial class GL");
                    using (writer.CsScope())
                    {
                        CsScope? extensionApiScope = null;
                        if (!isGeneralGroup)
                        {
                            writer.WriteLine($"private {vendor}Extension? _{vendor};");
                            writer.WriteLine($"public {vendor}Extension {vendor} => _{vendor} ??= new {vendor}Extension(this);");
                            writer.WriteLineNoTabs("");
                            writer.WriteLine($"public sealed unsafe partial class {vendor}Extension");
                            extensionApiScope = writer.CsScope();
                            writer.WriteLine("private readonly VTable vtable;");
                            writer.WriteLineNoTabs("");
                            writer.WriteLine($"internal {vendor}Extension(GL gl) => vtable = new VTable(gl.Lib);");
                            writer.WriteLineNoTabs("");
                        }

                        foreach (var nativeFunction in groups[vendor].NativeFunctions)
                        {
                            var hasPostfix = groups[vendor].NativeFunctionsWithPostfix.Contains(nativeFunction);
                            WriteMethod(writer, nativeFunction, hasPostfix);
                        }

                        extensionApiScope?.Dispose();
                    }

                    // pragmas
                    writer.WriteLineNoTabs("");
                    writer.WriteLineNoTabs("#pragma warning restore IDE1006 // Naming Styles");
                }

                writer.Flush();
            }
        }

        private void WriteVTables(string directory, OutputApi api, IReadOnlyDictionary<string, GLVendorFunctions> groups)
        {
            foreach (var vendor in groups.Keys)
            {
                var isGeneralGroup = string.IsNullOrEmpty(vendor);

                // Main file goes to generated/<api>/GL.vtable.cs
                var filename = Path.Combine(directory, $"GL.vtable.cs");
                if (!isGeneralGroup)
                {
                    var dir = Path.Combine(directory, vendor);
                    if (!Directory.Exists(dir))
                        _ = Directory.CreateDirectory(dir);

                    // Extensions go to generated/<vendor>/<api>/GL.<vendor>.vtable.cs
                    filename = Path.Combine(dir, $"GL.{vendor}.vtable.cs");
                }

                using var stream = File.CreateText(filename);
                using var writer = new IndentedTextWriter(stream);

                writer.WriteLine("// This file is auto generated, do not edit.");
                writer.WriteLine();
                writer.WriteLine($"namespace {rootNamespace}.{api.GetNameInCode()}");

                using (writer.CsScope())
                {
                    // pragmas
                    writer.WriteLineNoTabs("#pragma warning disable IDE1006 // Naming Styles");
                    writer.WriteLineNoTabs("");

                    writer.WriteLine($"unsafe partial class GL");
                    using (writer.CsScope())
                    {
                        CsScope? extensionVTableScope = null;
                        if (!isGeneralGroup)
                        {
                            writer.WriteLine($"unsafe partial class {vendor}Extension");
                            extensionVTableScope = writer.CsScope();
                        }

                        writer.WriteLine($"private sealed unsafe class VTable : BaseVTable");
                        using (writer.CsScope())
                        {
                            writer.WriteLine("public VTable(INativeLib lib) : base(lib) { }");
                            writer.WriteLineNoTabs("");

                            var count = 0;
                            foreach (var nativeFunction in groups[vendor].NativeFunctions)
                            {
                                WriteVTable(writer, nativeFunction);
                                count++;
                                if (count != groups[vendor].NativeFunctions.Count)
                                    writer.WriteLineNoTabs("");
                            }
                        }

                        extensionVTableScope?.Dispose();
                    }

                    // pragmas
                    writer.WriteLineNoTabs("");
                    writer.WriteLineNoTabs("#pragma warning restore IDE1006 // Naming Styles");
                }

                writer.Flush();
            }
        }

        private void WriteVTable(IndentedTextWriter writer, NativeFunction function)
        {
            // Write the VTable
            var ep = function.EntryPoint;
            writer.WriteLine($"public nint {ep} => _{ep} != 0 ? _{ep} : _{ep} = Lib.GetProcAddress(\"{ep}\");");
            writer.WriteLine($"private nint _{ep};");
        }

        private void WriteMethod(IndentedTextWriter writer, NativeFunction function, bool hasPostfix)
        {
            var functionName = function.Name;
            if (hasPostfix) functionName += "_";

            // Write the API
            var signatures = new List<string>();
            var delegateTypes = new List<string>();
            var parameterNames = new List<string>();
            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var name = function.Parameters[i].Name;
                var type = function.Parameters[i].Type.ToCSString();
                signatures.Add($"{type} {name}");
                delegateTypes.Add(type);
                parameterNames.Add(name);
            }

            var returnType = function.ReturnType.ToCSString();
            var underlyingReturnType = returnType;
            var requireCast = false;
            if (function.ReturnType is CSStruct returnStruct)
            {
                if (returnStruct.UnderlyingType == null) throw new ParsingException(
                    "A function returned a struct, but didn't have an underlying representation.");
                underlyingReturnType = returnStruct.UnderlyingType.ToCSString();
                requireCast = true;
            }

            delegateTypes.Add(underlyingReturnType);

            var signature = string.Join(", ", signatures);
            var call = string.Join(", ", parameterNames);
            var delegateSignature = string.Join(", ", delegateTypes);

            var body = $"((delegate* unmanaged[Cdecl]<{delegateSignature}>)vtable.{function.EntryPoint})({call})";

            if (function.ReturnType is CSVoid)
                writer.WriteLine($"public {returnType} {functionName}({signature}) => {body};");
            else if (requireCast)
                writer.WriteLine($"public {returnType} {functionName}({signature}) => ({returnType}){body};");
            else
                writer.WriteLine($"public {returnType} {functionName}({signature}) => {body};");
        }

        private void WriteOverloads(string directory, OutputApi api, IReadOnlyDictionary<string, GLVendorFunctions> groups)
        {
            foreach (var vendor in groups.Keys)
            {
                var group = groups[vendor];
                if (!group.OverloadsGroupedByNativeFunctions.SelectMany(o => o).Any())
                    continue;

                var isGeneralGroup = string.IsNullOrEmpty(vendor);

                // Main file goes to generated/<api>/GL.api.cs
                var filename = Path.Combine(directory, $"GL.overloads.cs");
                if (!isGeneralGroup)
                {
                    var dir = Path.Combine(directory, vendor);
                    if (!Directory.Exists(dir))
                        _ = Directory.CreateDirectory(dir);

                    // Extensions files goes to generated/<vendor>/<api>/GL.<vendor>.overloads.cs
                    filename = Path.Combine(dir, $"GL.{vendor}.overloads.cs");
                }

                using var stream = File.CreateText(filename);
                using var writer = new IndentedTextWriter(stream);

                writer.WriteLine("// This file is auto generated, do not edit.");
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Runtime.CompilerServices;");
                writer.WriteLine("using System.Runtime.InteropServices;");
                writer.WriteLine();
                writer.WriteLine($"namespace {rootNamespace}.{api.GetNameInCode()}");

                using (writer.CsScope())
                {
                    // pragmas
                    writer.WriteLineNoTabs("#pragma warning disable IDE1006 // Naming Styles");
                    writer.WriteLineNoTabs("");

                    var targetClass = isGeneralGroup ? "GL" : $"GL.{vendor}Extension";
                    writer.WriteLine($"public static class {(isGeneralGroup ? "GLOverloads" : $"{vendor}Overloads")}");
                    using (writer.CsScope())
                    {
                        var first = true;
                        foreach (var nativeFunctionOverloads in group.OverloadsGroupedByNativeFunctions)
                        {
                            if (nativeFunctionOverloads.Length == 0)
                                continue;

                            if (first)
                                first = false;
                            else
                                writer.WriteLineNoTabs("");

                            var functionName = nativeFunctionOverloads[0].NativeFunction.Name;
                            var hasPostfix = group.NativeFunctionsWithPostfix.Contains(nativeFunctionOverloads[0].NativeFunction);
                            if (hasPostfix) functionName += "_";
                            writer.WriteLine($"// {functionName} overloads");
                            writer.WriteLineNoTabs("");

                            var count = 0;
                            foreach (var overload in nativeFunctionOverloads)
                            {
                                WriteOverloadMethod(writer, overload, targetClass, hasPostfix);
                                count++;
                                if (count != nativeFunctionOverloads.Length)
                                    writer.WriteLineNoTabs("");
                            }
                        }
                    }

                    // pragmas
                    writer.WriteLineNoTabs("");
                    writer.WriteLineNoTabs("#pragma warning restore IDE1006 // Naming Styles");
                }

                writer.Flush();
            }
        }

        private void WriteOverloadMethod(IndentedTextWriter writer, Overload overload, string targetClass, bool hasPostfix)
        {
            if (EmitDebugComments)
                writer.WriteLine($"// Generated by {overload.OverloaderType}");

            // if we don't have a MarshalLayerToNested field, the method can be written as a one-liner
            var isOneLiner = overload.MarshalLayerToNested == null && overload.ReturnType is CSVoid;
            var hasGenericTypes = overload.GenericTypes.Length != 0;

            var genericTypes = overload.GenericTypes.Length <= 0 ? "" : $"<{string.Join(", ", overload.GenericTypes)}>";
            var parameters = string.Join(", ", overload.InputParameters.Select(p => $"{p.Type.ToCSString()} {p.Name}"));
            var allParameters = string.IsNullOrEmpty(parameters) ?
                $"this {targetClass} glInstance" :
                $"this {targetClass} glInstance, {parameters}";
            writer.WriteLine($"public static unsafe {overload.ReturnType.ToCSString()} {overload.OverloadName}{genericTypes}({allParameters}){(isOneLiner && !hasGenericTypes ? " =>" : "")}");

            if (hasGenericTypes)
                using (writer.Indent())
                {
                    foreach (var type in overload.GenericTypes)
                        writer.WriteLine($"where {type} : unmanaged");
                    if (isOneLiner)
                        writer.WriteLine($"=>");
                }

            if (isOneLiner) using (writer.Indent())
                    _ = WriteNestedOverload(writer, overload, new NameTable(), hasPostfix);
            else using (writer.CsScope())
                {
                    if (overload.ReturnType is not CSVoid && overload.NativeFunction.ReturnType is not CSVoid)
                        writer.WriteLine($"{overload.NativeFunction.ReturnType.ToCSString()} returnValue;");

                    var returnName = WriteNestedOverload(writer, overload, new NameTable(), hasPostfix);
                    if (returnName != null)
                        writer.WriteLine($"return {returnName};");
                }

            ////var scope = isOneLiner ? default(CsScope?) : writer.CsScope();

            ////if (overload.ReturnType is not CSVoid && overload.NativeFunction.ReturnType is not CSVoid)
            ////    writer.WriteLine($"{overload.NativeFunction.ReturnType.ToCSString()} returnValue;");

            ////var returnName = WriteNestedOverload(writer, overload, new NameTable(), hasPostfix);
            ////if (returnName != null)
            ////    writer.WriteLine($"return {returnName};");

            ////scope?.Dispose();
        }

        private string? WriteNestedOverload(IndentedTextWriter writer, Overload overload, NameTable nameTable, bool postfixNativeCall)
        {
            // Update the name table with the names for this overload.
            nameTable.Apply(overload.NameTable);
            overload.MarshalLayerToNested?.WritePrologue(writer, nameTable);

            string? returnName;
            if (overload.NestedOverload != null)
                returnName = WriteNestedOverload(writer, overload.NestedOverload, nameTable, postfixNativeCall);
            else
            {
                // Writes the native call.
                var nativeFunction = overload.NativeFunction;
                var name = nativeFunction.Name;
                if (postfixNativeCall) name += "_";

                var arguments = string.Join(", ", nativeFunction.Parameters.Select(p => nameTable[p]));

                if (nativeFunction.ReturnType is CSVoid)
                {
                    writer.WriteLine($"glInstance.{name}({arguments});");
                    return null;
                }
                else
                {
                    writer.WriteLine($"returnValue = glInstance.{name}({arguments});");
                    return "returnValue";
                }
            }

            return overload.MarshalLayerToNested?.WriteEpilogue(writer, nameTable, returnName) ?? returnName;
        }

        private void WriteGLEnum(string directory, OutputApi api, IReadOnlyCollection<EnumEntry> allEnumEntries)
        {
            var filename = Path.Combine(directory, $"{Constants.GLEnumName}.cs");
            using var stream = File.CreateText(filename);
            using var writer = new IndentedTextWriter(stream);

            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine();
            writer.WriteLine($"namespace {rootNamespace}.{api.GetNameInCode()}");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CA1069 // Enums should not have duplicate values");
                writer.WriteLineNoTabs("");
                writer.WriteLine($"public enum {Constants.GLEnumName} : uint");
                using (writer.CsScope())
                {
                    var count = 0;
                    foreach (var entry in allEnumEntries)
                    {
                        writer.Write($"{entry.Name} = {entry.Value}");
                        count++;
                        if (count != allEnumEntries.Count)
                            writer.WriteLine(",");
                        else
                            writer.WriteLine();
                    }
                }

                writer.WriteLineNoTabs("");
                writer.WriteLineNoTabs("#pragma warning restore CA1069 // Enums should not have duplicate values");
            }

            writer.Flush();
        }

        private void WriteOtherEnums(string directory, OutputApi api, IReadOnlyCollection<EnumGroup> enumGroups)
        {
            var filename = Path.Combine(directory, "enums.cs");
            using var stream = File.CreateText(filename);
            using var writer = new IndentedTextWriter(stream);

            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine($"namespace {rootNamespace}.{api.GetNameInCode()}");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CA1069 // Enums should not have duplicate values");
                writer.WriteLineNoTabs("");

                // TODO: replace this later...
                writer.WriteLine("// TODO: Temporary fake definition needed to satisfy NV extension");
                writer.WriteLine("public enum SampleMaskNV : uint { }");
                writer.WriteLineNoTabs("");

                var groupCount = 0;
                foreach (var group in enumGroups)
                {
                    if (group.IsFlags) writer.WriteLine($"[Flags]");
                    writer.WriteLine($"public enum {group.Name} : uint");
                    using (writer.CsScope())
                    {
                        var count = 0;
                        foreach (var entry in group.Entries.OrderBy(e => e.Value))
                        {
                            writer.Write($"{entry.Name} = {entry.Value}");
                            count++;
                            if (count != group.Entries.Count)
                                writer.WriteLine(",");
                            else
                                writer.WriteLine();
                        }
                    }

                    groupCount++;
                    if (groupCount != enumGroups.Count)
                        writer.WriteLineNoTabs("");
                }

                writer.WriteLineNoTabs("");
                writer.WriteLineNoTabs("#pragma warning restore CA1069 // Enums should not have duplicate values");
            }

            writer.Flush();
        }
    }

    internal static class ApiExtensions
    {
        public static string GetNameInCode(this OutputApi api) => api switch
        {
            OutputApi.GL => "GL4",
            OutputApi.GLCompat => "GLCompat",
            OutputApi.GLES1 => "GLES1",
            OutputApi.GLES3 => "GLES3",
            _ => throw new Exception($"This is not a valid output API ({api})"),
        };
    }
}
