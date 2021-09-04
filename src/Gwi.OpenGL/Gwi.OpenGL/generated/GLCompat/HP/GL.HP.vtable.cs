// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable S1144 // Unused private types or members should be removed
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class HP
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glImageTransformParameteriHP => _glImageTransformParameteriHP != 0 ? _glImageTransformParameteriHP : _glImageTransformParameteriHP = Lib.GetProcAddress("glImageTransformParameteriHP");
                private nint _glImageTransformParameteriHP;

                public nint glImageTransformParameterfHP => _glImageTransformParameterfHP != 0 ? _glImageTransformParameterfHP : _glImageTransformParameterfHP = Lib.GetProcAddress("glImageTransformParameterfHP");
                private nint _glImageTransformParameterfHP;

                public nint glImageTransformParameterivHP => _glImageTransformParameterivHP != 0 ? _glImageTransformParameterivHP : _glImageTransformParameterivHP = Lib.GetProcAddress("glImageTransformParameterivHP");
                private nint _glImageTransformParameterivHP;

                public nint glImageTransformParameterfvHP => _glImageTransformParameterfvHP != 0 ? _glImageTransformParameterfvHP : _glImageTransformParameterfvHP = Lib.GetProcAddress("glImageTransformParameterfvHP");
                private nint _glImageTransformParameterfvHP;

                public nint glGetImageTransformParameterivHP => _glGetImageTransformParameterivHP != 0 ? _glGetImageTransformParameterivHP : _glGetImageTransformParameterivHP = Lib.GetProcAddress("glGetImageTransformParameterivHP");
                private nint _glGetImageTransformParameterivHP;

                public nint glGetImageTransformParameterfvHP => _glGetImageTransformParameterfvHP != 0 ? _glGetImageTransformParameterfvHP : _glGetImageTransformParameterfvHP = Lib.GetProcAddress("glGetImageTransformParameterfvHP");
                private nint _glGetImageTransformParameterfvHP;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
#pragma warning restore S1144 // Unused private types or members should be removed
}
