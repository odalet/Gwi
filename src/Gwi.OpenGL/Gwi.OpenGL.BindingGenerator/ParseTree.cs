using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator
{
    internal sealed record ParseTree(List<string> Vendors, List<Command> Commands, Enums Enums);

    internal sealed record Command(string EntryPoint, PType ReturnType, List<CommandParameter> Parameters);

    internal sealed record CommandParameter(string Name, PType Type, string Len);

    internal sealed record PType(GLType Type, string Declaration, string Group, string Class);

    internal sealed record Enums(List<EnumEntry> Entries, Dictionary<EnumGroup, List<EnumEntry>> EntriesByGroup);

    internal sealed record EnumEntry(string Name, string Alias, ulong Value, string OriginalValue, GLApi Api, bool IsULong);

    internal sealed record EnumGroup(string Name)
    {
        public EnumGroup(string name, string vendor, bool isBitMask) : this(name)
        {
            Vendor = vendor;
            IsBitMask = isBitMask;
        }

        public string Vendor { get; set; } = "";
        public bool IsBitMask { get; set; }
    }

    internal enum GLApi
    {
        Invalid,
        None,
        GL,
        GLES1,
        GLES2,
        GLSC2,
        GLCore,
    }
}
