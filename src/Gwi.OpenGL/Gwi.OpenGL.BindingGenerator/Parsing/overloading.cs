using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    public interface IOverloadLayer
    {
        public void WritePrologue(IndentedTextWriter writer, NameTable nameTable);
        public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName);
    }

    public interface IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads);

        // /!\ IMPORTANT /!\:
        // All return type overloaders need to run before any of the other overloaders.
        // This is to ensure correct scoping for the new return variables.
        // FIXME: Maybe we dont want classes for these?
        public static readonly IOverloader[] Overloaders = new IOverloader[]
        {
            new TrimNameOverloader(),
            new StringReturnOverloader(),
            new BoolOverloader(),
            //new MathTypeOverloader(),
            //new FunctionPtrToDelegateOverloader(),
            //new PointerToOffsetOverloader(),
            //new VoidPtrToIntPtrOverloader(),
            //new GenCreateAndDeleteOverloader(),
            //new StringOverloader(),
            //new SpanAndArrayOverloader(),
            //new RefInsteadOfPointerOverloader(),
            //new OutToReturnOverloader(),
        };
    }

    internal sealed class TrimNameOverloader : IOverloader
    {
        private static readonly Regex endingsAddV = new("^0", RegexOptions.Compiled);
        private static readonly Regex endings = new(@"(u?[sb](64)?v?|v|i_v|fi)$", RegexOptions.Compiled);
        private static readonly Regex endingsToKeep = new(
            "(sh|ib|[tdrey]s|[eE]n[vd]|bled" +
            "|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag" +
            "|Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through" +
            "|Uniforms|Varyings|Weight|Width|[1-4][fdhi]v)$", RegexOptions.Compiled);

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // See: https://github.com/opentk/opentk/blob/082c8d228d0def042b11424ac002776432f44f47/src/Generator.Bind/FuncProcessor.cs#L417
            var name = overload.OverloadName;
            var trimmedName = name;

            var m = endingsToKeep.Match(name); // FIXME: Remove extension name before we trim endings
            if (m.Index + m.Length != name.Length)
            {
                m = endings.Match(name);

                if (m.Length > 0 && m.Index + m.Length == name.Length)
                {
                    // Only trim endings, not internal matches.
                    if (m.Value[m.Length - 1] == 'v' && endingsAddV.IsMatch(name) && !name.StartsWith("Get") && !name.StartsWith("MatrixIndex"))
                        trimmedName = name.Substring(0, m.Index) + "v"; // Only trim ending 'v' when there is a number
                    else trimmedName = name.EndsWith("xedv") ? name.Substring(0, m.Index + 1) : name.Substring(0, m.Index);
                }
            }

            if (trimmedName == name)
            {
                newOverloads = default;
                return false;
            }

            newOverloads = new List<Overload>
            {
                overload with
                {
                    OverloadName = trimmedName,
                    NestedOverload = overload,
                    MarshalLayerToNested = null
                }
            };

            return true;
        }
    }

    internal sealed class StringReturnOverloader : IOverloader
    {
        private record StringReturnLayer(string NewReturnName) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable) => writer.WriteLine($"string? {NewReturnName};");

            public string WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine($"{NewReturnName} = Marshal.PtrToStringAnsi((IntPtr){returnName});");
                return NewReturnName;
            }
        }

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // See: https://github.com/KhronosGroup/OpenGL-Registry/issues/363
            // These are the only two functions that return strings as of 2020-12-29
            if (overload.NativeFunction.EntryPoint is not "glGetString" and not "glGetStringi")
            {
                newOverloads = default;
                return false;
            }

            var newReturnName = $"{overload.ReturnVariableName}_str";
            var layer = new StringReturnLayer(newReturnName);
            var returnType = new CSString(Nullable: true);
            newOverloads = new List<Overload>
            {
                overload with
                {
                    NestedOverload = overload,
                    MarshalLayerToNested = layer,
                    ReturnType = returnType,
                    ReturnVariableName = newReturnName
                }
            };

            return true;
        }
    }

    internal sealed class BoolOverloader : IOverloader
    {
        private record BoolLayer(IEnumerable<(Parameter byteParam, Parameter boolParam)> OverloadedParameters) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                foreach (var (byteParam, boolParam) in OverloadedParameters)
                    writer.WriteLine($"var {nameTable[byteParam]} = (byte)({nameTable[boolParam]} ? 1 : 0);");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName) => returnName;
        }

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var parameters = overload.InputParameters.ToArray();
            var nameTable = overload.NameTable;
            var overloadedParameters = new List<(Parameter byteParam, Parameter boolParam)>();

            for (var i = 0; i < parameters.Length; i++)
            {
                var parameter = parameters[i];
                if (parameter.Type is not CSBool8 bool8)
                    continue;

                nameTable.Rename(parameter, parameter.Name + "_byte");
                parameters[i] = parameter with { Type = new CSPrimitive("bool", bool8.Constant) };
                overloadedParameters.Add((parameter, parameters[i]));
            }

            if (overloadedParameters.Count == 0)
            {
                newOverloads = null;
                return false;
            }

            newOverloads = new List<Overload>()
            {
                overload with 
                {
                    NestedOverload = overload,
                    MarshalLayerToNested = new BoolLayer(overloadedParameters),
                    InputParameters = parameters,
                    NameTable = nameTable 
                }
            };

            return true;
        }

        
    }
}
