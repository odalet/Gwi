using System;

namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    internal static class TypeTransformer
    {
        public static BaseCSType MakeCSType(GLType type, HandleType? handle, string? group) => type switch
        {
            GLPointerType pointerType => new CSPointer(MakeCSType(pointerType.BaseType, handle, group), pointerType.Constant),
            GLBaseType baseType when handle != null => new CSStruct(handle.Value.ToString(), baseType.Constant, new CSPrimitive("int", baseType.Constant)),
            GLBaseType baseType when handle == null => baseType.Type switch
            {
                // C# primitive types
                PrimitiveType.Void => new CSVoid(baseType.Constant),
                PrimitiveType.Byte => new CSPrimitive("byte", baseType.Constant),
                PrimitiveType.Sbyte => new CSPrimitive("sbyte", baseType.Constant),
                PrimitiveType.Short => new CSPrimitive("short", baseType.Constant),
                PrimitiveType.Ushort => new CSPrimitive("ushort", baseType.Constant),
                PrimitiveType.Int => new CSPrimitive("int", baseType.Constant),
                PrimitiveType.Uint => new CSPrimitive("uint", baseType.Constant),
                PrimitiveType.Long => new CSPrimitive("long", baseType.Constant),
                PrimitiveType.Ulong => new CSPrimitive("ulong", baseType.Constant),
                // This might need an include, but the spec doesn't use this type
                // so we don't really need to do anything...
                PrimitiveType.Half => new CSStruct("Half", baseType.Constant, new CSPrimitive("ushort", baseType.Constant)),
                PrimitiveType.Float => new CSPrimitive("float", baseType.Constant),
                PrimitiveType.Double => new CSPrimitive("double", baseType.Constant),

                // C interop types
                PrimitiveType.Bool8 => new CSBool8(baseType.Constant),
                PrimitiveType.Char8 => new CSChar8(baseType.Constant),

                // Enum
                PrimitiveType.Enum => new CSPrimitive(group ?? Constants.GLEnumName, baseType.Constant),

                // Pointers
                PrimitiveType.IntPtr => new CSPrimitive("IntPtr", baseType.Constant),
                PrimitiveType.Nint => new CSPrimitive("nint", baseType.Constant),
                PrimitiveType.VoidPtr => new CSPointer(new CSVoid(false), baseType.Constant),

                // FIXME: Output the GLHandleARB again...
                PrimitiveType.GLHandleARB => new CSStruct("GLHandleARB", baseType.Constant, new CSPrimitive("IntPtr", baseType.Constant)),
                PrimitiveType.GLSync => new CSStruct("GLSync", baseType.Constant, new CSPrimitive("IntPtr", baseType.Constant)),

                // OpenCL structs
                PrimitiveType.CLContext => new CSStruct("CLContext", baseType.Constant, new CSPrimitive("IntPtr", baseType.Constant)),
                PrimitiveType.CLEvent => new CSStruct("CLEvent", baseType.Constant, new CSPrimitive("IntPtr", baseType.Constant)),

                // Function pointer types
                PrimitiveType.GLDebugProc => new CSFunctionPointer("GLDebugProc", baseType.Constant),
                PrimitiveType.GLDebugProcARB => new CSFunctionPointer("GLDebugProcARB", baseType.Constant),
                PrimitiveType.GLDebugProcKHR => new CSFunctionPointer("GLDebugProcKHR", baseType.Constant),
                PrimitiveType.GLDebugProcAMD => new CSFunctionPointer("GLDebugProcAMD", baseType.Constant),
                PrimitiveType.GLDebugProcNV => new CSFunctionPointer("GLDebugProcNV", baseType.Constant),
                PrimitiveType.GLVulkanProcNV => new CSFunctionPointer("GLVulkanProcNV", baseType.Constant),

                PrimitiveType.Invalid => throw new Exception(),
                _ => throw new NotSupportedException($"Primitive Type {baseType.Type} is invalid"),
            },
            _ => throw new NotSupportedException($"GL Type {type} is invalid"),
        };
    }
}
