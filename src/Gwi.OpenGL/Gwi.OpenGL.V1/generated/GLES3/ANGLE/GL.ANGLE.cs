// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES3
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private ANGLEExtension? _ANGLE;
        public ANGLEExtension ANGLE => _ANGLE ??= new ANGLEExtension(this);

        public sealed unsafe partial class ANGLEExtension
        {
            private readonly VTable vtable;

            internal ANGLEExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void BlitFramebufferANGLE(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, int, int, int, ClearBufferMask, BlitFramebufferFilter, void>)vtable.glBlitFramebufferANGLE)(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
            public void RenderbufferStorageMultisampleANGLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<RenderbufferTarget, int, InternalFormat, int, int, void>)vtable.glRenderbufferStorageMultisampleANGLE)(target, samples, internalformat, width, height);
            public void DrawArraysInstancedANGLE(PrimitiveType mode, int first, int count, int primcount) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int, int, int, void>)vtable.glDrawArraysInstancedANGLE)(mode, first, count, primcount);
            public void DrawElementsInstancedANGLE(PrimitiveType mode, int count, PrimitiveType type, void* indices, int primcount) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int, PrimitiveType, void*, int, void>)vtable.glDrawElementsInstancedANGLE)(mode, count, type, indices, primcount);
            public void VertexAttribDivisorANGLE(uint index, uint divisor) => ((delegate* unmanaged[Cdecl]<uint, uint, void>)vtable.glVertexAttribDivisorANGLE)(index, divisor);
            public void GetTranslatedShaderSourceANGLE(ShaderHandle shader, int bufSize, int* length, byte* source) => ((delegate* unmanaged[Cdecl]<ShaderHandle, int, int*, byte*, void>)vtable.glGetTranslatedShaderSourceANGLE)(shader, bufSize, length, source);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
