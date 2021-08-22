using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    // Debugging Helper
    internal static class ParseTreeDumper
    {
        public static void DumpToMarkdown(TextWriter writer, ParseTree specification)
        {
            writer.WriteLine("# OpenGL Specification");

            writer.WriteLine();
            writer.WriteLine("## Commands");
            writer.WriteLine();
            writer.WriteLine("```csharp");
            foreach (var command in specification.Commands)
                DumpCommand(writer, command);
            writer.WriteLine("```");

            writer.WriteLine();
            writer.WriteLine("## Enums");
            writer.WriteLine();
            writer.WriteLine("```csharp");
            foreach (var enumeration in specification.Enums)
                DumpEnumeration(writer, enumeration);
            writer.WriteLine("```");

            writer.WriteLine();
            writer.WriteLine("## Features");

            writer.WriteLine();
            writer.WriteLine("## Extensions");
        }

        private static void DumpCommand(TextWriter writer, Command command)
        {
            if (command.Namespace != "GL")
                writer.Write($"/* ns: {command.Namespace} */ ");
            writer.Write(Dump(command.ReturnType) + " ");
            writer.Write(command.EntryPoint + "(");

            var paramList = command.Parameters.Select(p =>
            {
                var sz = "";
                if (p.Length != null)
                    sz = $"/*{Dump(p.Length)}*/ ";
                return $"{sz}{Dump(p.Type)} {p.Name}";
            });
            var parameters = string.Join(", ", paramList) ?? "";

            writer.WriteLine(parameters + ");");
        }

        private static int indentLevel = 0;
        private static string Tabs => new(' ', 2 * indentLevel);

        private static void IncTabs() => indentLevel++;
        private static void DecTabs() => indentLevel--;

        private static void DumpEnumeration(TextWriter writer, Enum en)
        {
            if (en.Groups.Length == 0) return; // no name -> do not output

            writer.WriteLine($"{Tabs}namespace {en.Namespace} {{");
            IncTabs();

            if (en.Type == EnumType.Invalid)
                writer.WriteLine($"{Tabs}[Invalid]");
            else if (en.Type == EnumType.Bitmask)
                writer.WriteLine($"{Tabs}[Flags]");

            var name = "?";
                if (en.Groups.Length > 0)
                    name = en.Groups[0];
                if (en.Groups.Length > 1)
                    name += $" /* {string.Join(", ", en.Groups.Skip(1))} */";

            writer.WriteLine($"{Tabs}enum {name} {{");

            IncTabs();
            foreach (var entry in en.Entries)
                DumpEnumerationEntry(writer, entry, name);
            DecTabs();

            writer.WriteLine($"{Tabs}}}");
            DecTabs();
            writer.WriteLine($"{Tabs}}}");
        }

        private static void DumpEnumerationEntry(TextWriter writer, EnumEntry en, string enumName)
        {
            if (!string.IsNullOrEmpty(en.Comment))
                writer.WriteLine($"{Tabs}// {en.Comment}");

            var info = new List<string>();
            if (en.Api != GLApi.None) info.Add($"[{en.Api}]");
            if (!string.IsNullOrEmpty(en.Alias)) info.Add($"aka {en.Alias}");

            var groups = en.Groups.Where(g => g != enumName).ToArray();
            if (groups.Length > 0) info.Add($"groups: {string.Join(", ", groups)}");

            var infoText = "";
            if (info.Count > 0)
                infoText = $" // {string.Join(", ", info)}";

            writer.WriteLine($"{Tabs}{en.Name} = {en.Value},{infoText}");
        }

        private static string Dump(Expr expr) => expr switch
        {
            Constant c => c.Value.ToString(),
            ParameterReference p => p.ParameterName,
            BinaryOperation b => $"{Dump(b.Left)} {Dump(b.Operator)} {Dump(b.Right)}",
            CompSize s => $"CompSize({string.Join(", ", s.Parameters.Select(p => Dump(p)))})",
            _ => "?"
        };

        private static string Dump(BinaryOperator op) => op switch
        {
            BinaryOperator.Addition => "+",
            BinaryOperator.Subtraction => "-",
            BinaryOperator.Multiplication => "*",
            BinaryOperator.Division => "/",
            BinaryOperator.Invalid or _ => "?"
        };

        private static string Dump(PType type) => Dump(type.Type);
        private static string Dump(GLType type) => type switch
        {
            GLPointerType ptr => $"{Dump(ptr.BaseType)}*{(ptr.Constant ? " const" : "")}",
            GLBaseType b => $"{(b.Constant ? "const " : "")}{b.OriginalString}",
            _ => "T?"
        };
    }
}
