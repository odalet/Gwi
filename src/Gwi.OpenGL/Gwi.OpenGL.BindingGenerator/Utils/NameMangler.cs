using System;

namespace Gwi.OpenGL.BindingGenerator.Utils
{
    internal static class NameMangler
    {
        public static string RemoveStart(string text, string start) =>
            text.StartsWith(start) ?
            text[start.Length..] :
            throw new ArgumentException($"'{text}' dosen't start with '{start}'", nameof(start));
    }
}
