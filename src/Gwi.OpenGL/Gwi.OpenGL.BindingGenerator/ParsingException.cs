using System;

namespace Gwi.OpenGL.BindingGenerator
{
    public sealed class ParsingException : ApplicationException
    {
        public ParsingException(string? message) : base(message) { }
    }
}
