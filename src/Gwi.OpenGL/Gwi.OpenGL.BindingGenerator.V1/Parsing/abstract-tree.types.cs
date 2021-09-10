using System;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    public abstract record BaseCSType()
    {
        // We use a custom ToString here to allow ToString to be used for debugging,
        // also this way we make sure you have to override the custom ToString method.
        public abstract string ToCSString();
    }

    public interface IConstantCSType
    {
        public bool Constant { get; }
    }

    public sealed record CSVoid(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => "void";
    }

    public sealed record CSPrimitive(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => TypeName;
    }

    public sealed record CSStruct(string TypeName, bool Constant, CSPrimitive? UnderlyingType) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => TypeName;
    }

    public sealed record CSBool8(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => "byte";
    }

    public sealed record CSChar8(bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => "byte";
    }

    public sealed record CSString(bool Nullable) : BaseCSType
    {
        public override string ToCSString() => $"string{(Nullable ? "?" : "")}";
    }

    public sealed record CSPointer(BaseCSType BaseType, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => $"{BaseType.ToCSString()}*";
    }

    public sealed record CSRef(CSRef.Type RefType, BaseCSType ReferencedType) : BaseCSType
    {
        public enum Type { Ref, Out, In }

        public string Modifier => RefType switch
        {
            Type.Ref => "ref",
            Type.Out => "out",
            Type.In => "in",
            _ => throw new NotSupportedException($"Reference Type {RefType} is invalid")
        };

        public override string ToCSString() => $"{Modifier} {ReferencedType.ToCSString()}";
    }

    public sealed record CSArray(BaseCSType BaseType) : BaseCSType
    {
        public override string ToCSString() => $"{BaseType.ToCSString()}[]";
    }

    public sealed record CSSpan(BaseCSType BaseType, bool Readonly) : BaseCSType
    {
        public override string ToCSString() => Readonly ? $"ReadOnlySpan<{BaseType.ToCSString()}>" : $"Span<{BaseType.ToCSString()}>";
    }

    public sealed record CSGenericType(string GenericTypeName) : BaseCSType
    {
        public override string ToCSString() => GenericTypeName;
    }

    public sealed record CSFunctionPointer(string TypeName, bool Constant) : BaseCSType, IConstantCSType
    {
        public override string ToCSString() => "IntPtr";
    }

    public sealed record CSDelegateType(string TypeName) : BaseCSType
    {
        public override string ToCSString() => TypeName;
    }
}
