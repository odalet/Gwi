// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class _3DFXExtension
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glTbufferMask3DFX => _glTbufferMask3DFX != 0 ? _glTbufferMask3DFX : _glTbufferMask3DFX = Lib.GetProcAddress("glTbufferMask3DFX");
                private nint _glTbufferMask3DFX;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
