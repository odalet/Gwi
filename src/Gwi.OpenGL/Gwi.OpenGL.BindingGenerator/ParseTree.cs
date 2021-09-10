using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator
{
    internal sealed record ParseTree(List<Command> Commands);

    internal sealed record Command(string Namespace, string Name, PType ReturnType);

    internal sealed record PType(string Name);
}
