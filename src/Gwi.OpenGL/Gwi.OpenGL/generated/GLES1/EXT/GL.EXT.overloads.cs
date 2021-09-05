// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gwi.OpenGL.GLES1
{
#pragma warning disable IDE1006 // Naming Styles

    public static class EXTOverloads
    {
        // InsertEventMarkerEXT overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.Transformer
        public static unsafe void InsertEventMarkerEXT(this GL.EXTExtension glInstance, int length, string marker)
        {
            byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
            glInstance.InsertEventMarkerEXT(length, marker_ptr);
            Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
        }

        // PushGroupMarkerEXT overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.Transformer
        public static unsafe void PushGroupMarkerEXT(this GL.EXTExtension glInstance, int length, string marker)
        {
            byte* marker_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(marker);
            glInstance.PushGroupMarkerEXT(length, marker_ptr);
            Marshal.FreeCoTaskMem((IntPtr)marker_ptr);
        }

        // DiscardFramebufferEXT overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void DiscardFramebufferEXT(this GL.EXTExtension glInstance, FramebufferTarget target, ReadOnlySpan<InvalidateFramebufferAttachment> attachments)
        {
            var numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments) // SpanOrArrayLayer
            {
                glInstance.DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void DiscardFramebufferEXT(this GL.EXTExtension glInstance, FramebufferTarget target, InvalidateFramebufferAttachment[] attachments)
        {
            var numAttachments = (int)(attachments.Length);
            fixed (InvalidateFramebufferAttachment* attachments_ptr = attachments) // SpanOrArrayLayer
            {
                glInstance.DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void DiscardFramebufferEXT(this GL.EXTExtension glInstance, FramebufferTarget target, int numAttachments, in InvalidateFramebufferAttachment attachments)
        {
            fixed (InvalidateFramebufferAttachment* attachments_ptr = &attachments) // RefInsteadOfPointerLayer
            {
                glInstance.DiscardFramebufferEXT(target, numAttachments, attachments_ptr);
            }
        }

        // MultiDrawArraysEXT overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void MultiDrawArraysEXT(this GL.EXTExtension glInstance, PrimitiveType mode, ReadOnlySpan<int> first, ReadOnlySpan<int> count, int primcount)
        {
            fixed (int* first_ptr = first) // SpanOrArrayLayer
            {
                fixed (int* count_ptr = count) // SpanOrArrayLayer
                {
                    glInstance.MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void MultiDrawArraysEXT(this GL.EXTExtension glInstance, PrimitiveType mode, int[] first, int[] count, int primcount)
        {
            fixed (int* first_ptr = first) // SpanOrArrayLayer
            {
                fixed (int* count_ptr = count) // SpanOrArrayLayer
                {
                    glInstance.MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void MultiDrawArraysEXT(this GL.EXTExtension glInstance, PrimitiveType mode, in int first, in int count, int primcount)
        {
            fixed (int* first_ptr = &first) // RefInsteadOfPointerLayer
            fixed (int* count_ptr = &count) // RefInsteadOfPointerLayer
            {
                glInstance.MultiDrawArraysEXT(mode, first_ptr, count_ptr, primcount);
            }
        }

        // MultiDrawElementsEXT overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void MultiDrawElementsEXT(this GL.EXTExtension glInstance, PrimitiveType mode, ReadOnlySpan<int> count, DrawElementsType type, void** indices, int primcount)
        {
            fixed (int* count_ptr = count) // SpanOrArrayLayer
            {
                glInstance.MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void MultiDrawElementsEXT(this GL.EXTExtension glInstance, PrimitiveType mode, int[] count, DrawElementsType type, void** indices, int primcount)
        {
            fixed (int* count_ptr = count) // SpanOrArrayLayer
            {
                glInstance.MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void MultiDrawElementsEXT(this GL.EXTExtension glInstance, PrimitiveType mode, in int count, DrawElementsType type, void** indices, int primcount)
        {
            fixed (int* count_ptr = &count) // RefInsteadOfPointerLayer
            {
                glInstance.MultiDrawElementsEXT(mode, count_ptr, type, indices, primcount);
            }
        }

        // ReadnPixelsEXT overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.VoidPtrToIntPtrOverloader
        public static unsafe void ReadnPixelsEXT(this GL.EXTExtension glInstance, int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
        {
            var data_vptr = (void*)data;
            glInstance.ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_vptr);
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void ReadnPixelsEXT<T1>(this GL.EXTExtension glInstance, int x, int y, int width, int height, PixelFormat format, PixelType type, Span<T1> data)
            where T1 : unmanaged
        {
            var bufSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data) // SpanOrArrayLayer
            {
                glInstance.ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void ReadnPixelsEXT<T1>(this GL.EXTExtension glInstance, int x, int y, int width, int height, PixelFormat format, PixelType type, T1[] data)
            where T1 : unmanaged
        {
            var bufSize = (int)(data.Length * sizeof(T1));
            fixed (void* data_ptr = data) // SpanOrArrayLayer
            {
                glInstance.ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void ReadnPixelsEXT<T1>(this GL.EXTExtension glInstance, int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, ref T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data) // RefInsteadOfPointerLayer
            {
                glInstance.ReadnPixelsEXT(x, y, width, height, format, type, bufSize, data_ptr);
            }
        }

        // GetnUniformfvEXT overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetnUniformfvEXT(this GL.EXTExtension glInstance, ProgramHandle program, int location, Span<float> parameters)
        {
            var bufSize = (int)(parameters.Length * 4);
            fixed (float* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetnUniformfvEXT(this GL.EXTExtension glInstance, ProgramHandle program, int location, float[] parameters)
        {
            var bufSize = (int)(parameters.Length * 4);
            fixed (float* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetnUniformfvEXT(this GL.EXTExtension glInstance, ProgramHandle program, int location, int bufSize, ref float parameters)
        {
            fixed (float* parameters_ptr = &parameters) // RefInsteadOfPointerLayer
            {
                glInstance.GetnUniformfvEXT(program, location, bufSize, parameters_ptr);
            }
        }

        // GetnUniformivEXT overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetnUniformivEXT(this GL.EXTExtension glInstance, ProgramHandle program, int location, Span<int> parameters)
        {
            var bufSize = (int)(parameters.Length * 4);
            fixed (int* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.GetnUniformivEXT(program, location, bufSize, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void GetnUniformivEXT(this GL.EXTExtension glInstance, ProgramHandle program, int location, int[] parameters)
        {
            var bufSize = (int)(parameters.Length * 4);
            fixed (int* parameters_ptr = parameters) // SpanOrArrayLayer
            {
                glInstance.GetnUniformivEXT(program, location, bufSize, parameters_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetnUniformivEXT(this GL.EXTExtension glInstance, ProgramHandle program, int location, int bufSize, ref int parameters)
        {
            fixed (int* parameters_ptr = &parameters) // RefInsteadOfPointerLayer
            {
                glInstance.GetnUniformivEXT(program, location, bufSize, parameters_ptr);
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
