// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES1
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private EXTExtension? _EXT;
        public EXTExtension EXT => _EXT ??= new EXTExtension(this);

        public sealed unsafe partial class EXTExtension
        {
            private readonly VTable vtable;

            internal EXTExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void BlendEquationEXT(BlendEquationModeEXT mode) => ((delegate* unmanaged[Cdecl]<BlendEquationModeEXT, void>)vtable.glBlendEquationEXT)(mode);
            public void InsertEventMarkerEXT(int length, byte* marker) => ((delegate* unmanaged[Cdecl]<int, byte*, void>)vtable.glInsertEventMarkerEXT)(length, marker);
            public void PushGroupMarkerEXT(int length, byte* marker) => ((delegate* unmanaged[Cdecl]<int, byte*, void>)vtable.glPushGroupMarkerEXT)(length, marker);
            public void PopGroupMarkerEXT() => ((delegate* unmanaged[Cdecl]<void>)vtable.glPopGroupMarkerEXT)();
            public void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, int, InvalidateFramebufferAttachment*, void>)vtable.glDiscardFramebufferEXT)(target, numAttachments, attachments);
            public void* MapBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => ((delegate* unmanaged[Cdecl]<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*>)vtable.glMapBufferRangeEXT)(target, offset, length, access);
            public void FlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length) => ((delegate* unmanaged[Cdecl]<BufferTargetARB, IntPtr, nint, void>)vtable.glFlushMappedBufferRangeEXT)(target, offset, length);
            public void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int*, int*, int, void>)vtable.glMultiDrawArraysEXT)(mode, first, count, primcount);
            public void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int*, DrawElementsType, void**, int, void>)vtable.glMultiDrawElementsEXT)(mode, count, type, indices, primcount);
            public void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<RenderbufferTarget, int, InternalFormat, int, int, void>)vtable.glRenderbufferStorageMultisampleEXT)(target, samples, internalformat, width, height);
            public void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)vtable.glFramebufferTexture2DMultisampleEXT)(target, attachment, textarget, texture, level, samples);
            public GraphicsResetStatus GetGraphicsResetStatusEXT() => ((delegate* unmanaged[Cdecl]<GraphicsResetStatus>)vtable.glGetGraphicsResetStatusEXT)();
            public void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => ((delegate* unmanaged[Cdecl]<int, int, int, int, PixelFormat, PixelType, int, void*, void>)vtable.glReadnPixelsEXT)(x, y, width, height, format, type, bufSize, data);
            public void GetnUniformfvEXT(ProgramHandle program, int location, int bufSize, float* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, float*, void>)vtable.glGetnUniformfvEXT)(program, location, bufSize, parameters);
            public void GetnUniformivEXT(ProgramHandle program, int location, int bufSize, int* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, int*, void>)vtable.glGetnUniformivEXT)(program, location, bufSize, parameters);
            public void TexStorage1DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, SizedInternalFormat, int, void>)vtable.glTexStorage1DEXT)(target, levels, internalformat, width);
            public void TexStorage2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, SizedInternalFormat, int, int, void>)vtable.glTexStorage2DEXT)(target, levels, internalformat, width, height);
            public void TexStorage3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, SizedInternalFormat, int, int, int, void>)vtable.glTexStorage3DEXT)(target, levels, internalformat, width, height, depth);
            public void TextureStorage1DEXT(TextureHandle texture, GLEnum target, int levels, SizedInternalFormat internalformat, int width) => ((delegate* unmanaged[Cdecl]<TextureHandle, GLEnum, int, SizedInternalFormat, int, void>)vtable.glTextureStorage1DEXT)(texture, target, levels, internalformat, width);
            public void TextureStorage2DEXT(TextureHandle texture, GLEnum target, int levels, SizedInternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<TextureHandle, GLEnum, int, SizedInternalFormat, int, int, void>)vtable.glTextureStorage2DEXT)(texture, target, levels, internalformat, width, height);
            public void TextureStorage3DEXT(TextureHandle texture, GLEnum target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => ((delegate* unmanaged[Cdecl]<TextureHandle, GLEnum, int, SizedInternalFormat, int, int, int, void>)vtable.glTextureStorage3DEXT)(texture, target, levels, internalformat, width, height, depth);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
