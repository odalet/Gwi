namespace Gwi.OpenGL.BindingGenerator
{
    internal abstract record GLType(string Declaration, bool Constant);
    internal sealed record GLPointerType(string Declaration, GLType BaseType, bool Constant) : GLType(Declaration, Constant);
    internal sealed record GLBaseType(string Declaration, GLPrimitiveType Type, bool Constant) : GLType(Declaration, Constant);

    internal enum GLPrimitiveType
    {
        Invalid,
        Void,
        Byte,
        Sbyte,
        Short,
        Ushort,
        Int,
        Uint,
        Long,
        Ulong,
        Half,
        Float,
        Double,
        IntPtr,
        Nint,
        Enum,
        Bool8,
        Char8,
        VoidPtr,
        GLHandleARB,
        GLSync,
        CLContext,
        CLEvent,
        GLDebugProc,
        GLDebugProcARB,
        GLDebugProcKHR,
        GLDebugProcAMD,
        GLDebugProcNV,
        GLVulkanProcNV
    }

    internal static class PTypeParser
    {        
        public static GLType Parse(string declaration) => declaration.EndsWith('*') ? ParsePointer(declaration) : ParseType(declaration);

        private static GLType ParsePointer(string declaration)
        {
            var type = declaration[0..^1].TrimEnd(); // Remove trailing *

            // A pointer is only const if const is directly in front of the pointer,
            // if the const is in front of the type the type is the constant and not the pointer.
            var isConstPointer = false;
            if (type.EndsWith("const"))
            {
                isConstPointer = true;
                type = type[0..^"const".Length].TrimEnd();
            }

            var baseType = Parse(type);
            return new GLPointerType(declaration, baseType, isConstPointer);
        }

        private static GLType ParseType(string declaration)
        {
            var type = declaration;

            var isConst = false;
            if (type.StartsWith("const"))
            {
                isConst = true;
                type = type["const".Length..].TrimStart();
            }

            // This is needed for _cl_context, and _cl_event
            // We don't care about struct here because it doesn't add any information (we are not a c compiler).
            if (type.StartsWith("struct"))
                type = type["struct".Length..].TrimStart();

            // See https://www.khronos.org/opengl/wiki/OpenGL_Type
            var primitiveType = type switch
            {
                // Should a pointer to void be a voidptr primitive type?
                "void" => GLPrimitiveType.Void,
                "GLenum" => GLPrimitiveType.Enum,
                "GLboolean" => GLPrimitiveType.Bool8,
                "GLbitfield" => GLPrimitiveType.Enum,
                "GLvoid" => GLPrimitiveType.Void, // Does not seem to be used
                "GLbyte" => GLPrimitiveType.Sbyte,
                "GLubyte" => GLPrimitiveType.Byte,
                "GLshort" => GLPrimitiveType.Short,
                "GLushort" => GLPrimitiveType.Ushort,
                "GLint" => GLPrimitiveType.Int,
                "GLuint" => GLPrimitiveType.Uint,
                "GLclampx" => GLPrimitiveType.Int,
                "GLsizei" => GLPrimitiveType.Int,
                "GLfloat" => GLPrimitiveType.Float,
                "GLclampf" => GLPrimitiveType.Float,
                "GLdouble" => GLPrimitiveType.Double,
                "GLclampd" => GLPrimitiveType.Double,
                "GLeglClientBufferEXT" => GLPrimitiveType.VoidPtr,
                "GLeglImageOES" => GLPrimitiveType.VoidPtr,
                "GLchar" => GLPrimitiveType.Char8,
                "GLcharARB" => GLPrimitiveType.Char8,
                "GLhalf" => GLPrimitiveType.Half, // Does not seem to be used
                "GLhalfARB" => GLPrimitiveType.Half, // Does not seem to be used
                "GLfixed" => GLPrimitiveType.Int,
                "GLintptr" => GLPrimitiveType.IntPtr,
                "GLintptrARB" => GLPrimitiveType.IntPtr,
                "GLsizeiptr" => GLPrimitiveType.Nint, // Should this not be an UIntPtr?
                "GLsizeiptrARB" => GLPrimitiveType.Nint,
                "GLint64" => GLPrimitiveType.Long,
                "GLint64EXT" => GLPrimitiveType.Long,
                "GLuint64" => GLPrimitiveType.Ulong,
                "GLuint64EXT" => GLPrimitiveType.Ulong,
                "GLhalfNV" => GLPrimitiveType.Half,
                "GLvdpauSurfaceNV" => GLPrimitiveType.IntPtr,                
                "GLhandleARB" => GLPrimitiveType.GLHandleARB, // This type is platform specific on apple.
                // The following types have a custom C# implementation in the code generator.
                "GLsync" => GLPrimitiveType.GLSync,
                "_cl_context" => GLPrimitiveType.CLContext,
                "_cl_event" => GLPrimitiveType.CLEvent,
                "GLDEBUGPROC" => GLPrimitiveType.GLDebugProc,
                "GLDEBUGPROCARB" => GLPrimitiveType.GLDebugProcARB,
                "GLDEBUGPROCKHR" => GLPrimitiveType.GLDebugProcKHR,
                "GLDEBUGPROCAMD" => GLPrimitiveType.GLDebugProcAMD,
                "GLDEBUGPROCNV" => GLPrimitiveType.GLDebugProcNV,
                // This isn't actually used in the output bindings.
                // But we leave it here as a primitive type so we have the information if we need it later.
                "GLVULKANPROCNV" => GLPrimitiveType.GLVulkanProcNV,
                _ => GLPrimitiveType.Invalid
            };

            return primitiveType == GLPrimitiveType.Invalid ?
                throw new ParsingException($"Type conversion failed for type {type}") :
                new GLBaseType(type, primitiveType, isConst);
        }
    }
}
