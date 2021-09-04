// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable S1144 // Unused private types or members should be removed
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class SGI
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glColorTableSGI => _glColorTableSGI != 0 ? _glColorTableSGI : _glColorTableSGI = Lib.GetProcAddress("glColorTableSGI");
                private nint _glColorTableSGI;

                public nint glColorTableParameterfvSGI => _glColorTableParameterfvSGI != 0 ? _glColorTableParameterfvSGI : _glColorTableParameterfvSGI = Lib.GetProcAddress("glColorTableParameterfvSGI");
                private nint _glColorTableParameterfvSGI;

                public nint glColorTableParameterivSGI => _glColorTableParameterivSGI != 0 ? _glColorTableParameterivSGI : _glColorTableParameterivSGI = Lib.GetProcAddress("glColorTableParameterivSGI");
                private nint _glColorTableParameterivSGI;

                public nint glCopyColorTableSGI => _glCopyColorTableSGI != 0 ? _glCopyColorTableSGI : _glCopyColorTableSGI = Lib.GetProcAddress("glCopyColorTableSGI");
                private nint _glCopyColorTableSGI;

                public nint glGetColorTableSGI => _glGetColorTableSGI != 0 ? _glGetColorTableSGI : _glGetColorTableSGI = Lib.GetProcAddress("glGetColorTableSGI");
                private nint _glGetColorTableSGI;

                public nint glGetColorTableParameterfvSGI => _glGetColorTableParameterfvSGI != 0 ? _glGetColorTableParameterfvSGI : _glGetColorTableParameterfvSGI = Lib.GetProcAddress("glGetColorTableParameterfvSGI");
                private nint _glGetColorTableParameterfvSGI;

                public nint glGetColorTableParameterivSGI => _glGetColorTableParameterivSGI != 0 ? _glGetColorTableParameterivSGI : _glGetColorTableParameterivSGI = Lib.GetProcAddress("glGetColorTableParameterivSGI");
                private nint _glGetColorTableParameterivSGI;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
#pragma warning restore S1144 // Unused private types or members should be removed
}
