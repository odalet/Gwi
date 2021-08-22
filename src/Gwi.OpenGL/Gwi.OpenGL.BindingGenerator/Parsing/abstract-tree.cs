using System;
using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    public sealed record Specification(IEnumerable<OutputApiSpecification> Apis);

    public sealed record OutputApiSpecification(
        OutputApi Api,
        IReadOnlyDictionary<string, GLVendorFunctions> Vendors,
        IReadOnlyCollection<EnumGroupMember> EnumGroupMembers,
        IReadOnlyCollection<EnumGroup> EnumGroups);

    public sealed record GLVendorFunctions(
        IReadOnlyCollection<NativeFunction> NativeFunctions,
        IReadOnlyCollection<Overload[]> OverloadsGroupedByNativeFunctions,
        HashSet<NativeFunction> NativeFunctionsWithPostfix);

    public sealed record NativeFunction(
        string EntryPoint,
        string Name,
        IReadOnlyList<Parameter> Parameters,
        BaseCSType ReturnType,
        string[] ReferencedEnumGroups);

    public sealed record Parameter(BaseCSType Type, string Name, Expr? Length);

    public sealed record Overload(
        Overload? NestedOverload,
        IOverloadLayer? MarshalLayerToNested,
        Parameter[] InputParameters,
        NativeFunction NativeFunction,
        BaseCSType ReturnType,
        NameTable NameTable,
        string ReturnVariableName,
        string[] GenericTypes,
        string OverloadName);

    public enum OutputApi
    {
        Invalid,
        GL,
        GLCompat,
        GLES1,
        GLES3
    }

    public sealed record EnumGroup(string Name, bool IsFlags, List<EnumGroupMember> Members);
    public sealed record EnumGroupMember(string Name, ulong Value, string[] Groups, bool IsFlag) : IEquatable<EnumGroupMember?>;
}
