// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLES3
{
#pragma warning disable S1144 // Unused private types or members should be removed
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class OVR
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glFramebufferTextureMultiviewOVR => _glFramebufferTextureMultiviewOVR != 0 ? _glFramebufferTextureMultiviewOVR : _glFramebufferTextureMultiviewOVR = Lib.GetProcAddress("glFramebufferTextureMultiviewOVR");
                private nint _glFramebufferTextureMultiviewOVR;

                public nint glFramebufferTextureMultisampleMultiviewOVR => _glFramebufferTextureMultisampleMultiviewOVR != 0 ? _glFramebufferTextureMultisampleMultiviewOVR : _glFramebufferTextureMultisampleMultiviewOVR = Lib.GetProcAddress("glFramebufferTextureMultisampleMultiviewOVR");
                private nint _glFramebufferTextureMultisampleMultiviewOVR;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
#pragma warning restore S1144 // Unused private types or members should be removed
}