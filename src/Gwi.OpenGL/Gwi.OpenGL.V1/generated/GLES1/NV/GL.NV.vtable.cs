// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLES1
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class NVExtension
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glDeleteFencesNV => _glDeleteFencesNV != 0 ? _glDeleteFencesNV : _glDeleteFencesNV = Lib.GetProcAddress("glDeleteFencesNV");
                private nint _glDeleteFencesNV;

                public nint glGenFencesNV => _glGenFencesNV != 0 ? _glGenFencesNV : _glGenFencesNV = Lib.GetProcAddress("glGenFencesNV");
                private nint _glGenFencesNV;

                public nint glIsFenceNV => _glIsFenceNV != 0 ? _glIsFenceNV : _glIsFenceNV = Lib.GetProcAddress("glIsFenceNV");
                private nint _glIsFenceNV;

                public nint glTestFenceNV => _glTestFenceNV != 0 ? _glTestFenceNV : _glTestFenceNV = Lib.GetProcAddress("glTestFenceNV");
                private nint _glTestFenceNV;

                public nint glGetFenceivNV => _glGetFenceivNV != 0 ? _glGetFenceivNV : _glGetFenceivNV = Lib.GetProcAddress("glGetFenceivNV");
                private nint _glGetFenceivNV;

                public nint glFinishFenceNV => _glFinishFenceNV != 0 ? _glFinishFenceNV : _glFinishFenceNV = Lib.GetProcAddress("glFinishFenceNV");
                private nint _glFinishFenceNV;

                public nint glSetFenceNV => _glSetFenceNV != 0 ? _glSetFenceNV : _glSetFenceNV = Lib.GetProcAddress("glSetFenceNV");
                private nint _glSetFenceNV;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
