// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES3
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private OVRExtension? _OVR;
        public OVRExtension OVR => _OVR ??= new OVRExtension(this);

        public sealed unsafe partial class OVRExtension
        {
            private readonly VTable vtable;

            internal OVRExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void FramebufferTextureMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int baseViewIndex, int numViews) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, int, void>)vtable.glFramebufferTextureMultiviewOVR)(target, attachment, texture, level, baseViewIndex, numViews);
            public void FramebufferTextureMultisampleMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level, int samples, int baseViewIndex, int numViews) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureHandle, int, int, int, int, void>)vtable.glFramebufferTextureMultisampleMultiviewOVR)(target, attachment, texture, level, samples, baseViewIndex, numViews);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
