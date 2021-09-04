// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GL4
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private IBMExtension? _IBM;
        public IBMExtension IBM => _IBM ??= new IBMExtension(this);

        public sealed unsafe partial class IBMExtension
        {
            private readonly VTable vtable;

            internal IBMExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void MultiModeDrawArraysIBM(PrimitiveType* mode, int* first, int* count, int primcount, int modestride) => ((delegate* unmanaged[Cdecl]<PrimitiveType*, int*, int*, int, int, void>)vtable.glMultiModeDrawArraysIBM)(mode, first, count, primcount, modestride);
            public void MultiModeDrawElementsIBM(PrimitiveType* mode, int* count, DrawElementsType type, void** indices, int primcount, int modestride) => ((delegate* unmanaged[Cdecl]<PrimitiveType*, int*, DrawElementsType, void**, int, int, void>)vtable.glMultiModeDrawElementsIBM)(mode, count, type, indices, primcount, modestride);
            public void FlushStaticDataIBM(GLEnum target) => ((delegate* unmanaged[Cdecl]<GLEnum, void>)vtable.glFlushStaticDataIBM)(target);
            public void ColorPointerListIBM(int size, ColorPointerType type, int stride, void** pointer, int ptrstride) => ((delegate* unmanaged[Cdecl]<int, ColorPointerType, int, void**, int, void>)vtable.glColorPointerListIBM)(size, type, stride, pointer, ptrstride);
            public void SecondaryColorPointerListIBM(int size, SecondaryColorPointerTypeIBM type, int stride, void** pointer, int ptrstride) => ((delegate* unmanaged[Cdecl]<int, SecondaryColorPointerTypeIBM, int, void**, int, void>)vtable.glSecondaryColorPointerListIBM)(size, type, stride, pointer, ptrstride);
            public void EdgeFlagPointerListIBM(int stride, byte** pointer, int ptrstride) => ((delegate* unmanaged[Cdecl]<int, byte**, int, void>)vtable.glEdgeFlagPointerListIBM)(stride, pointer, ptrstride);
            public void FogCoordPointerListIBM(FogPointerTypeIBM type, int stride, void** pointer, int ptrstride) => ((delegate* unmanaged[Cdecl]<FogPointerTypeIBM, int, void**, int, void>)vtable.glFogCoordPointerListIBM)(type, stride, pointer, ptrstride);
            public void IndexPointerListIBM(IndexPointerType type, int stride, void** pointer, int ptrstride) => ((delegate* unmanaged[Cdecl]<IndexPointerType, int, void**, int, void>)vtable.glIndexPointerListIBM)(type, stride, pointer, ptrstride);
            public void NormalPointerListIBM(NormalPointerType type, int stride, void** pointer, int ptrstride) => ((delegate* unmanaged[Cdecl]<NormalPointerType, int, void**, int, void>)vtable.glNormalPointerListIBM)(type, stride, pointer, ptrstride);
            public void TexCoordPointerListIBM(int size, TexCoordPointerType type, int stride, void** pointer, int ptrstride) => ((delegate* unmanaged[Cdecl]<int, TexCoordPointerType, int, void**, int, void>)vtable.glTexCoordPointerListIBM)(size, type, stride, pointer, ptrstride);
            public void VertexPointerListIBM(int size, VertexPointerType type, int stride, void** pointer, int ptrstride) => ((delegate* unmanaged[Cdecl]<int, VertexPointerType, int, void**, int, void>)vtable.glVertexPointerListIBM)(size, type, stride, pointer, ptrstride);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
