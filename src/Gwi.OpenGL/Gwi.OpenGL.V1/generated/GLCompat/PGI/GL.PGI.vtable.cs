// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class PGIExtension
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glHintPGI => _glHintPGI != 0 ? _glHintPGI : _glHintPGI = Lib.GetProcAddress("glHintPGI");
                private nint _glHintPGI;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
