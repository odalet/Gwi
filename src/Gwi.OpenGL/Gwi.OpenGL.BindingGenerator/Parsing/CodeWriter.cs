using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Gwi.OpenGL.BindingGenerator.Utils;
using NLog;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    internal sealed class CodeWriter : BaseProcessor
    {
        private const string baseNamespace = "Gwi";
        private const string rootNamespace = baseNamespace + ".OpenGL";
        private const string LoaderClass = "GLLoader";
        private const string LoaderBindingsContext = LoaderClass + ".BindingsContext";

        public CodeWriter(string outputDirectory) : base(LogManager.GetCurrentClassLogger()) =>
            OutputDirectory = Path.IsPathRooted(outputDirectory) ? outputDirectory : Path.Combine(Environment.CurrentDirectory, outputDirectory);

        private string OutputDirectory { get; }

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
                    ////LogScoped(() => WriteOverloads(apiDirectory, apiNamespace, api.Vendors), "Write Overloads");
                    LogScoped(() => WriteGLEnum(directory, api.Api, api.EnumEntries), "Write GLEnum");
                    LogScoped(() => WriteOtherEnums(directory, api.Api, api.EnumGroups), "Write other Enums");
                }
            }
        }

        private static void WriteNativeFunctions(string directory, OutputApi api, IReadOnlyDictionary<string, GLVendorFunctions> groups)
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

        private static void WriteVTables(string directory, OutputApi api, IReadOnlyDictionary<string, GLVendorFunctions> groups)
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

        private static void WriteVTable(IndentedTextWriter writer, NativeFunction function)
        {
            // Write the VTable
            var ep = function.EntryPoint;
            writer.WriteLine($"public nint {ep} => _{ep} != 0 ? _{ep} : _{ep} = Lib.GetProcAddress(\"{ep}\");");
            writer.WriteLine($"private nint _{ep};");
        }

        private static void WriteMethod(IndentedTextWriter writer, NativeFunction function, bool hasPostfix)
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

        private static void __WriteNativeMethod(IndentedTextWriter apiWriter, IndentedTextWriter vtableWriter, NativeFunction function, bool hasPostfix)
        {
            var name = function.Name;
            if (hasPostfix) name += "_";

            var paramNames = new StringBuilder();
            var delegateTypes = new StringBuilder();
            var signature = new StringBuilder();

            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var param = function.Parameters[i];
                var type = param.Type.ToCSString();

                _ = paramNames.Append(param.Name);
                _ = delegateTypes.Append(type);
                _ = signature.Append($"{type} {param.Name}");

                // If we are adding more types, append a ", "
                if (i + 1 < function.Parameters.Count)
                {
                    _ = paramNames.Append(", ");
                    _ = signature.Append(", ");
                }

                _ = delegateTypes.Append(", ");
            }

            // Because there might be ABI differences between returning a struct and a primitive type we can't assume the GL function is gonna return a struct,
            // so we need to match the native function signature excactly, to avoid a mismatch in the ABI.
            // - 2021-06-22
            bool handleAbiDifferenceForTypesafeHandles;
            string returnType;

            if (function.ReturnType is CSStruct returnStruct)
            {
                if (returnStruct.UnderlyingType == null) throw new ParsingException("A function returned a struct, but didn't have an underlying representation.");
                returnType = returnStruct.UnderlyingType.ToCSString();
                handleAbiDifferenceForTypesafeHandles = true;
            }
            else
            {
                returnType = function.ReturnType.ToCSString();
                handleAbiDifferenceForTypesafeHandles = false;
            }

            _ = delegateTypes.Append(returnType);

            // Write the public method
            if (handleAbiDifferenceForTypesafeHandles)
                // Here we just cast and return the correct return type in the public facing function.
                // This works because all of the structs that get here should have a defined cast from the primitive type to the struct type.
                // These casts need to be added manually for this to work correctly.
                // - 2021-06-22
                apiWriter.WriteLine($"public static {function.ReturnType.ToCSString()} {name}({signature}) => ({function.ReturnType.ToCSString()}) _{name}_fnptr({paramNames});");
            else
                apiWriter.WriteLine($"public static {returnType} {name}({signature}) => _{name}_fnptr({paramNames});");

            // Write the delegate
            apiWriter.WriteLine($"private static delegate* unmanaged<{delegateTypes}> _{name}_fnptr = &{name}_Lazy;");

            // Write the lazy loader
            apiWriter.WriteLine($"[UnmanagedCallersOnly]");
            apiWriter.WriteLine($"private static {returnType} {name}_Lazy({signature})");
            using (apiWriter.CsScope())
            {
                // Dotnet gurantees you can't get torn values when assigning function pointers, assuming proper allignment which is default.
                apiWriter.WriteLine($"_{name}_fnptr = (delegate* unmanaged<{delegateTypes}>){LoaderBindingsContext}.GetProcAddress(\"{function.EntryPoint}\");");

                if (function.ReturnType is not CSVoid)
                    apiWriter.WriteLine($"return _{name}_fnptr({paramNames});");
                else
                    apiWriter.WriteLine($"_{name}_fnptr({paramNames});");
            }
        }

        private static void WriteOverloads(string directoryPath, OutputApi api, IReadOnlyDictionary<string, GLVendorFunctions> groups)
        {

        }

        private static void WriteGLEnum(string directory, OutputApi api, IReadOnlyCollection<EnumEntry> allEnumEntries)
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

        private static void WriteOtherEnums(string directory, OutputApi api, IReadOnlyCollection<EnumGroup> enumGroups)
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
