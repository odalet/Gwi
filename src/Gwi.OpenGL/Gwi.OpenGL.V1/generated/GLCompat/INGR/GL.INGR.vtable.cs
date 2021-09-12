// This file is auto generated, do not edit.

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        unsafe partial class INGRExtension
        {
            private sealed unsafe class VTable : BaseVTable
            {
                public VTable(INativeLib lib) : base(lib) { }

                public nint glBlendFuncSeparateINGR => _glBlendFuncSeparateINGR != 0 ? _glBlendFuncSeparateINGR : _glBlendFuncSeparateINGR = Lib.GetProcAddress("glBlendFuncSeparateINGR");
                private nint _glBlendFuncSeparateINGR;
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
