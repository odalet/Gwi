using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    // FIXME: Clean up our naming/renaming of variables entirely. Do we even need/want a nametable?
    // If we do this is definitely not the correct API for it.
    public class NameTable
    {
        public Dictionary<Parameter, string> Table = new();

        public NameTable() { }
        public NameTable(NameTable table) => Table = new Dictionary<Parameter, string>(table.Table);

        public NameTable New() => new(this);
        public void Rename(Parameter param, string name) => Table[param] = name;

        public string this[Parameter param]
        {
            get
            {
                if (!Table.TryGetValue(param, out var name))
                    name = param.Name;

                return name;
            }
        }

        public void Apply(NameTable table)
        {
            foreach (var (param, name) in table.Table)
                Table[param] = name;
        }
    }
}
