// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gwi.OpenGL.GL4
{
#pragma warning disable IDE1006 // Naming Styles

    public static class SGISOverloads
    {
        // DetailTexFuncSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void DetailTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, ReadOnlySpan<float> points)
        {
            var n = (int)(points.Length / 2);
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.DetailTexFuncSGIS(target, n, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void DetailTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, float[] points)
        {
            var n = (int)(points.Length / 2);
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.DetailTexFuncSGIS(target, n, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void DetailTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, int n, in float points)
        {
            fixed (float* points_ptr = &points) // RefInsteadOfPointerLayer
            {
                glInstance.DetailTexFuncSGIS(target, n, points_ptr);
            }
        }

        // GetDetailTexFuncSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetDetailTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, Span<float> points)
        {
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.GetDetailTexFuncSGIS(target, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetDetailTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, float[] points)
        {
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.GetDetailTexFuncSGIS(target, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetDetailTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, ref float points)
        {
            fixed (float* points_ptr = &points) // RefInsteadOfPointerLayer
            {
                glInstance.GetDetailTexFuncSGIS(target, points_ptr);
            }
        }

        // FogFuncSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void FogFuncSGIS(this GL.SGISExtension glInstance, ReadOnlySpan<float> points)
        {
            var n = (int)(points.Length / 2);
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.FogFuncSGIS(n, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void FogFuncSGIS(this GL.SGISExtension glInstance, float[] points)
        {
            var n = (int)(points.Length / 2);
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.FogFuncSGIS(n, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void FogFuncSGIS(this GL.SGISExtension glInstance, int n, in float points)
        {
            fixed (float* points_ptr = &points) // RefInsteadOfPointerLayer
            {
                glInstance.FogFuncSGIS(n, points_ptr);
            }
        }

        // GetFogFuncSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetFogFuncSGIS(this GL.SGISExtension glInstance, Span<float> points)
        {
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.GetFogFuncSGIS(points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetFogFuncSGIS(this GL.SGISExtension glInstance, float[] points)
        {
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.GetFogFuncSGIS(points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetFogFuncSGIS(this GL.SGISExtension glInstance, ref float points)
        {
            fixed (float* points_ptr = &points) // RefInsteadOfPointerLayer
            {
                glInstance.GetFogFuncSGIS(points_ptr);
            }
        }

        // SampleMaskSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.BoolOverloader
        public static unsafe void SampleMaskSGIS(this GL.SGISExtension glInstance, float value, bool invert)
        {
            var invert_byte = (byte)(invert ? 1 : 0);
            glInstance.SampleMaskSGIS(value, invert_byte);
        }

        // PixelTexGenParameterivSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void PixelTexGenParameterivSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, ReadOnlySpan<int> parameters)
        {
            fixed (int* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.PixelTexGenParameterivSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void PixelTexGenParameterivSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.PixelTexGenParameterivSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void PixelTexGenParameterivSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, in int parameters)
        {
            fixed (int* parameters_ptr = &parameters) // RefInsteadOfPointerLayer
            {
                glInstance.PixelTexGenParameterivSGIS(pname, parameters_ptr);
            }
        }

        // PixelTexGenParameterfvSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void PixelTexGenParameterfvSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.PixelTexGenParameterfvSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void PixelTexGenParameterfvSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.PixelTexGenParameterfvSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void PixelTexGenParameterfvSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters) // RefInsteadOfPointerLayer
            {
                glInstance.PixelTexGenParameterfvSGIS(pname, parameters_ptr);
            }
        }

        // GetPixelTexGenParameterivSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetPixelTexGenParameterivSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, Span<int> parameters)
        {
            fixed (int* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.GetPixelTexGenParameterivSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetPixelTexGenParameterivSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, int[] parameters)
        {
            fixed (int* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.GetPixelTexGenParameterivSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetPixelTexGenParameterivSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters) // RefInsteadOfPointerLayer
            {
                glInstance.GetPixelTexGenParameterivSGIS(pname, parameters_ptr);
            }
        }

        // GetPixelTexGenParameterfvSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetPixelTexGenParameterfvSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, Span<float> parameters)
        {
            fixed (float* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.GetPixelTexGenParameterfvSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetPixelTexGenParameterfvSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.GetPixelTexGenParameterfvSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetPixelTexGenParameterfvSGIS(this GL.SGISExtension glInstance, PixelTexGenParameterNameSGIS pname, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters) // RefInsteadOfPointerLayer
            {
                glInstance.GetPixelTexGenParameterfvSGIS(pname, parameters_ptr);
            }
        }

        // PointParameterfvSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void PointParameterfvSGIS(this GL.SGISExtension glInstance, PointParameterNameARB pname, ReadOnlySpan<float> parameters)
        {
            fixed (float* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.PointParameterfvSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void PointParameterfvSGIS(this GL.SGISExtension glInstance, PointParameterNameARB pname, float[] parameters)
        {
            fixed (float* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.PointParameterfvSGIS(pname, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void PointParameterfvSGIS(this GL.SGISExtension glInstance, PointParameterNameARB pname, in float parameters)
        {
            fixed (float* parameters_ptr = &parameters) // RefInsteadOfPointerLayer
            {
                glInstance.PointParameterfvSGIS(pname, parameters_ptr);
            }
        }

        // SharpenTexFuncSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void SharpenTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, ReadOnlySpan<float> points)
        {
            var n = (int)(points.Length / 2);
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.SharpenTexFuncSGIS(target, n, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void SharpenTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, float[] points)
        {
            var n = (int)(points.Length / 2);
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.SharpenTexFuncSGIS(target, n, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void SharpenTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, int n, in float points)
        {
            fixed (float* points_ptr = &points) // RefInsteadOfPointerLayer
            {
                glInstance.SharpenTexFuncSGIS(target, n, points_ptr);
            }
        }

        // GetSharpenTexFuncSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetSharpenTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, Span<float> points)
        {
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.GetSharpenTexFuncSGIS(target, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetSharpenTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, float[] points)
        {
            fixed (float* points_ptr = points) // SpanOrArrayLayer
            {
                glInstance.GetSharpenTexFuncSGIS(target, points_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetSharpenTexFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, ref float points)
        {
            fixed (float* points_ptr = &points) // RefInsteadOfPointerLayer
            {
                glInstance.GetSharpenTexFuncSGIS(target, points_ptr);
            }
        }

        // TexImage4DSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.VoidPtrToIntPtrOverloader
        public static unsafe void TexImage4DSGIS(this GL.SGISExtension glInstance, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            var pixels_vptr = (void*)pixels;
            glInstance.TexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels_vptr);
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void TexImage4DSGIS<T1>(this GL.SGISExtension glInstance, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels) // SpanOrArrayLayer
            {
                glInstance.TexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void TexImage4DSGIS<T1>(this GL.SGISExtension glInstance, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels) // SpanOrArrayLayer
            {
                glInstance.TexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void TexImage4DSGIS<T1>(this GL.SGISExtension glInstance, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels) // RefInsteadOfPointerLayer
            {
                glInstance.TexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels_ptr);
            }
        }

        // TexSubImage4DSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.VoidPtrToIntPtrOverloader
        public static unsafe void TexSubImage4DSGIS(this GL.SGISExtension glInstance, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, IntPtr pixels)
        {
            var pixels_vptr = (void*)pixels;
            glInstance.TexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels_vptr);
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void TexSubImage4DSGIS<T1>(this GL.SGISExtension glInstance, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, ReadOnlySpan<T1> pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels) // SpanOrArrayLayer
            {
                glInstance.TexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void TexSubImage4DSGIS<T1>(this GL.SGISExtension glInstance, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, T1[] pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = pixels) // SpanOrArrayLayer
            {
                glInstance.TexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void TexSubImage4DSGIS<T1>(this GL.SGISExtension glInstance, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, in T1 pixels)
            where T1 : unmanaged
        {
            fixed (void* pixels_ptr = &pixels) // RefInsteadOfPointerLayer
            {
                glInstance.TexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels_ptr);
            }
        }

        // TextureColorMaskSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.BoolOverloader
        public static unsafe void TextureColorMaskSGIS(this GL.SGISExtension glInstance, bool red, bool green, bool blue, bool alpha)
        {
            var red_byte = (byte)(red ? 1 : 0);
            var green_byte = (byte)(green ? 1 : 0);
            var blue_byte = (byte)(blue ? 1 : 0);
            var alpha_byte = (byte)(alpha ? 1 : 0);
            glInstance.TextureColorMaskSGIS(red_byte, green_byte, blue_byte, alpha_byte);
        }

        // GetTexFilterFuncSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetTexFilterFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, TextureFilterSGIS filter, Span<float> weights)
        {
            fixed (float* weights_ptr = weights) // SpanOrArrayLayer
            {
                glInstance.GetTexFilterFuncSGIS(target, filter, weights_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetTexFilterFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, TextureFilterSGIS filter, float[] weights)
        {
            fixed (float* weights_ptr = weights) // SpanOrArrayLayer
            {
                glInstance.GetTexFilterFuncSGIS(target, filter, weights_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetTexFilterFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, TextureFilterSGIS filter, ref float weights)
        {
            fixed (float* weights_ptr = &weights) // RefInsteadOfPointerLayer
            {
                glInstance.GetTexFilterFuncSGIS(target, filter, weights_ptr);
            }
        }

        // TexFilterFuncSGIS overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void TexFilterFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, TextureFilterSGIS filter, ReadOnlySpan<float> weights)
        {
            var n = (int)(weights.Length);
            fixed (float* weights_ptr = weights) // SpanOrArrayLayer
            {
                glInstance.TexFilterFuncSGIS(target, filter, n, weights_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void TexFilterFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, TextureFilterSGIS filter, float[] weights)
        {
            var n = (int)(weights.Length);
            fixed (float* weights_ptr = weights) // SpanOrArrayLayer
            {
                glInstance.TexFilterFuncSGIS(target, filter, n, weights_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void TexFilterFuncSGIS(this GL.SGISExtension glInstance, TextureTarget target, TextureFilterSGIS filter, int n, in float weights)
        {
            fixed (float* weights_ptr = &weights) // RefInsteadOfPointerLayer
            {
                glInstance.TexFilterFuncSGIS(target, filter, n, weights_ptr);
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
