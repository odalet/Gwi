// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GL4
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class SUNXExtension
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glFinishTextureSUNX => _glFinishTextureSUNX != 0 ? _glFinishTextureSUNX : _glFinishTextureSUNX = Lib.GetProcAddress("glFinishTextureSUNX");
                private nint _glFinishTextureSUNX;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
