using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gwi.OpenGL.BindingGenerator
{
    internal readonly struct Indentation : IDisposable
    {
        public Indentation(IndentedTextWriter writer)
        {
            Writer = writer;
            Writer.Indent++;
        }

        public IndentedTextWriter Writer { get; }

        public void Dispose() => Writer.Indent--;
    }

    internal readonly struct CsScope : IDisposable
    {
        public CsScope(IndentedTextWriter writer)
        {
            Writer = writer;
            Writer.WriteLine("{");
            Writer.Indent++;
        }

        public IndentedTextWriter Writer { get; }

        public void Dispose()
        {
            Writer.Indent--;
            Writer.WriteLine("}");
        }
    }

    internal static class Utils
    {
        public static Indentation Indent(this IndentedTextWriter writer) => new(writer);
        public static CsScope CsScope(this IndentedTextWriter writer) => new(writer);

        public static string TransformVendor(string vendor)
        {
            // This is the only one starting with a number
            if (vendor == "3DFX")
                return "ThreeDfx";

            if (vendor.Length <= 2)
                return vendor.ToUpperInvariant();

            if (vendor.All(c => char.IsUpper(c)))
                return vendor[0] + vendor[1..].ToLowerInvariant();

            return vendor;
        }

        public static string Normalize(string name) => name switch
        {
            "base" => "@base",
            "event" => "@event",
            "in" => "input",
            "object" => "obj",
            "params" => "parameters",
            "ref" => "reference",
            "string" => "str",
            _ => name
        };

        public static string ConvertEnumNameToCSharpName(string name, Dictionary<string, string> replacements)
        {
            foreach (var replacement in replacements.Keys.OrderByDescending(x => x.Length))
            {
                if (name.EndsWith(replacement))
                    return name.Replace(replacement, replacements[replacement]);
            }

            return name;
        }

        public static string ConvertEnumEntryToCSharpName(string name, Dictionary<string, string> replacements)
        {
            static string pascalize(string input) => input[0].ToString().ToUpperInvariant() + input[1..].ToLowerInvariant();

            var result = RemoveStart(name, "GL_");
            var parts = result.Split('_', StringSplitOptions.RemoveEmptyEntries);

            var builder = new StringBuilder();
            foreach (var part in parts)
                _ = builder.Append(replacements.ContainsKey(part) ? replacements[part] : pascalize(part));

            var str = builder.ToString();
            return char.IsDigit(result[0]) ? "_" + str : str;
        }

        // SCREAMING_CASE -> PascalCase
        private static string ToPascalCase(string name)
        {
            var builder = new StringBuilder(name.Length);
            if (char.IsDigit(name[0]))
                _ = builder.Append('_');

            var nextCharacterIsUpperCase = true;
            for (var i = 0; i < name.Length; i++)
            {
                var c = name[i];
                if (c == '_')
                    nextCharacterIsUpperCase = true;
                else
                {
                    _ = builder.Append(nextCharacterIsUpperCase ? char.ToUpperInvariant(c) : char.ToLowerInvariant(c));
                    nextCharacterIsUpperCase = false;
                }
            }

            return builder.ToString();
        }

        private static string RemoveStart(string text, string start) =>
            text.StartsWith(start) ?
            text[start.Length..] :
            throw new ArgumentException($"'{text}' dosen't start with '{start}'", nameof(start));
    }
}
