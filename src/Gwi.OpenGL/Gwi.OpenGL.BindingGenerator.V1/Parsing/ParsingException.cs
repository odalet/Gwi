using System;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    public sealed class ParsingException : ApplicationException
    {
        public ParsingException(string? message) : base(message) { }
    }
}
