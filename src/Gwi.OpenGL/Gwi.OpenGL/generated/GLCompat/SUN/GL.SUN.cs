// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private SUNExtension? _SUN;
        public SUNExtension SUN => _SUN ??= new SUNExtension(this);

        public sealed unsafe partial class SUNExtension
        {
            private readonly VTable vtable;

            internal SUNExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void GlobalAlphaFactorbSUN(sbyte factor) => ((delegate* unmanaged[Cdecl]<sbyte, void>)vtable.glGlobalAlphaFactorbSUN)(factor);
            public void GlobalAlphaFactorsSUN(short factor) => ((delegate* unmanaged[Cdecl]<short, void>)vtable.glGlobalAlphaFactorsSUN)(factor);
            public void GlobalAlphaFactoriSUN(int factor) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glGlobalAlphaFactoriSUN)(factor);
            public void GlobalAlphaFactorfSUN(float factor) => ((delegate* unmanaged[Cdecl]<float, void>)vtable.glGlobalAlphaFactorfSUN)(factor);
            public void GlobalAlphaFactordSUN(double factor) => ((delegate* unmanaged[Cdecl]<double, void>)vtable.glGlobalAlphaFactordSUN)(factor);
            public void GlobalAlphaFactorubSUN(byte factor) => ((delegate* unmanaged[Cdecl]<byte, void>)vtable.glGlobalAlphaFactorubSUN)(factor);
            public void GlobalAlphaFactorusSUN(ushort factor) => ((delegate* unmanaged[Cdecl]<ushort, void>)vtable.glGlobalAlphaFactorusSUN)(factor);
            public void GlobalAlphaFactoruiSUN(uint factor) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glGlobalAlphaFactoruiSUN)(factor);
            public void DrawMeshArraysSUN(PrimitiveType mode, int first, int count, int width) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int, int, int, void>)vtable.glDrawMeshArraysSUN)(mode, first, count, width);
            public void ReplacementCodeuiSUN(uint code) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glReplacementCodeuiSUN)(code);
            public void ReplacementCodeusSUN(ushort code) => ((delegate* unmanaged[Cdecl]<ushort, void>)vtable.glReplacementCodeusSUN)(code);
            public void ReplacementCodeubSUN(byte code) => ((delegate* unmanaged[Cdecl]<byte, void>)vtable.glReplacementCodeubSUN)(code);
            public void ReplacementCodeuivSUN(uint* code) => ((delegate* unmanaged[Cdecl]<uint*, void>)vtable.glReplacementCodeuivSUN)(code);
            public void ReplacementCodeusvSUN(ushort* code) => ((delegate* unmanaged[Cdecl]<ushort*, void>)vtable.glReplacementCodeusvSUN)(code);
            public void ReplacementCodeubvSUN(byte* code) => ((delegate* unmanaged[Cdecl]<byte*, void>)vtable.glReplacementCodeubvSUN)(code);
            public void ReplacementCodePointerSUN(ReplacementCodeTypeSUN type, int stride, void** pointer) => ((delegate* unmanaged[Cdecl]<ReplacementCodeTypeSUN, int, void**, void>)vtable.glReplacementCodePointerSUN)(type, stride, pointer);
            public void Color4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y) => ((delegate* unmanaged[Cdecl]<byte, byte, byte, byte, float, float, void>)vtable.glColor4ubVertex2fSUN)(r, g, b, a, x, y);
            public void Color4ubVertex2fvSUN(byte* c, float* v) => ((delegate* unmanaged[Cdecl]<byte*, float*, void>)vtable.glColor4ubVertex2fvSUN)(c, v);
            public void Color4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<byte, byte, byte, byte, float, float, float, void>)vtable.glColor4ubVertex3fSUN)(r, g, b, a, x, y, z);
            public void Color4ubVertex3fvSUN(byte* c, float* v) => ((delegate* unmanaged[Cdecl]<byte*, float*, void>)vtable.glColor4ubVertex3fvSUN)(c, v);
            public void Color3fVertex3fSUN(float r, float g, float b, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, void>)vtable.glColor3fVertex3fSUN)(r, g, b, x, y, z);
            public void Color3fVertex3fvSUN(float* c, float* v) => ((delegate* unmanaged[Cdecl]<float*, float*, void>)vtable.glColor3fVertex3fvSUN)(c, v);
            public void Normal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, void>)vtable.glNormal3fVertex3fSUN)(nx, ny, nz, x, y, z);
            public void Normal3fVertex3fvSUN(float* n, float* v) => ((delegate* unmanaged[Cdecl]<float*, float*, void>)vtable.glNormal3fVertex3fvSUN)(n, v);
            public void Color4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, float, float, float, float, void>)vtable.glColor4fNormal3fVertex3fSUN)(r, g, b, a, nx, ny, nz, x, y, z);
            public void Color4fNormal3fVertex3fvSUN(float* c, float* n, float* v) => ((delegate* unmanaged[Cdecl]<float*, float*, float*, void>)vtable.glColor4fNormal3fVertex3fvSUN)(c, n, v);
            public void TexCoord2fVertex3fSUN(float s, float t, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, void>)vtable.glTexCoord2fVertex3fSUN)(s, t, x, y, z);
            public void TexCoord2fVertex3fvSUN(float* tc, float* v) => ((delegate* unmanaged[Cdecl]<float*, float*, void>)vtable.glTexCoord2fVertex3fvSUN)(tc, v);
            public void TexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, float, float, void>)vtable.glTexCoord4fVertex4fSUN)(s, t, p, q, x, y, z, w);
            public void TexCoord4fVertex4fvSUN(float* tc, float* v) => ((delegate* unmanaged[Cdecl]<float*, float*, void>)vtable.glTexCoord4fVertex4fvSUN)(tc, v);
            public void TexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<float, float, byte, byte, byte, byte, float, float, float, void>)vtable.glTexCoord2fColor4ubVertex3fSUN)(s, t, r, g, b, a, x, y, z);
            public void TexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v) => ((delegate* unmanaged[Cdecl]<float*, byte*, float*, void>)vtable.glTexCoord2fColor4ubVertex3fvSUN)(tc, c, v);
            public void TexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, float, float, void>)vtable.glTexCoord2fColor3fVertex3fSUN)(s, t, r, g, b, x, y, z);
            public void TexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v) => ((delegate* unmanaged[Cdecl]<float*, float*, float*, void>)vtable.glTexCoord2fColor3fVertex3fvSUN)(tc, c, v);
            public void TexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, float, float, void>)vtable.glTexCoord2fNormal3fVertex3fSUN)(s, t, nx, ny, nz, x, y, z);
            public void TexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v) => ((delegate* unmanaged[Cdecl]<float*, float*, float*, void>)vtable.glTexCoord2fNormal3fVertex3fvSUN)(tc, n, v);
            public void TexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, float, float, float, float, float, float, void>)vtable.glTexCoord2fColor4fNormal3fVertex3fSUN)(s, t, r, g, b, a, nx, ny, nz, x, y, z);
            public void TexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v) => ((delegate* unmanaged[Cdecl]<float*, float*, float*, float*, void>)vtable.glTexCoord2fColor4fNormal3fVertex3fvSUN)(tc, c, n, v);
            public void TexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, float, float, float, float, float, float, float, float, float, void>)vtable.glTexCoord4fColor4fNormal3fVertex4fSUN)(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w);
            public void TexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v) => ((delegate* unmanaged[Cdecl]<float*, float*, float*, float*, void>)vtable.glTexCoord4fColor4fNormal3fVertex4fvSUN)(tc, c, n, v);
            public void ReplacementCodeuiVertex3fSUN(uint rc, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<uint, float, float, float, void>)vtable.glReplacementCodeuiVertex3fSUN)(rc, x, y, z);
            public void ReplacementCodeuiVertex3fvSUN(uint* rc, float* v) => ((delegate* unmanaged[Cdecl]<uint*, float*, void>)vtable.glReplacementCodeuiVertex3fvSUN)(rc, v);
            public void ReplacementCodeuiColor4ubVertex3fSUN(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<uint, byte, byte, byte, byte, float, float, float, void>)vtable.glReplacementCodeuiColor4ubVertex3fSUN)(rc, r, g, b, a, x, y, z);
            public void ReplacementCodeuiColor4ubVertex3fvSUN(uint* rc, byte* c, float* v) => ((delegate* unmanaged[Cdecl]<uint*, byte*, float*, void>)vtable.glReplacementCodeuiColor4ubVertex3fvSUN)(rc, c, v);
            public void ReplacementCodeuiColor3fVertex3fSUN(uint rc, float r, float g, float b, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<uint, float, float, float, float, float, float, void>)vtable.glReplacementCodeuiColor3fVertex3fSUN)(rc, r, g, b, x, y, z);
            public void ReplacementCodeuiColor3fVertex3fvSUN(uint* rc, float* c, float* v) => ((delegate* unmanaged[Cdecl]<uint*, float*, float*, void>)vtable.glReplacementCodeuiColor3fVertex3fvSUN)(rc, c, v);
            public void ReplacementCodeuiNormal3fVertex3fSUN(uint rc, float nx, float ny, float nz, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<uint, float, float, float, float, float, float, void>)vtable.glReplacementCodeuiNormal3fVertex3fSUN)(rc, nx, ny, nz, x, y, z);
            public void ReplacementCodeuiNormal3fVertex3fvSUN(uint* rc, float* n, float* v) => ((delegate* unmanaged[Cdecl]<uint*, float*, float*, void>)vtable.glReplacementCodeuiNormal3fVertex3fvSUN)(rc, n, v);
            public void ReplacementCodeuiColor4fNormal3fVertex3fSUN(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<uint, float, float, float, float, float, float, float, float, float, float, void>)vtable.glReplacementCodeuiColor4fNormal3fVertex3fSUN)(rc, r, g, b, a, nx, ny, nz, x, y, z);
            public void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(uint* rc, float* c, float* n, float* v) => ((delegate* unmanaged[Cdecl]<uint*, float*, float*, float*, void>)vtable.glReplacementCodeuiColor4fNormal3fVertex3fvSUN)(rc, c, n, v);
            public void ReplacementCodeuiTexCoord2fVertex3fSUN(uint rc, float s, float t, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<uint, float, float, float, float, float, void>)vtable.glReplacementCodeuiTexCoord2fVertex3fSUN)(rc, s, t, x, y, z);
            public void ReplacementCodeuiTexCoord2fVertex3fvSUN(uint* rc, float* tc, float* v) => ((delegate* unmanaged[Cdecl]<uint*, float*, float*, void>)vtable.glReplacementCodeuiTexCoord2fVertex3fvSUN)(rc, tc, v);
            public void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<uint, float, float, float, float, float, float, float, float, void>)vtable.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN)(rc, s, t, nx, ny, nz, x, y, z);
            public void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(uint* rc, float* tc, float* n, float* v) => ((delegate* unmanaged[Cdecl]<uint*, float*, float*, float*, void>)vtable.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN)(rc, tc, n, v);
            public void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<uint, float, float, float, float, float, float, float, float, float, float, float, float, void>)vtable.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN)(rc, s, t, r, g, b, a, nx, ny, nz, x, y, z);
            public void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(uint* rc, float* tc, float* c, float* n, float* v) => ((delegate* unmanaged[Cdecl]<uint*, float*, float*, float*, float*, void>)vtable.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN)(rc, tc, c, n, v);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
