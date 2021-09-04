// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES1
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

            public void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<RenderbufferTarget, int, InternalFormat, int, int, void>)vtable.glRenderbufferStorageMultisampleIMG)(target, samples, internalformat, width, height);
            public void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)vtable.glFramebufferTexture2DMultisampleIMG)(target, attachment, textarget, texture, level, samples);
            public void ClipPlanefIMG(ClipPlaneName p, float* eqn) => ((delegate* unmanaged[Cdecl]<ClipPlaneName, float*, void>)vtable.glClipPlanefIMG)(p, eqn);
            public void ClipPlanexIMG(ClipPlaneName p, int* eqn) => ((delegate* unmanaged[Cdecl]<ClipPlaneName, int*, void>)vtable.glClipPlanexIMG)(p, eqn);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
