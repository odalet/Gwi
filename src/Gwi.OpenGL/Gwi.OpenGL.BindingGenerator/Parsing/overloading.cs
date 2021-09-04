using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;
using Gwi.OpenGL.BindingGenerator.Utils;
using NLog;

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
            new MathTypeOverloader(),
            new FunctionPtrToDelegateOverloader(),
            new PointerToOffsetOverloader(),
            new VoidPtrToIntPtrOverloader(),
            new GenCreateAndDeleteOverloader(),
            new StringOverloader(),
            new SpanAndArrayOverloader(),
            new RefInsteadOfPointerOverloader(),
            new OutToReturnOverloader()
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

    internal sealed class MathTypeOverloader : IOverloader
    {
        // Math type overloads have 3 different types.
        // One is a Reference type, and has no length parameter for arrays of math types.
        // The other two are arrays and spans. These both include the length parameter.

        private record SingleVectorLayer(Parameter CountParameters, Parameter PtrParam, Parameter VectorParam) : IOverloadLayer
        {
            private CsScope scope;

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                var vectorType = ((CSRef)VectorParam.Type).ReferencedType;
                writer.WriteLine($"{CountParameters.Type.ToCSString()} {nameTable[CountParameters]} = 1;");
                writer.WriteLine($"fixed ({vectorType.ToCSString()}* tmp_vecPtr = &{nameTable[VectorParam]})");
                scope = writer.CsScope();
                writer.WriteLine($"{PtrParam.Type.ToCSString()} {nameTable[PtrParam]} = ({PtrParam.Type.ToCSString()})tmp_vecPtr;");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                scope.Dispose();
                return returnName;
            }
        }

        private record SpanArrayVectorLayer(Parameter CountParameter, Parameter PtrParam, Parameter VectorParam) : IOverloadLayer
        {
            private CsScope scope;

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                var vectorType = ((CSRef)VectorParam.Type).ReferencedType;
                writer.WriteLine($"fixed ({vectorType.ToCSString()}* tmp_vecPtr = {nameTable[VectorParam]})");
                scope = writer.CsScope();
                writer.WriteLine($"{PtrParam.Type.ToCSString()} {nameTable[PtrParam]} = ({PtrParam.Type.ToCSString()})tmp_vecPtr;");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                scope.Dispose();
                return returnName;
            }
        }

        private static readonly Regex vectorNameMatch = new("([1-4])([fdhi])v$", RegexOptions.Compiled); // Matches names of vector methods.        
        private static readonly Regex matrixNameMatch = new("(Matrix([1-4])(?:x([1-4]))?[fd])v$", RegexOptions.Compiled); // Matches names of matrix methods.
        private static readonly HashSet<string> existingTypes = new() // This is used to make sure we don't overload types that arent supported.
        {
            // Vectors
            "Vector2",
            "Vector2d",
            "Vector2h",
            "Vector2i",
            "Vector3",
            "Vector3d",
            "Vector3h",
            "Vector3i",
            "Vector4",
            "Vector4d",
            "Vector4h",
            "Vector4i",

            // Matrices

            // double matrices.
            "Matrix2d",
            "Matrix2x3d",
            "Matrix2x4d",
            "Matrix3x2d",
            "Matrix3d",
            "Matrix3x4d",
            "Matrix4x2d",
            "Matrix4x3d",
            "Matrix4d",

            // float matrices.
            "Matrix2",
            "Matrix2x3",
            "Matrix2x4",
            "Matrix3x2",
            "Matrix3",
            "Matrix3x4",
            "Matrix4x2",
            "Matrix4x3",
            "Matrix4",
        };

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // Match with either a matrix or a vector.
            var vectorMatch = vectorNameMatch.Match(overload.OverloadName);
            var matrixMatch = matrixNameMatch.Match(overload.OverloadName);

            // The vector size is used to check that we overload the right parameter later on.
            int vectorSize;
            string typePostfix;
            string typeName;
            if (matrixMatch.Success)
            {
                typeName = matrixMatch.Groups[1].Value;
                var columns = int.Parse(matrixMatch.Groups[2].Value);
                var rows = matrixMatch.Groups[3].Success ? int.Parse(matrixMatch.Groups[3].Value) : columns;
                vectorSize = columns * rows;
            }
            else if (vectorMatch.Success)
            {
                vectorSize = int.Parse(vectorMatch.Groups[1].Value);
                typePostfix = vectorMatch.Groups[2].Value;
                if (typePostfix == "f") typePostfix = "";
                typeName = $"Vector{vectorSize}{typePostfix}";
            }
            else
            {
                newOverloads = null;
                return false;
            }

            var nameTable = overload.NameTable.New();
            var singleParameters = overload.InputParameters.ToArray();
            var spanParameters = overload.InputParameters.ToArray();
            var arrayParameters = overload.InputParameters.ToArray();
            Parameter? lengthParameter = null;
            Parameter? ptrParam = null;
            Parameter? vectorParam = null;

            for (var i = 0; i < singleParameters.Length; i++)
            {
                var parameter = singleParameters[i];
                if (parameter.Length == null) continue;
                if (parameter.Type is CSPointer ptr && ptr.BaseType is CSPrimitive baseType)
                {
                    // Some vector methods arent actually vectors.
                    // So we just overload them like their normal types.
                    // An example of this is glUniform1f
                    if (!existingTypes.Contains(typeName))
                        typeName = baseType.TypeName;

                    Constant constant;
                    if (parameter.Length is Constant c)
                        constant = c;
                    else if (parameter.Length is BinaryOperation binary)
                    {
                        // We need to figure out which operator side is the length of the vector type.
                        // and which side is the parameter reference.
                        // The side with the parameter reference references the length parameter of an array.
                        ParameterReference reference;
                        if (binary.Left is ParameterReference leftRef && binary.Right is Constant rightConst)
                        {
                            reference = leftRef;
                            constant = rightConst;
                        }
                        else if (binary.Right is ParameterReference rightRef && binary.Left is Constant leftConst)
                        {
                            reference = rightRef;
                            constant = leftConst;
                        }
                        else continue;

                        lengthParameter = singleParameters.First(p => p.Name == reference.ParameterName);
                    }
                    else continue;

                    if (constant.Value == vectorSize)
                    {
                        var vector = new CSStruct(typeName, baseType.Constant, null);
                        singleParameters[i] = parameter with
                        {
                            Type = new CSRef(baseType.Constant ? CSRef.Type.In : CSRef.Type.Ref, vector),
                            Length = null
                        };

                        spanParameters[i] = parameter with
                        {
                            Type = new CSSpan(vector, baseType.Constant),
                            Length = null
                        };

                        arrayParameters[i] = parameter with
                        {
                            Type = new CSArray(vector),
                            Length = null
                        };

                        nameTable.Rename(parameter, parameter.Name + "_ptr");
                        ptrParam = parameter;
                        vectorParam = singleParameters[i];

                        // For now we only overload one MathType parameter as the spec only contains one old
                        // extension (GL_SUN_vertex) with methods that have multiple vectors per method.
                        // 29-05-2021 FrederikJA
                        break;
                    }
                }
            }

            // Check if any overloads were generated.
            if (lengthParameter == null || ptrParam == null || vectorParam == null)
            {
                newOverloads = null;
                return false;
            }

            // Remove the 'v' from the overloaded name.
            var overloadName = overload.OverloadName.Remove(vectorMatch.Index + vectorMatch.Length - 1, 1);
            newOverloads = new List<Overload>()
            {
                overload with
                {
                    OverloadName = overloadName,
                    InputParameters = singleParameters.Where(p => p != lengthParameter).ToArray(),
                    NameTable = nameTable,
                    NestedOverload = overload,
                    MarshalLayerToNested = new SingleVectorLayer(lengthParameter, ptrParam, vectorParam)
                },
                overload with
                {
                    OverloadName = overloadName,
                    InputParameters = spanParameters,
                    NameTable = nameTable,
                    NestedOverload = overload,
                    MarshalLayerToNested = new SpanArrayVectorLayer(lengthParameter, ptrParam, vectorParam)
                },
                overload with
                {
                    OverloadName = overloadName,
                    InputParameters = arrayParameters,
                    NameTable = nameTable,
                    NestedOverload = overload,
                    MarshalLayerToNested = new SpanArrayVectorLayer(lengthParameter, ptrParam, vectorParam)
                },
            };

            return true;
        }
    }

    internal sealed class FunctionPtrToDelegateOverloader : IOverloader
    {
        private sealed class FunctionPtrToDelegateLayer : IOverloadLayer
        {
            public FunctionPtrToDelegateLayer(List<Parameter> delegateParameters, List<Parameter> pointerParameters)
            {
                DelegateParameters = delegateParameters;
                PointerParameters = pointerParameters;
            }

            public List<Parameter> DelegateParameters { get; }
            public List<Parameter> PointerParameters { get; }

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                for (var i = 0; i < DelegateParameters.Count; i++)
                {
                    var type = PointerParameters[i].Type.ToCSString();
                    writer.WriteLine($"{type} {nameTable[PointerParameters[i]]} = Marshal.GetFunctionPointerForDelegate({nameTable[DelegateParameters[i]]});");
                }
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName) => returnName;
        }

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var parameters = new Parameter[overload.InputParameters.Length];
            var original = new List<Parameter>();
            var changed = new List<Parameter>();
            var nameTable = overload.NameTable.New();

            for (var i = 0; i < overload.InputParameters.Length; i++)
            {
                var parameter = overload.InputParameters[i];
                parameters[i] = parameter;

                if (parameter.Type is CSFunctionPointer fpt)
                {
                    nameTable.Rename(parameter, $"{parameter.Name}_ptr"); // Rename the parameter
                    original.Add(parameters[i]);
                    parameters[i] = parameters[i] with { Type = new CSDelegateType(fpt.TypeName) };
                    changed.Add(parameters[i]);
                }
            }

            newOverloads = changed.Count == 0 ? null : new List<Overload>()
            {
                overload with
                {
                    NestedOverload = overload,
                    MarshalLayerToNested = new FunctionPtrToDelegateLayer(changed, original),
                    InputParameters = parameters,
                    NameTable = nameTable
                }
            };

            return newOverloads != null;
        }
    }

    internal sealed class PointerToOffsetOverloader : IOverloader
    {
        private sealed record PointerToOffsetLayer(Parameter PointerParameter, Parameter OffsetParameter) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable) => writer.WriteLine(
                $"{PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = ({PointerParameter.Type.ToCSString()}){nameTable[OffsetParameter]};");

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName) => returnName;
        }

        private static readonly ILogger log = LogManager.GetCurrentClassLogger();
        private static readonly Dictionary<string, string> methodsAndParametersToOverload = new()
        {
            // Draw elements permutations.
            { "glDrawElements", "indices" },
            { "glDrawElementsBaseVertex", "indices" },
            { "glDrawElementsBaseVertexEXT", "indices" },
            { "glDrawElementsBaseVertexOES", "indices" },
            { "glDrawElementsInstanced", "indices" },
            { "glDrawElementsInstancedANGLE", "indices" },
            { "glDrawElementsInstancedARB", "indices" },
            { "glDrawElementsInstancedBaseInstance", "indices" },
            { "glDrawElementsInstancedBaseInstanceEXT", "indices" },
            { "glDrawElementsInstancedBaseVertex", "indices" },
            { "glDrawElementsInstancedBaseVertexBaseInstance", "indices" },
            { "glDrawElementsInstancedBaseVertexBaseInstanceEXT", "indices" },
            { "glDrawElementsInstancedBaseVertexEXT", "indices" },
            { "glDrawElementsInstancedBaseVertexOES", "indices" },
            { "glDrawElementsInstancedEXT", "indices" },
            { "glDrawElementsInstancedNV", "indices" },
            { "glDrawRangeElements", "indices" },
            { "glDrawRangeElementsBaseVertex", "indices" },
            { "glDrawRangeElementsBaseVertexEXT", "indices" },
            { "glDrawRangeElementsBaseVertexOES", "indices" },
            { "glDrawRangeElementsEXT", "indices" },
            // FIXME: These methods contain an array of offsets, which we cannot currently handle.
            // {"glMultiDrawElements", "indices"},
            // {"glMultiDrawElementsBaseVertex", "indices"},
            // {"glMultiDrawElementsBaseVertexEXT", "indices"},
            // {"glMultiDrawElementsEXT", "indices"},
            // {"glMultiModeDrawElementsIBM", "indices"},

            // Vertex attribute pointer permutations.
            { "glVertexAttribPointer", "pointer" },
            { "glVertexAttribIPointer", "pointer" },
            { "glVertexAttribLPointer", "pointer" },
        };

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            if (methodsAndParametersToOverload.TryGetValue(overload.NativeFunction.EntryPoint, out var parameterName) == false)
            {
                newOverloads = null;
                return false;
            }

            // Get the parameter index.
            var parameterIndex = Array.FindIndex(overload.InputParameters, p => p.Name == parameterName);
            if (parameterIndex == -1)
            {
                log.Warn($"{overload.NativeFunction.Name} does not have a parameter with the name {parameterName}");
                newOverloads = null;
                return false;
            }

            var nameTable = overload.NameTable.New();
            var pointerParameter = overload.InputParameters[parameterIndex];
            var offsetParameter = pointerParameter with { Type = new CSPrimitive("nint", false), Name = "offset", Length = null };

            var newParameters = overload.InputParameters.ToArray();
            newParameters[parameterIndex] = offsetParameter;
            nameTable.Rename(pointerParameter, pointerParameter.Name);
            newOverloads = new List<Overload>()
            {
                overload with
                {
                    NestedOverload = overload,
                    MarshalLayerToNested = new PointerToOffsetLayer(pointerParameter, offsetParameter),
                    InputParameters = newParameters,
                    NameTable = nameTable
                }
            };

            return true;
        }
    }

    internal sealed class VoidPtrToIntPtrOverloader : IOverloader
    {
        private sealed record VoidPtrToIntPtrOverloadLayer(List<(Parameter VPtr, Parameter IPtr)> ParameterNames) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                foreach (var (vptr, iptr) in ParameterNames)
                    writer.WriteLine($"void* {nameTable[vptr]} = (void*){nameTable[iptr]};");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName) => returnName;
        }

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var parameters = overload.InputParameters.ToArray();
            var nameTable = overload.NameTable.New();
            var parameterNames = new List<(Parameter VPtr, Parameter IPtr)>();

            for (var i = 0; i < parameters.Length; i++)
            {
                var parameter = parameters[i];
                if (parameter.Type is not CSPointer pointerType || pointerType.BaseType is not CSVoid)
                    continue;

                nameTable.Rename(parameter, parameter.Name + "_vptr");
                parameters[i] = parameter with { Type = new CSPrimitive("IntPtr", false), Length = null };
                parameterNames.Add((parameter, parameters[i]));
            }

            if (parameterNames.Count == 0)
            {
                newOverloads = null;
                return false;
            }

            newOverloads = new List<Overload>()
            {
                overload with
                {
                    NestedOverload = overload,
                    InputParameters = parameters,
                    MarshalLayerToNested = new VoidPtrToIntPtrOverloadLayer(parameterNames),
                    NameTable = nameTable
                },
                overload,
            };

            return true;
        }
    }

    internal sealed class GenCreateAndDeleteOverloader : IOverloader
    {
        private record DeleteOverloadLayer(Parameter LengthParameter, Parameter InParameter, Parameter PointerParameter) : IOverloadLayer
        {
            private CsScope scope;

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = 1;");
                writer.WriteLine(
                    $"fixed({PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = &{nameTable[InParameter]})");
                scope = writer.CsScope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                scope.Dispose();
                return returnName;
            }
        }

        private record GenAndCreateOverloadLayer(Parameter LengthParameter, Parameter OutParameter, Parameter PointerParameter) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = 1;");
                writer.WriteLine($"Unsafe.SkipInit(out {nameTable[OutParameter]});");
                // FIXME
                writer.WriteLine("// FIXME: This could be a problem for the overloads that take an out parameter");
                writer.WriteLine("// as this parameter could *potentially* move while inside of this function");
                writer.WriteLine("// which would mean that the new value never gets written to the out parameter.");
                writer.WriteLine("// Making for a nasty bug.");
                writer.WriteLine("// The reason we don't use a fixed expression here is because of the \"single out parameter to return value\" overloading step");
                writer.WriteLine("// that will make it so this tries to fix a local variable which is not allowed in C# for some reason.");
                writer.WriteLine("// If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk");
                writer.WriteLine("// - 2021-05-18");

                writer.WriteLine($"{PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = ({PointerParameter.Type.ToCSString()})Unsafe.AsPointer(ref {nameTable[OutParameter]});");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName) => returnName;
        }

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var nativeName = overload.NativeFunction.Name;
            if (!nativeName.StartsWith("Create") && !nativeName.StartsWith("Gen") && !nativeName.StartsWith("Delete") || !nativeName.EndsWith("s"))
            {
                newOverloads = default;
                return false;
            }

            // Here we assume that the last parameter is the pointer parameter.
            var pointerParameter = overload.InputParameters.LastOrDefault();

            if (pointerParameter == null || pointerParameter.Type is not CSPointer pointerParameterType)
            {
                newOverloads = default;
                return false;
            }

            if (pointerParameter.Length == null || pointerParameter.Length is not ParameterReference handleLength)
            {
                newOverloads = default;
                return false;
            }

            var newName = nativeName[..^1];

            var lengthParameterIndex = -1;
            var parameters = new Parameter[overload.InputParameters.Length - 1];

            for (var i = 0; i < overload.InputParameters.Length - 1; i++)
            {
                var parameter = overload.InputParameters[i];
                if (parameter.Name.Equals(handleLength.ParameterName))
                    lengthParameterIndex = i;
                else
                    parameters[lengthParameterIndex != -1 ? i + 1 : i] = parameter;
            }

            if (lengthParameterIndex == -1)
                throw new ParsingException($"Couldnt find len {handleLength.ParameterName} on method {nativeName}");

            var nameTable = overload.NameTable.New();
            nameTable.Rename(pointerParameter, $"{pointerParameter.Name}_handle");

            var refType = nativeName.StartsWith("Delete") ? CSRef.Type.In : CSRef.Type.Out;
            parameters[^1] = pointerParameter with
            {
                Type = new CSRef(refType, pointerParameterType.BaseType),
                Length = null
            };

            IOverloadLayer layer = refType == CSRef.Type.In ?
                 new DeleteOverloadLayer(overload.InputParameters[lengthParameterIndex], parameters[^1], pointerParameter) :
                 new GenAndCreateOverloadLayer(overload.InputParameters[lengthParameterIndex], parameters[^1], pointerParameter);

            newOverloads = new List<Overload>()
            {
                overload with
                {
                    InputParameters = parameters,
                    NestedOverload = overload,
                    OverloadName = newName,
                    NameTable = nameTable,
                    MarshalLayerToNested = layer
                },
                overload,
            };

            return true;
        }
    }

    internal sealed class StringOverloader : IOverloader
    {
        private sealed record StringLayer(Parameter PointerParameter, Parameter StringParameter) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable) => writer.WriteLine(
                $"byte* {nameTable[PointerParameter]} = (byte*)Marshal.StringToCoTaskMemUTF8({nameTable[StringParameter]});");

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine($"Marshal.FreeCoTaskMem((IntPtr){nameTable[PointerParameter]});");
                return returnName;
            }
        }

        private sealed record OutStringLayer(Parameter PointerParameter, Parameter StringLengthParameter, Parameter StringParameter) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable) => writer.WriteLine(
                $"var {nameTable[PointerParameter]} = (byte*)Marshal.AllocCoTaskMem({nameTable[StringLengthParameter]});");

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine($"{nameTable[StringParameter]} = Marshal.PtrToStringUTF8((IntPtr){nameTable[PointerParameter]})!;");
                writer.WriteLine($"Marshal.FreeCoTaskMem((IntPtr){nameTable[PointerParameter]});");
                return returnName;
            }
        }

        private static readonly ILogger log = LogManager.GetCurrentClassLogger();

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var newParams = new List<Parameter>(overload.InputParameters);
            var newOverload = overload;

            for (var i = newParams.Count - 1; i >= 0; i--)
            {
                // FIXME: We want to handle sized strings different!!!
                var param = newParams[i];
                if (param.Type is CSPointer pt && pt.BaseType is CSChar8 bt)
                {
                    var pointerParam = newParams[i];
                    var nameTable = newOverload.NameTable.New();
                    nameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");

                    if (bt.Constant)
                    {
                        // FIXME: Can we know if the string is nullable or not?
                        newParams[i] = newParams[i] with { Type = new CSString(Nullable: false), Length = null };
                        var stringParams = newParams.ToArray();
                        var stringLayer = new StringLayer(pointerParam, newParams[i]);

                        newOverload = newOverload with
                        {
                            NestedOverload = newOverload,
                            MarshalLayerToNested = stringLayer,
                            InputParameters = stringParams,
                            NameTable = nameTable
                        };
                    }
                    else
                    {
                        var stringParamIndex = i;
                        Parameter? lenParam = null;
                        if (param.Length != null)
                        {
                            var paramName = param.Length.InvertExpressionAndGetReferencedName(out var expr);
                            if (paramName == null)
                            {
                                log.Info($"{overload.NativeFunction.EntryPoint} has a COMPSIZE string length for parameter '{param.Name}'!");
                                continue;
                            }

                            var index = newParams.FindIndex(p => p.Name == paramName);
                            lenParam = newParams[index];
                        }

                        if (lenParam == null)
                        {
                            log.Info($"{overload.NativeFunction.EntryPoint} is missing a len attribute for parameter '{param.Name}'");
                            continue;
                        }

                        // FIXME: Can we know if the string is nullable or not?
                        var stringParam = newParams[stringParamIndex] with
                        {
                            Type = new CSRef(CSRef.Type.Out, new CSString(Nullable: false)),
                            Length = null
                        };

                        newParams[stringParamIndex] = stringParam;

                        var stringParams = newParams.ToArray();
                        var stringLayer = new OutStringLayer(pointerParam, lenParam, stringParam);

                        newOverload = newOverload with
                        {
                            NestedOverload = newOverload,
                            MarshalLayerToNested = stringLayer,
                            InputParameters = stringParams,
                            NameTable = nameTable
                        };
                    }
                }
            }

            if (newOverload == overload) // We didn't do any overloading
            {
                newOverloads = default;
                return false;
            }

            newOverloads = new List<Overload>() { newOverload };
            return true;
        }
    }

    internal sealed class SpanAndArrayOverloader : IOverloader
    {
        private sealed record SpanOrArrayLayer(
            Parameter PointerParameter, Parameter SpanOrArrayParameter, Parameter? LengthParameter,
            Func<string, string> ParameterExpression, BaseCSType BaseType) : IOverloadLayer
        {
            private CsScope scope;

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                // NOTE: We are casting the length field to the target type because some of
                // the functions don't take `int` types directly, instead they take an `IntPtr`.
                // But that is fine because we can cast `int`s to `IntPtr`.
                // This is slightly fragile but it's fine for now.
                // - Noggin_bops 2021-01-22
                if (LengthParameter != null)
                {
                    var byteSize = BaseType is CSGenericType ? $" * sizeof({BaseType.ToCSString()})" : "";
                    var lengthExpression = ParameterExpression(nameTable[SpanOrArrayParameter]);
                    writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = ({LengthParameter.Type.ToCSString()})({lengthExpression}{byteSize});");
                }

                writer.WriteLine($"fixed ({PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = {nameTable[SpanOrArrayParameter]})");
                scope = writer.CsScope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                scope.Dispose();
                return returnName;
            }
        }

        private static readonly ILogger log = LogManager.GetCurrentClassLogger();

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // FIXME: We want to be able to handle more than just one Span and Array overload
            // functions like "glShaderSource" can take more than one array.
            var newParams = new List<Parameter>(overload.InputParameters);
            var genericTypes = overload.GenericTypes;
            var arrayOverload = overload;
            var spanOverload = overload;

            for (var i = newParams.Count - 1; i >= 0; i--)
            {
                var param = newParams[i];

                if (param.Type is CSPointer ptr)
                {
                    if (ptr.BaseType is CSChar8)
                    {
                        log.Warn($"Char pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
                        continue;
                    }
                    else if (ptr.BaseType is CSPointer)
                    {
                        log.Warn($"Pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
                        continue;
                    }
                }

                if (param.Length != null)
                {
                    var lengthParamName = param.Length.InvertExpressionAndGetReferencedName(out var expr);
                    var pointerParam = newParams[i];
                    if (pointerParam.Type is not CSPointer pointer)
                        throw new Exception("A parameter with a 'len' attribute must be a pointer type!");

                    Parameter? oldLength = null;
                    Parameter? paramToBeRemoved = null;
                    var spanArrayParameterIndex = i;
                    var shouldCalculateLength = overload.InputParameters.Count(p => p.Length == param.Length) <= 1 && lengthParamName != null;
                    if (shouldCalculateLength)
                    {
                        // If this is the only len attribute that references this parameter,
                        // we can remove that parameter as we can calculate it from the length of this parameter (array/span).
                        // FIXME: This check is going to fail if the two 'len' attributes have different "forms" e.g. "n" == "n*4" == "COMPSIZE(n)" etc.
                        var lengthParamIndex = Array.FindIndex(overload.InputParameters, p => p.Name == lengthParamName);
                        oldLength = overload.InputParameters[lengthParamIndex];

                        paramToBeRemoved = oldLength;
                        _ = newParams.Remove(oldLength);

                        if (lengthParamIndex < i)
                        {
                            spanArrayParameterIndex--;
                            i--;
                        }
                    }

                    BaseCSType baseType;
                    if (pointer.BaseType is CSVoid)
                    {
                        genericTypes = genericTypes.MakeCopyAndGrow(1);
                        genericTypes[^1] = $"T{genericTypes.Length}";
                        baseType = new CSGenericType(genericTypes[^1]);
                    }
                    else baseType = pointer.BaseType;

                    var isBaseTypeConstant = false;
                    if (pointer.BaseType is IConstantCSType constantType)
                        isBaseTypeConstant = constantType.Constant;

                    var spanNameTable = overload.NameTable.New();
                    var arrayNameTable = overload.NameTable.New();

                    spanNameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");
                    arrayNameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");

                    var newSpanParams = spanOverload.InputParameters.Where(p => p != paramToBeRemoved).ToArray();
                    var newArrayParams = arrayOverload.InputParameters.Where(p => p != paramToBeRemoved).ToArray();

                    newSpanParams[spanArrayParameterIndex] = newSpanParams[spanArrayParameterIndex] with { Type = new CSSpan(baseType, isBaseTypeConstant) };
                    newArrayParams[spanArrayParameterIndex] = newArrayParams[spanArrayParameterIndex] with { Type = new CSArray(baseType) };

                    var spanLayer = new SpanOrArrayLayer(pointerParam, newSpanParams[spanArrayParameterIndex], oldLength, expr, baseType);
                    var arrayLayer = new SpanOrArrayLayer(pointerParam, newArrayParams[spanArrayParameterIndex], oldLength, expr, baseType);

                    spanOverload = spanOverload with
                    {
                        NestedOverload = spanOverload,
                        MarshalLayerToNested = spanLayer,
                        InputParameters = newSpanParams,
                        NameTable = spanNameTable,
                        GenericTypes = genericTypes
                    };

                    arrayOverload = arrayOverload with
                    {
                        NestedOverload = arrayOverload,
                        MarshalLayerToNested = arrayLayer,
                        InputParameters = newArrayParams,
                        NameTable = arrayNameTable,
                        GenericTypes = genericTypes
                    };
                }
            }

            if (arrayOverload == spanOverload)
            {
                newOverloads = default;
                return false;
            }

            newOverloads = new List<Overload>()
            {
                spanOverload,
                arrayOverload,
                overload,
            };

            return true;
        }
    }

    internal sealed class RefInsteadOfPointerOverloader : IOverloader
    {
        private record RefInsteadOfPointerLayer(List<Parameter> RefParameters, List<Parameter> PointerParameters) : IOverloadLayer
        {
            private CsScope scope;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                for (var i = 0; i < RefParameters.Count; i++)
                {
                    var type = PointerParameters[i].Type.ToCSString();
                    writer.WriteLine($"fixed ({type} {nameTable[PointerParameters[i]]} = &{nameTable[RefParameters[i]]})");
                }

                scope = writer.CsScope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                scope.Dispose();
                return returnName;
            }
        }

        private static readonly ILogger log = LogManager.GetCurrentClassLogger();

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var parameters = new Parameter[overload.InputParameters.Length];
            var original = new List<Parameter>();
            var changed = new List<Parameter>();
            var nameTable = overload.NameTable.New();
            var genericTypes = overload.GenericTypes;

            for (var i = 0; i < overload.InputParameters.Length; i++)
            {
                var parameter = overload.InputParameters[i];
                parameters[i] = parameter;

                if (parameter.Type is CSPointer pointer)
                {
                    var constant = pointer.Constant;
                    BaseCSType baseType;
                    switch (pointer.BaseType)
                    {
                        case CSVoid btVoid:
                            genericTypes = genericTypes.MakeCopyAndGrow(1);
                            genericTypes[^1] = $"T{genericTypes.Length}";
                            baseType = new CSGenericType(genericTypes[^1]);
                            constant |= btVoid.Constant;
                            break;
                        case CSPrimitive bt:
                            baseType = pointer.BaseType;
                            constant |= bt.Constant;
                            break;
                        case CSStruct bt:
                            baseType = pointer.BaseType;
                            constant |= bt.Constant;
                            break;
                        case CSBool8 bt:
                            baseType = pointer.BaseType;
                            constant |= bt.Constant;
                            break;
                        case CSPointer:
                            continue;
                        default:
                            log.Warn($"{pointer} is not supported by the ref overloader.");
                            continue;
                    }

                    // FIXME: When do we know it's an out ref type?
                    var refType = constant ? CSRef.Type.In : CSRef.Type.Ref;

                    // Rename the parameter
                    nameTable.Rename(parameter, $"{parameter.Name}_ptr");
                    original.Add(parameters[i]);

                    parameters[i] = parameters[i] with { Type = new CSRef(refType, baseType) };
                    changed.Add(parameters[i]);
                }
            }

            if (changed.Count == 0)
            {
                newOverloads = default;
                return false;
            }

            var layer = new RefInsteadOfPointerLayer(changed, original);
            newOverloads = new List<Overload>()
            {
                overload with { NestedOverload = overload, MarshalLayerToNested = layer, InputParameters = parameters, NameTable = nameTable, GenericTypes = genericTypes }
            };

            return true;
        }
    }

    internal sealed class OutToReturnOverloader : IOverloader
    {
        private record OutToReturnOverloadLayer(Parameter OutParameter, CSRef OutType) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable) => writer.WriteLine(
                $"{OutType.ReferencedType.ToCSString()} {nameTable[OutParameter]};");

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName) => OutParameter.Name;
        }

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var oldParameters = overload.InputParameters;
            if (overload.ReturnType is not CSVoid || oldParameters.Length == 0)
            {
                newOverloads = null;
                return false;
            }

            // Find the one and only out param, if there are more we do an early return.
            var newParameters = new Parameter[oldParameters.Length - 1];
            Parameter? outParameter = null;
            CSRef? outType = null;
            var destinationIndex = 0;
            for (var i = 0; i < oldParameters.Length; i++)
            {
                var parameter = oldParameters[i];
                if (parameter.Type is CSRef pRef && pRef.RefType == CSRef.Type.Out)
                {
                    if (outParameter != null)
                    {
                        newOverloads = null;
                        return false;
                    }

                    outType = pRef;
                    outParameter = parameter;
                }
                else if (destinationIndex != newParameters.Length)
                {
                    newParameters[destinationIndex] = parameter;
                    destinationIndex++;
                }
            }

            if (outType == null || outParameter == null)
            {
                newOverloads = null;
                return false;
            }

            newOverloads = new List<Overload>()
            {
                overload with
                {
                    NestedOverload = overload, InputParameters = newParameters,
                    ReturnType = outType!.ReferencedType,
                    MarshalLayerToNested = new OutToReturnOverloadLayer(outParameter, outType)
                },
                overload
            };

            return true;
        }
    }
}
