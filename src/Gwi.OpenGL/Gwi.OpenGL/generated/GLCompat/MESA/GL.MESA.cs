// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private MESAExtension? _MESA;
        public MESAExtension MESA => _MESA ??= new MESAExtension(this);

        public sealed unsafe partial class MESAExtension
        {
            private readonly VTable vtable;

            internal MESAExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void FramebufferParameteriMESA(FramebufferTarget target, FramebufferParameterName pname, int param) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferParameterName, int, void>)vtable.glFramebufferParameteriMESA)(target, pname, param);
            public void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, int*, void>)vtable.glGetFramebufferParameterivMESA)(target, pname, parameters);
            public void ResizeBuffersMESA() => ((delegate* unmanaged[Cdecl]<void>)vtable.glResizeBuffersMESA)();
            public void WindowPos2dMESA(double x, double y) => ((delegate* unmanaged[Cdecl]<double, double, void>)vtable.glWindowPos2dMESA)(x, y);
            public void WindowPos2dvMESA(double* v) => ((delegate* unmanaged[Cdecl]<double*, void>)vtable.glWindowPos2dvMESA)(v);
            public void WindowPos2fMESA(float x, float y) => ((delegate* unmanaged[Cdecl]<float, float, void>)vtable.glWindowPos2fMESA)(x, y);
            public void WindowPos2fvMESA(float* v) => ((delegate* unmanaged[Cdecl]<float*, void>)vtable.glWindowPos2fvMESA)(v);
            public void WindowPos2iMESA(int x, int y) => ((delegate* unmanaged[Cdecl]<int, int, void>)vtable.glWindowPos2iMESA)(x, y);
            public void WindowPos2ivMESA(int* v) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glWindowPos2ivMESA)(v);
            public void WindowPos2sMESA(short x, short y) => ((delegate* unmanaged[Cdecl]<short, short, void>)vtable.glWindowPos2sMESA)(x, y);
            public void WindowPos2svMESA(short* v) => ((delegate* unmanaged[Cdecl]<short*, void>)vtable.glWindowPos2svMESA)(v);
            public void WindowPos3dMESA(double x, double y, double z) => ((delegate* unmanaged[Cdecl]<double, double, double, void>)vtable.glWindowPos3dMESA)(x, y, z);
            public void WindowPos3dvMESA(double* v) => ((delegate* unmanaged[Cdecl]<double*, void>)vtable.glWindowPos3dvMESA)(v);
            public void WindowPos3fMESA(float x, float y, float z) => ((delegate* unmanaged[Cdecl]<float, float, float, void>)vtable.glWindowPos3fMESA)(x, y, z);
            public void WindowPos3fvMESA(float* v) => ((delegate* unmanaged[Cdecl]<float*, void>)vtable.glWindowPos3fvMESA)(v);
            public void WindowPos3iMESA(int x, int y, int z) => ((delegate* unmanaged[Cdecl]<int, int, int, void>)vtable.glWindowPos3iMESA)(x, y, z);
            public void WindowPos3ivMESA(int* v) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glWindowPos3ivMESA)(v);
            public void WindowPos3sMESA(short x, short y, short z) => ((delegate* unmanaged[Cdecl]<short, short, short, void>)vtable.glWindowPos3sMESA)(x, y, z);
            public void WindowPos3svMESA(short* v) => ((delegate* unmanaged[Cdecl]<short*, void>)vtable.glWindowPos3svMESA)(v);
            public void WindowPos4dMESA(double x, double y, double z, double w) => ((delegate* unmanaged[Cdecl]<double, double, double, double, void>)vtable.glWindowPos4dMESA)(x, y, z, w);
            public void WindowPos4dvMESA(double* v) => ((delegate* unmanaged[Cdecl]<double*, void>)vtable.glWindowPos4dvMESA)(v);
            public void WindowPos4fMESA(float x, float y, float z, float w) => ((delegate* unmanaged[Cdecl]<float, float, float, float, void>)vtable.glWindowPos4fMESA)(x, y, z, w);
            public void WindowPos4fvMESA(float* v) => ((delegate* unmanaged[Cdecl]<float*, void>)vtable.glWindowPos4fvMESA)(v);
            public void WindowPos4iMESA(int x, int y, int z, int w) => ((delegate* unmanaged[Cdecl]<int, int, int, int, void>)vtable.glWindowPos4iMESA)(x, y, z, w);
            public void WindowPos4ivMESA(int* v) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glWindowPos4ivMESA)(v);
            public void WindowPos4sMESA(short x, short y, short z, short w) => ((delegate* unmanaged[Cdecl]<short, short, short, short, void>)vtable.glWindowPos4sMESA)(x, y, z, w);
            public void WindowPos4svMESA(short* v) => ((delegate* unmanaged[Cdecl]<short*, void>)vtable.glWindowPos4svMESA)(v);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
