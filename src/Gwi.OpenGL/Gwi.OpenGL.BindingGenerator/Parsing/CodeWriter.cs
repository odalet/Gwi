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
            if (!Directory.Exists(directory))
                _ = Directory.CreateDirectory(directory);

            const string className = "GL";
            foreach (var vendor in groups.Keys)
            {
                var isGeneralGroup = string.IsNullOrEmpty(vendor);

                // Main file goes to generated/<api>.api.cs
                var apiFileName = Path.Combine(directory, $"{className}.api.cs");
                var vtableFileName = Path.Combine(directory, $"{className}.vtable.cs");
                if (!isGeneralGroup)
                {
                    var dir = Path.Combine(directory, vendor);
                    if (!Directory.Exists(dir))
                        _ = Directory.CreateDirectory(dir);

                    // Extensions files goes to generated/<vendor>/<api>.<vendor>.cs
                    apiFileName = Path.Combine(dir, $"{className}.{vendor}.cs");
                    vtableFileName = Path.Combine(dir, $"{className}.{vendor}.vtable.cs");
                }

                using var apiStream = File.CreateText(apiFileName);
                using var apiWriter = new IndentedTextWriter(apiStream);
                using var vtableStream = File.CreateText(vtableFileName);
                using var vtableWriter = new IndentedTextWriter(vtableStream);

                apiWriter.WriteLine("// This file is auto generated, do not edit.");
                apiWriter.WriteLine("using System;");
                apiWriter.WriteLine("using System.Runtime.InteropServices;");
                apiWriter.WriteLine();
                apiWriter.WriteLine($"namespace {rootNamespace}.{api.GetNameInCode()}");

                vtableWriter.WriteLine("// This file is auto generated, do not edit.");
                vtableWriter.WriteLine();
                vtableWriter.WriteLine($"namespace {rootNamespace}.{api.GetNameInCode()}");

                using (apiWriter.CsScope())
                using (vtableWriter.CsScope())
                {
                    // pragmas
                    apiWriter.WriteLineNoTabs("#pragma warning disable S1144 // Unused private types or members should be removed");
                    apiWriter.WriteLineNoTabs("#pragma warning disable S1121 // Assignments should not be made from within sub-expressions");
                    apiWriter.WriteLineNoTabs("#pragma warning disable IDE1006 // Naming Styles");
                    apiWriter.WriteLineNoTabs("");

                    vtableWriter.WriteLineNoTabs("#pragma warning disable S1144 // Unused private types or members should be removed");
                    vtableWriter.WriteLineNoTabs("#pragma warning disable S1121 // Assignments should not be made from within sub-expressions");
                    vtableWriter.WriteLineNoTabs("#pragma warning disable IDE1006 // Naming Styles");
                    vtableWriter.WriteLineNoTabs("");

                    apiWriter.WriteLine($"unsafe partial class {className}");
                    vtableWriter.WriteLine($"unsafe partial class {className}");
                    using (apiWriter.CsScope())
                    using (vtableWriter.CsScope())
                    {
                        CsScope? extensionApiScope = null;
                        CsScope? extensionVTableScope = null;
                        if (!isGeneralGroup)
                        {
                            apiWriter.WriteLine($"public sealed unsafe partial class {vendor}");
                            vtableWriter.WriteLine($"unsafe partial class {vendor}");
                            extensionApiScope = apiWriter.CsScope();
                            extensionVTableScope = vtableWriter.CsScope();
                        }

                        vtableWriter.WriteLine($"private sealed unsafe class VTable : BaseVTable");
                        using (vtableWriter.CsScope())
                        {
                            vtableWriter.WriteLine("public VTable(INativeLib lib) : base(lib) { }");
                            vtableWriter.WriteLineNoTabs("");

                            var count = 0;
                            foreach (var nativeFunction in groups[vendor].NativeFunctions)
                            {
                                var hasPostfix = groups[vendor].NativeFunctionsWithPostfix.Contains(nativeFunction);
                                WriteNativeMethod(apiWriter, vtableWriter, nativeFunction, hasPostfix);

                                count++;
                                if (count != groups[vendor].NativeFunctions.Count)
                                {
                                    apiWriter.WriteLineNoTabs("");
                                    vtableWriter.WriteLineNoTabs("");
                                }
                            }
                        }

                        extensionVTableScope?.Dispose();
                        extensionApiScope?.Dispose();
                    }

                    // pragmas
                    vtableWriter.WriteLineNoTabs("");
                    vtableWriter.WriteLineNoTabs("#pragma warning restore IDE1006 // Naming Styles");
                    vtableWriter.WriteLineNoTabs("#pragma warning restore S1121 // Assignments should not be made from within sub-expressions");
                    vtableWriter.WriteLineNoTabs("#pragma warning restore S1144 // Unused private types or members should be removed");

                    apiWriter.WriteLineNoTabs("");
                    apiWriter.WriteLineNoTabs("#pragma warning restore IDE1006 // Naming Styles");
                    apiWriter.WriteLineNoTabs("#pragma warning restore S1121 // Assignments should not be made from within sub-expressions");
                    apiWriter.WriteLineNoTabs("#pragma warning restore S1144 // Unused private types or members should be removed");
                }

                vtableWriter.Flush();
                apiWriter.Flush();
            }
        }

        private static void WriteNativeMethod(IndentedTextWriter apiWriter, IndentedTextWriter vtableWriter, NativeFunction function, bool hasPostfix)
        {
            // Write the VTable
            var ep = function.EntryPoint;
            vtableWriter.WriteLine($"public nint {ep} => _{ep} != 0 ? _{ep} : _{ep} = Lib.GetProcAddress(\"{ep}\");");
            vtableWriter.WriteLine($"private nint _{ep};");

            // Write the API
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
