using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NLog;

namespace Gwi.OpenGL.BindingGenerator
{
    internal sealed class CodeGenerator : BaseProcessor
    {
        private const string baseNamespace = "Gwi";
        private const string rootNamespace = baseNamespace + ".OpenGL";
        private static readonly ILogger log = LogManager.GetCurrentClassLogger();

        private Dictionary<string, string>? vendorsMap; // Maps original names to C#ized ones
        private Dictionary<string, string>? enumsMap; // Maps original names to C#ized ones

        public CodeGenerator(string outputDirectory, bool debug) : base(log)
        {
            OutputDirectory = Path.IsPathRooted(outputDirectory) ? outputDirectory : Path.Combine(Environment.CurrentDirectory, outputDirectory);
            EmitDebugComments = debug;
        }

        private string OutputDirectory { get; }
        private bool EmitDebugComments { get; }

        public void Write(ParseTree parseTree)
        {
            LogInfo($"Code will be produced in {OutputDirectory}");
            CreateOutputDirectory();

            // Retrieve vendor suffixes and associate them a C# name
            vendorsMap = parseTree.Vendors.ToDictionary(x => x, Utils.TransformVendor);

            // Raw API
            WriteNativeFunctions(OutputDirectory, parseTree.Commands);
            WriteConstants(OutputDirectory, parseTree.Enums.Entries);

            // High-level API
            enumsMap = WriteEnums(OutputDirectory, parseTree.Enums);
        }

        private void CreateOutputDirectory()
        {
            if (Directory.Exists(OutputDirectory))
            {
                // Cleanup contents
                LogDebug($"Directory {OutputDirectory} exists; removing all previously generated code");

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
                LogDebug($"Directory {OutputDirectory} does not exist; creating it");
                _ = Directory.CreateDirectory(OutputDirectory);
            }
        }

        private static void WriteNativeFunctions(string directory, List<Command> commands)
        {
            WriteVTables(directory, commands);
            WriteApi(directory, commands);
        }

        private static void WriteVTables(string directory, List<Command> commands)
        {
            var filename = Path.Combine(directory, $"GL.vtable.cs");
            using var stream = File.CreateText(filename);
            using var writer = new IndentedTextWriter(stream);

            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLineNoTabs("#pragma warning disable IDE1006 // Naming Styles");
            writer.WriteLine($"namespace {rootNamespace}");
            using (writer.CsScope())
            {
                writer.WriteLine($"unsafe partial class GL");
                using (writer.CsScope())
                {
                    writer.WriteLine($"unsafe partial class GLApi");
                    using (writer.CsScope())
                    {
                        writer.WriteLine("unsafe partial class VTable");
                        using (writer.CsScope())
                        {
                            var count = 0;
                            foreach (var command in commands)
                            {
                                var ep = command.EntryPoint;
                                writer.WriteLine($"public nint {ep} => _{ep} != 0 ? _{ep} : _{ep} = GetProcAddress(\"{ep}\");");
                                writer.WriteLine($"private nint _{ep};");

                                count++;
                                if (count != commands.Count)
                                    writer.WriteLineNoTabs("");
                            }
                        }
                    }
                }
            }

            writer.WriteLineNoTabs("#pragma warning restore IDE1006 // Naming Styles");
        }

        private static void WriteApi(string directory, List<Command> commands)
        {
            // First let's collect the methods declarations and implementations
            var methods = new List<(string declaration, string implementation)>();
            foreach (var command in commands)
            {
                var args = new List<string>();
                var typedArgs = new List<(string type, string name)>();
                var delegateTypes = new List<string>();
                foreach (var parameter in command.Parameters)
                {
                    var type = parameter.Type.ToCSharpType().WriteUnderlying();
                    var parameterName = Utils.Normalize(parameter.Name);

                    args.Add(parameterName);
                    typedArgs.Add((type, parameterName));
                    delegateTypes.Add(type);
                }

                var returnType = command.ReturnType.ToCSharpType().WriteUnderlying();
                delegateTypes.Add(returnType);

                var ep = command.EntryPoint;
                var cast = $"delegate* unmanaged[Cdecl]<{string.Join(", ", delegateTypes)}>";
                var callArguments = string.Join(", ", typedArgs.Select(a => $"{a.type} {a.name}"));

                methods.Add((
                    declaration: $"{returnType} {ep}({callArguments})",
                    implementation: $"(({cast})vtable.{ep})({string.Join(", ", args)})"
                ));
            }

            // Emit to the IGLApi interface and GLApi class
            WriteApi(directory, methods, isInterface: true);
            WriteApi(directory, methods, isInterface: false);
        }

