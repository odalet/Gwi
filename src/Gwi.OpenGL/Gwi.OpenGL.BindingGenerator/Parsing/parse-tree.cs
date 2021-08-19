using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    // The parse tree that is the result of parsing gl.xml

    // Root of the tree
    public record Specification(
        IEnumerable<Command> Commands,
        IEnumerable<Enumeration> Enumerations,
        IEnumerable<Feature> Features,
        IEnumerable<Extension> Extensions);

    public record Command(
        string Namespace,
        string EntryPoint,
        PType ReturnType,
        GLParameter[] Parameters);

    public record Enumeration();
    public record Feature();
    public record Extension();

    public record PType();

    public record GLParameter(
        PType Type,
        string Name,
        Expr? Length);
}
