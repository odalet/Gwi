using System;
using System.CodeDom.Compiler;

namespace Gwi.OpenGL.BindingGenerator.Utils
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

    internal static class IndentedTextWriterExtension
    {
        public static Indentation Indent(this IndentedTextWriter writer) => new(writer);
        public static CsScope CsScope(this IndentedTextWriter writer) => new(writer);
    }
}