        private static void WriteApi(string directory, List<(string declaration, string implementation)> methods, bool isInterface)
        {
            var filename = Path.Combine(directory, isInterface ? "GL.interface.cs" : "GL.implementation.cs");
            using var stream = File.CreateText(filename);
            using var writer = new IndentedTextWriter(stream);

            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLineNoTabs("#pragma warning disable IDE1006 // Naming Styles");
            writer.WriteLine($"namespace {rootNamespace}");
            using (writer.CsScope())
            {
                writer.WriteLine($"unsafe partial class GL");
                using (writer.CsScope())
                {
                    writer.WriteLine($"unsafe partial {(isInterface ? "interface IGLApi" : "class GLApi")}");
                    using (writer.CsScope())
                    {
                        foreach (var (declaration, implementation) in methods)
                            writer.WriteLine(isInterface ? $"{declaration};" : $"public {declaration} => {implementation};");
                    }
                }
            }

            writer.WriteLineNoTabs("#pragma warning restore IDE1006 // Naming Styles");
        }

        private static void WriteConstants(string directory, List<EnumEntry> entries)
        {
            var filename = Path.Combine(directory, $"GLConstants.cs");
            using var stream = File.CreateText(filename);
            using var writer = new IndentedTextWriter(stream);

            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine($"namespace {rootNamespace}");
            using (writer.CsScope())
            {
                writer.WriteLine($"public static class GLConstants");
                using (writer.CsScope())
                    foreach (var entry in entries)
                    {
                        var type = entry.IsULong ? "ulong" : "uint";
                        if (!string.IsNullOrEmpty(entry.Alias))
                            writer.WriteLine($"public const {type} {entry.Name} = {entry.Alias}; // {entry.OriginalValue}");
                        else
                            writer.WriteLine($"public const {type} {entry.Name} = 0x{entry.Value:X}; // {entry.OriginalValue}");
                    }
            }
        }

        private Dictionary<string, string> WriteEnums(string directory, Enums enums)
        {
            var map = new Dictionary<string, string>();
            WriteEnum(directory, "GLEnum", enums.Entries, isBitMask: false);
            map.Add("GLEnum", "GLEnum");

            // Grouped enums
            var dir = Path.Combine(directory, "enums");
            _ = Directory.CreateDirectory(dir);
            foreach (var group in enums.EntriesByGroup.Keys)
            {
                var enumName = Utils.ConvertEnumNameToCSharpName(group.Name, vendorsMap!);
                map.Add(group.Name, enumName);

                WriteEnum(dir, enumName, enums.EntriesByGroup[group], group.IsBitMask);
            }

            return map;
        }

        private void WriteEnum(string directory, string enumName, List<EnumEntry> entries, bool isBitMask)
        {
            var filename = Path.Combine(directory, $"{enumName}.cs");
            using var stream = File.CreateText(filename);
            using var writer = new IndentedTextWriter(stream);

            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine("#pragma warning disable CA1069 // Enums values should not be duplicated");
            writer.WriteLine($"namespace {rootNamespace}");
            using (writer.CsScope())
            {
                if (isBitMask)
                    writer.WriteLine("[Flags]");
                writer.WriteLine($"public enum {enumName} : uint");
                using (writer.CsScope())
                {
                    var count = 0;
                    var entriesToProcess = entries.Where(e => !e.IsULong).ToArray();
                    foreach (var entry in entriesToProcess)
                    {
                        count++;
                        var name = Utils.ConvertEnumEntryToCSharpName(entry.Name, vendorsMap!);
                        writer.Write($"{name} = GLConstants.{entry.Name}");
                        if (count < entriesToProcess.Length)
                            writer.WriteLine(",");
                        else
                            writer.WriteLine();
                    }
                }
            }

            writer.WriteLine("#pragma warning restore CA1069 // Enums values should not be duplicated");
        }
    }
}
