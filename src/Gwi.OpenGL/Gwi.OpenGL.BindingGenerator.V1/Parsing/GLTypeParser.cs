namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    internal static class GLTypeParser
    {
        public static GLType Parse(string type)
        {
            type = type.Trim();
            return type.EndsWith('*') ? ParsePointerType(type) : ParseTypeCore(type);
        }

        private static GLType ParsePointerType(string type)
        {
            // This removes the last character of the string
            var withoutAsterisk = type[0..^1].TrimEnd();

            // A pointer is only const if const is directly in front of the pointer,
            // if the const is in front of the type the type is the constant and not the pointer.
            var isConstPointer = false;
            if (withoutAsterisk.EndsWith("const"))
            {
                isConstPointer = true;
                withoutAsterisk = withoutAsterisk[0..^"const".Length];
            }

            var baseType = Parse(withoutAsterisk);
            return new GLPointerType(baseType, isConstPointer);
        }

        private static GLType ParseTypeCore(string type)
        {
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

            var primitiveType = type switch
            {
                "void" => PrimitiveType.Void,
                "GLenum" => PrimitiveType.Enum,
                "GLboolean" => PrimitiveType.Bool8,
                "GLbitfield" => PrimitiveType.Enum,
                "GLvoid" => PrimitiveType.Void,
                "GLbyte" => PrimitiveType.Sbyte,
                "GLubyte" => PrimitiveType.Byte,
                "GLshort" => PrimitiveType.Short,
                "GLushort" => PrimitiveType.Ushort,
                "GLint" => PrimitiveType.Int,
                "GLuint" => PrimitiveType.Uint,
                "GLclampx" => PrimitiveType.Int,
                "GLsizei" => PrimitiveType.Int,
                "GLfloat" => PrimitiveType.Float,
                "GLclampf" => PrimitiveType.Float,
                "GLdouble" => PrimitiveType.Double,
                "GLclampd" => PrimitiveType.Double,
                "GLeglClientBufferEXT" => PrimitiveType.VoidPtr,
                "GLeglImageOES" => PrimitiveType.VoidPtr,
                "GLchar" => PrimitiveType.Char8,
                "GLcharARB" => PrimitiveType.Char8,
                "GLhalf" => PrimitiveType.Half,
                "GLhalfARB" => PrimitiveType.Half,
                "GLfixed" => PrimitiveType.Int,
                "GLintptr" => PrimitiveType.IntPtr,
                "GLintptrARB" => PrimitiveType.IntPtr,
                "GLsizeiptr" => PrimitiveType.Nint,
                "GLsizeiptrARB" => PrimitiveType.Nint,
                "GLint64" => PrimitiveType.Long,
                "GLint64EXT" => PrimitiveType.Long,
                "GLuint64" => PrimitiveType.Ulong,
                "GLuint64EXT" => PrimitiveType.Ulong,
                "GLhalfNV" => PrimitiveType.Half,
                "GLvdpauSurfaceNV" => PrimitiveType.IntPtr,
                // This type is platform specific on apple.
                "GLhandleARB" => PrimitiveType.GLHandleARB,
                // The following have a custom c# implementation in the writer.
                "GLsync" => PrimitiveType.GLSync,
                "_cl_context" => PrimitiveType.CLContext,
                "_cl_event" => PrimitiveType.CLEvent,
                "GLDEBUGPROC" => PrimitiveType.GLDebugProc,
                "GLDEBUGPROCARB" => PrimitiveType.GLDebugProcARB,
                "GLDEBUGPROCKHR" => PrimitiveType.GLDebugProcKHR,
                "GLDEBUGPROCAMD" => PrimitiveType.GLDebugProcAMD,
                "GLDEBUGPROCNV" => PrimitiveType.GLDebugProcNV,
                // This isn't actually used in the output bindings.
                // But we leave it here as a primitive type so we have the information if we need it later.
                "GLVULKANPROCNV" => PrimitiveType.GLVulkanProcNV,
                _ => PrimitiveType.Invalid
            };

            return primitiveType == PrimitiveType.Invalid ?
                throw new ParsingException($"Type conversion failed for type {type}") :
                new GLBaseType(type, primitiveType, isConst);
        }
    }
}
