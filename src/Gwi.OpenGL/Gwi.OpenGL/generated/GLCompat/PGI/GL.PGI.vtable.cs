// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable S1144 // Unused private types or members should be removed
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class PGI
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
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
#pragma warning restore S1144 // Unused private types or members should be removed
}
