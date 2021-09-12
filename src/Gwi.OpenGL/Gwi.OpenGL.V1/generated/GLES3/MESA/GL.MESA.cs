// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES3
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private MESAExtension? _MESA;
        public MESAExtension MESA => _MESA ??= new MESAExtension(this);

        public sealed unsafe partial class MESAExtension
        {
            private readonly VTable vtable;

            internal MESAExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void FramebufferParameteriMESA(FramebufferTarget target, FramebufferParameterName pname, int param) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameterName, int, void>)vtable.glFramebufferParameteriMESA)(target, pname, param);
            public void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, int*, void>)vtable.glGetFramebufferParameterivMESA)(target, pname, parameters);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
