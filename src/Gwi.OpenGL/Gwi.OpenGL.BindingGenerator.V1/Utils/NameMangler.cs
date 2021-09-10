using System;
using System.Text;

namespace Gwi.OpenGL.BindingGenerator.Utils
{
    internal static class NameMangler
    {
        public static string RemoveStart(string text, string start) =>
            text.StartsWith(start) ?
            text[start.Length..] :
            throw new ArgumentException($"'{text}' dosen't start with '{start}'", nameof(start));

        // glDoSomething -> DoSomething
        public static string MangleFunctionName(string name) => RemoveStart(name, "gl");

        // GL_ENUMERATION_MEMBER -> EnumerationMember
        public static string MangleEnumName(string name) => MangleMemberName(RemoveStart(name, "GL_"));

        public static string MangleParameterName(string name) => name switch
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

        // SCREAMING_CASE -> PascalCase
        private static string MangleMemberName(string name)
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
    }
}
