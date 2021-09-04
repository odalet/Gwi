// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES1
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private NVExtension? _NV;
        public NVExtension NV => _NV ??= new NVExtension(this);

        public sealed unsafe partial class NVExtension
        {
            private readonly VTable vtable;

            internal NVExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void DeleteFencesNV(int n, uint* fences) => ((delegate* unmanaged[Cdecl]<int, uint*, void>)vtable.glDeleteFencesNV)(n, fences);
            public void GenFencesNV(int n, uint* fences) => ((delegate* unmanaged[Cdecl]<int, uint*, void>)vtable.glGenFencesNV)(n, fences);
            public byte IsFenceNV(uint fence) => ((delegate* unmanaged[Cdecl]<uint, byte>)vtable.glIsFenceNV)(fence);
            public byte TestFenceNV(uint fence) => ((delegate* unmanaged[Cdecl]<uint, byte>)vtable.glTestFenceNV)(fence);
            public void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => ((delegate* unmanaged[Cdecl]<uint, FenceParameterNameNV, int*, void>)vtable.glGetFenceivNV)(fence, pname, parameters);
            public void FinishFenceNV(uint fence) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glFinishFenceNV)(fence);
            public void SetFenceNV(uint fence, FenceConditionNV condition) => ((delegate* unmanaged[Cdecl]<uint, FenceConditionNV, void>)vtable.glSetFenceNV)(fence, condition);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
