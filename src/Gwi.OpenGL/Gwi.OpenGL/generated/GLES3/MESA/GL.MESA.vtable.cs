// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLES3
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class MESAExtension
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glFramebufferParameteriMESA => _glFramebufferParameteriMESA != 0 ? _glFramebufferParameteriMESA : _glFramebufferParameteriMESA = Lib.GetProcAddress("glFramebufferParameteriMESA");
                private nint _glFramebufferParameteriMESA;

                public nint glGetFramebufferParameterivMESA => _glGetFramebufferParameterivMESA != 0 ? _glGetFramebufferParameterivMESA : _glGetFramebufferParameterivMESA = Lib.GetProcAddress("glGetFramebufferParameterivMESA");
                private nint _glGetFramebufferParameterivMESA;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
