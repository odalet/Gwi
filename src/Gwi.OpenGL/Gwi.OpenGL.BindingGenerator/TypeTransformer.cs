using System;

namespace Gwi.OpenGL.BindingGenerator
{
    internal abstract record CSharpType(GLType GLType)
    {
        public bool Constant => GLType.Constant;
        public abstract string Write();
        public abstract string WriteUnderlying();
    }

    internal sealed record CSharpPointer(GLType GLType, CSharpType BaseType) : CSharpType(GLType)
    {
        public override string Write() => $"{BaseType.Write()}*";
        public override string WriteUnderlying() => $"{BaseType.WriteUnderlying()}*";
    }

    internal sealed record CSharpVoid(GLType GLType) : CSharpType(GLType)
    {
        public override string Write() => "void";
        public override string WriteUnderlying() => "void";
    }

    internal record CSharpPrimitive(GLType GLType, string Name) : CSharpType(GLType)
    {
        public override string Write() => Name;
        public override string WriteUnderlying() => Name;
    }

    internal sealed record CSharpBool8(GLType GLType) : CSharpPrimitive(GLType, "byte");
    internal sealed record CSharpChar8(GLType GLType) : CSharpPrimitive(GLType, "byte");

    internal record CSharpStruct(GLType GLType, string Name, CSharpPrimitive UnderlyingType) : CSharpType(GLType)
    {
        public override string Write() => Name;
        public override string WriteUnderlying() => UnderlyingType.WriteUnderlying();
    }

    internal sealed record CSharpEnum(GLType GLType, string Name) : CSharpStruct(GLType, Name, new CSharpPrimitive(GLType, "uint"));

    internal sealed record CSharpFunctionPointer(GLType GLType, string Name) : CSharpStruct(GLType, Name, new CSharpPrimitive(GLType, "nint"));

    internal static class TypeTransformer
    {
        public static CSharpType ToCSharpType(this PType ptype) => MakeCSharpType(ptype.Type, ptype.Group, ptype.Class);

        private static CSharpType MakeCSharpType(GLType glType, string group, string className) => glType switch
        {
            GLPointerType pointerType => new CSharpPointer(pointerType, MakeCSharpType(pointerType.BaseType, group, className)),
            GLBaseType baseType => MakeCSharpType(baseType, group, className),
            _ => throw new NotSupportedException($"GL Type {glType} is invalid"),
        };

        private static CSharpType MakeCSharpType(GLBaseType glType, string group, string className) => glType.Type switch
        {
            // C# primitive types
            GLPrimitiveType.Void => new CSharpVoid(glType),
            GLPrimitiveType.Byte => new CSharpPrimitive(glType, "byte"),
            GLPrimitiveType.Sbyte => new CSharpPrimitive(glType, "sbyte"),
            GLPrimitiveType.Short => new CSharpPrimitive(glType, "short"),
            GLPrimitiveType.Ushort => new CSharpPrimitive(glType, "ushort"),
            GLPrimitiveType.Int => new CSharpPrimitive(glType, "int"),
            GLPrimitiveType.Uint => new CSharpPrimitive(glType, "uint"),
            GLPrimitiveType.Long => new CSharpPrimitive(glType, "long"),
            GLPrimitiveType.Ulong => new CSharpPrimitive(glType, "ulong"),
            GLPrimitiveType.Half => new CSharpPrimitive(glType, "Half"), // This is System.Half since .NET 5, but does not have yet a keyword (such as float or double)
            GLPrimitiveType.Float => new CSharpPrimitive(glType, "float"),
            GLPrimitiveType.Double => new CSharpPrimitive(glType, "double"),

            // C interop types
            GLPrimitiveType.Bool8 => new CSharpBool8(glType),
            GLPrimitiveType.Char8 => new CSharpChar8(glType),

            // Enum
            GLPrimitiveType.Enum => new CSharpEnum(glType, group),

            // Pointers
            GLPrimitiveType.IntPtr => new CSharpPrimitive(glType, "nint"),
            GLPrimitiveType.Nint => new CSharpPrimitive(glType, "nint"),
            GLPrimitiveType.VoidPtr => MakeVoidPtrCSharpType(glType),

            // FIXME: Output the GLHandleARB again...
            GLPrimitiveType.GLHandleARB => new CSharpStruct(glType, "GLHandleARB", new CSharpPrimitive(glType, "nint")),
            GLPrimitiveType.GLSync => new CSharpStruct(glType, "GLSync", new CSharpPrimitive(glType, "nint")),

            // OpenCL structs
            GLPrimitiveType.CLContext => new CSharpStruct(glType, "CLContext", new CSharpPrimitive(glType, "nint")),
            GLPrimitiveType.CLEvent => new CSharpStruct(glType, "CLEvent", new CSharpPrimitive(glType, "nint")),

            // Function pointer types
            GLPrimitiveType.GLDebugProc => new CSharpFunctionPointer(glType, "GLDebugProc"),
            GLPrimitiveType.GLDebugProcARB => new CSharpFunctionPointer(glType, "GLDebugProcARB"),
            GLPrimitiveType.GLDebugProcKHR => new CSharpFunctionPointer(glType, "GLDebugProcKHR"),
            GLPrimitiveType.GLDebugProcAMD => new CSharpFunctionPointer(glType, "GLDebugProcAMD"),
            GLPrimitiveType.GLDebugProcNV => new CSharpFunctionPointer(glType, "GLDebugProcNV"),
            GLPrimitiveType.GLVulkanProcNV => new CSharpFunctionPointer(glType, "GLVulkanProcNV"),

            GLPrimitiveType.Invalid => throw new Exception(),
            _ => throw new NotSupportedException($"Primitive Type {glType.Type} is invalid"),
        };

        private static CSharpType MakeVoidPtrCSharpType(GLType glType)
        {
            // Special logic for VoidPtr: we want to make a void* that is not constant
            var voidType = new GLBaseType(glType.Declaration, GLPrimitiveType.Void, false);
            return new CSharpPointer(glType, new CSharpVoid(voidType)); // VoidPtr are never constant?
        }
    }
}
