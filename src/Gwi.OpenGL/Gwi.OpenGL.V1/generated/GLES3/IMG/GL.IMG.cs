// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES3
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private IMGExtension? _IMG;
        public IMGExtension IMG => _IMG ??= new IMGExtension(this);

        public sealed unsafe partial class IMGExtension
        {
            private readonly VTable vtable;

            internal IMGExtension(GL gl) => vtable = new VTable(gl.Lib);

            public ulong GetTextureHandleIMG(TextureHandle texture) => ((delegate* unmanaged[Cdecl]<TextureHandle, ulong>)vtable.glGetTextureHandleIMG)(texture);
            public ulong GetTextureSamplerHandleIMG(TextureHandle texture, SamplerHandle sampler) => ((delegate* unmanaged[Cdecl]<TextureHandle, SamplerHandle, ulong>)vtable.glGetTextureSamplerHandleIMG)(texture, sampler);
            public void UniformHandleui64IMG(int location, ulong value) => ((delegate* unmanaged[Cdecl]<int, ulong, void>)vtable.glUniformHandleui64IMG)(location, value);
            public void UniformHandleui64vIMG(int location, int count, ulong* value) => ((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)vtable.glUniformHandleui64vIMG)(location, count, value);
            public void ProgramUniformHandleui64IMG(ProgramHandle program, int location, ulong value) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, ulong, void>)vtable.glProgramUniformHandleui64IMG)(program, location, value);
            public void ProgramUniformHandleui64vIMG(ProgramHandle program, int location, int count, ulong* values) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, ulong*, void>)vtable.glProgramUniformHandleui64vIMG)(program, location, count, values);
            public void FramebufferTexture2DDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int xscale, int yscale) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, int, void>)vtable.glFramebufferTexture2DDownsampleIMG)(target, attachment, textarget, texture, level, xscale, yscale);
            public void FramebufferTextureLayerDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int layer, int xscale, int yscale) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, int, int, void>)vtable.glFramebufferTextureLayerDownsampleIMG)(target, attachment, texture, level, layer, xscale, yscale);
            public void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<RenderbufferTarget, int, InternalFormat, int, int, void>)vtable.glRenderbufferStorageMultisampleIMG)(target, samples, internalformat, width, height);
            public void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)vtable.glFramebufferTexture2DMultisampleIMG)(target, attachment, textarget, texture, level, samples);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
