// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLES1
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class IMGExtension
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glRenderbufferStorageMultisampleIMG => _glRenderbufferStorageMultisampleIMG != 0 ? _glRenderbufferStorageMultisampleIMG : _glRenderbufferStorageMultisampleIMG = Lib.GetProcAddress("glRenderbufferStorageMultisampleIMG");
                private nint _glRenderbufferStorageMultisampleIMG;

                public nint glFramebufferTexture2DMultisampleIMG => _glFramebufferTexture2DMultisampleIMG != 0 ? _glFramebufferTexture2DMultisampleIMG : _glFramebufferTexture2DMultisampleIMG = Lib.GetProcAddress("glFramebufferTexture2DMultisampleIMG");
                private nint _glFramebufferTexture2DMultisampleIMG;

                public nint glClipPlanefIMG => _glClipPlanefIMG != 0 ? _glClipPlanefIMG : _glClipPlanefIMG = Lib.GetProcAddress("glClipPlanefIMG");
                private nint _glClipPlanefIMG;

                public nint glClipPlanexIMG => _glClipPlanexIMG != 0 ? _glClipPlanexIMG : _glClipPlanexIMG = Lib.GetProcAddress("glClipPlanexIMG");
                private nint _glClipPlanexIMG;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
