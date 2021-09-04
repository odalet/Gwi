// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GL4
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private SGISExtension? _SGIS;
        public SGISExtension SGIS => _SGIS ??= new SGISExtension(this);

        public sealed unsafe partial class SGISExtension
        {
            private readonly VTable vtable;

            internal SGISExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void DetailTexFuncSGIS(TextureTarget target, int n, float* points) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, float*, void>)vtable.glDetailTexFuncSGIS)(target, n, points);
            public void GetDetailTexFuncSGIS(TextureTarget target, float* points) => ((delegate* unmanaged[Cdecl]<TextureTarget, float*, void>)vtable.glGetDetailTexFuncSGIS)(target, points);
            public void FogFuncSGIS(int n, float* points) => ((delegate* unmanaged[Cdecl]<int, float*, void>)vtable.glFogFuncSGIS)(n, points);
            public void GetFogFuncSGIS(float* points) => ((delegate* unmanaged[Cdecl]<float*, void>)vtable.glGetFogFuncSGIS)(points);
            public void SampleMaskSGIS(float value, byte invert) => ((delegate* unmanaged[Cdecl]<float, byte, void>)vtable.glSampleMaskSGIS)(value, invert);
            public void SamplePatternSGIS(SamplePatternSGIS pattern) => ((delegate* unmanaged[Cdecl]<SamplePatternSGIS, void>)vtable.glSamplePatternSGIS)(pattern);
            public void PixelTexGenParameteriSGIS(PixelTexGenParameterNameSGIS pname, int param) => ((delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, int, void>)vtable.glPixelTexGenParameteriSGIS)(pname, param);
            public void PixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int* parameters) => ((delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, int*, void>)vtable.glPixelTexGenParameterivSGIS)(pname, parameters);
            public void PixelTexGenParameterfSGIS(PixelTexGenParameterNameSGIS pname, float param) => ((delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, float, void>)vtable.glPixelTexGenParameterfSGIS)(pname, param);
            public void PixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float* parameters) => ((delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, float*, void>)vtable.glPixelTexGenParameterfvSGIS)(pname, parameters);
            public void GetPixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int* parameters) => ((delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, int*, void>)vtable.glGetPixelTexGenParameterivSGIS)(pname, parameters);
            public void GetPixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float* parameters) => ((delegate* unmanaged[Cdecl]<PixelTexGenParameterNameSGIS, float*, void>)vtable.glGetPixelTexGenParameterfvSGIS)(pname, parameters);
            public void PointParameterfSGIS(PointParameterNameARB pname, float param) => ((delegate* unmanaged[Cdecl]<PointParameterNameARB, float, void>)vtable.glPointParameterfSGIS)(pname, param);
            public void PointParameterfvSGIS(PointParameterNameARB pname, float* parameters) => ((delegate* unmanaged[Cdecl]<PointParameterNameARB, float*, void>)vtable.glPointParameterfvSGIS)(pname, parameters);
            public void SharpenTexFuncSGIS(TextureTarget target, int n, float* points) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, float*, void>)vtable.glSharpenTexFuncSGIS)(target, n, points);
            public void GetSharpenTexFuncSGIS(TextureTarget target, float* points) => ((delegate* unmanaged[Cdecl]<TextureTarget, float*, void>)vtable.glGetSharpenTexFuncSGIS)(target, points);
            public void TexImage4DSGIS(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, void* pixels) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, InternalFormat, int, int, int, int, int, PixelFormat, PixelType, void*, void>)vtable.glTexImage4DSGIS)(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);
            public void TexSubImage4DSGIS(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, void* pixels) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, int, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)vtable.glTexSubImage4DSGIS)(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);
            public void TextureColorMaskSGIS(byte red, byte green, byte blue, byte alpha) => ((delegate* unmanaged[Cdecl]<byte, byte, byte, byte, void>)vtable.glTextureColorMaskSGIS)(red, green, blue, alpha);
            public void GetTexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, float* weights) => ((delegate* unmanaged[Cdecl]<TextureTarget, TextureFilterSGIS, float*, void>)vtable.glGetTexFilterFuncSGIS)(target, filter, weights);
            public void TexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, int n, float* weights) => ((delegate* unmanaged[Cdecl]<TextureTarget, TextureFilterSGIS, int, float*, void>)vtable.glTexFilterFuncSGIS)(target, filter, n, weights);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
