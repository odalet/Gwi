// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    public static class NVXOverloads
    {
        // LGPUNamedBufferSubDataNVX overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.VoidPtrToIntPtrOverloader
        public static unsafe void LGPUNamedBufferSubDataNVX(this GL.NVXExtension glInstance, GLEnum gpuMask, BufferHandle buffer, IntPtr offset, nint size, IntPtr data)
        {
            var data_vptr = (void*)data;
            glInstance.LGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, size, data_vptr);
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void LGPUNamedBufferSubDataNVX<T1>(this GL.NVXExtension glInstance, GLEnum gpuMask, BufferHandle buffer, IntPtr offset, nint size, in T1 data)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data) // RefInsteadOfPointerLayer
            {
                glInstance.LGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, size, data_ptr);
            }
        }

        // MulticastViewportArrayvNVX overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void MulticastViewportArrayvNVX(this GL.NVXExtension glInstance, uint gpu, uint first, int count, ReadOnlySpan<float> v)
        {
            fixed (float* v_ptr = v) // SpanOrArrayLayer
            {
                glInstance.MulticastViewportArrayvNVX(gpu, first, count, v_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void MulticastViewportArrayvNVX(this GL.NVXExtension glInstance, uint gpu, uint first, int count, float[] v)
        {
            fixed (float* v_ptr = v) // SpanOrArrayLayer
            {
                glInstance.MulticastViewportArrayvNVX(gpu, first, count, v_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void MulticastViewportArrayvNVX(this GL.NVXExtension glInstance, uint gpu, uint first, int count, in float v)
        {
            fixed (float* v_ptr = &v) // RefInsteadOfPointerLayer
            {
                glInstance.MulticastViewportArrayvNVX(gpu, first, count, v_ptr);
            }
        }

        // MulticastScissorArrayvNVX overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void MulticastScissorArrayvNVX(this GL.NVXExtension glInstance, uint gpu, uint first, int count, ReadOnlySpan<int> v)
        {
            fixed (int* v_ptr = v) // SpanOrArrayLayer
            {
                glInstance.MulticastScissorArrayvNVX(gpu, first, count, v_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void MulticastScissorArrayvNVX(this GL.NVXExtension glInstance, uint gpu, uint first, int count, int[] v)
        {
            fixed (int* v_ptr = v) // SpanOrArrayLayer
            {
                glInstance.MulticastScissorArrayvNVX(gpu, first, count, v_ptr);
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void MulticastScissorArrayvNVX(this GL.NVXExtension glInstance, uint gpu, uint first, int count, in int v)
        {
            fixed (int* v_ptr = &v) // RefInsteadOfPointerLayer
            {
                glInstance.MulticastScissorArrayvNVX(gpu, first, count, v_ptr);
            }
        }

        // AsyncCopyBufferSubDataNVX overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe uint AsyncCopyBufferSubDataNVX(this GL.NVXExtension glInstance, int waitSemaphoreCount, ReadOnlySpan<uint> waitSemaphoreArray, ReadOnlySpan<ulong> fenceValueArray, uint readGpu, GLEnum writeGpuMask, BufferHandle readBuffer, BufferHandle writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size, int signalSemaphoreCount, ReadOnlySpan<uint> signalSemaphoreArray, ReadOnlySpan<ulong> signalValueArray)
        {
            uint returnValue;
            fixed (uint* waitSemaphoreArray_ptr = waitSemaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* fenceValueArray_ptr = fenceValueArray) // SpanOrArrayLayer
                {
                    fixed (uint* signalSemaphoreArray_ptr = signalSemaphoreArray) // SpanOrArrayLayer
                    {
                        fixed (ulong* signalValueArray_ptr = signalValueArray) // SpanOrArrayLayer
                        {
                            returnValue = glInstance.AsyncCopyBufferSubDataNVX(waitSemaphoreCount, waitSemaphoreArray_ptr, fenceValueArray_ptr, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray_ptr, signalValueArray_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe uint AsyncCopyBufferSubDataNVX(this GL.NVXExtension glInstance, int waitSemaphoreCount, uint[] waitSemaphoreArray, ulong[] fenceValueArray, uint readGpu, GLEnum writeGpuMask, BufferHandle readBuffer, BufferHandle writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size, int signalSemaphoreCount, uint[] signalSemaphoreArray, ulong[] signalValueArray)
        {
            uint returnValue;
            fixed (uint* waitSemaphoreArray_ptr = waitSemaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* fenceValueArray_ptr = fenceValueArray) // SpanOrArrayLayer
                {
                    fixed (uint* signalSemaphoreArray_ptr = signalSemaphoreArray) // SpanOrArrayLayer
                    {
                        fixed (ulong* signalValueArray_ptr = signalValueArray) // SpanOrArrayLayer
                        {
                            returnValue = glInstance.AsyncCopyBufferSubDataNVX(waitSemaphoreCount, waitSemaphoreArray_ptr, fenceValueArray_ptr, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray_ptr, signalValueArray_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe uint AsyncCopyBufferSubDataNVX(this GL.NVXExtension glInstance, int waitSemaphoreCount, in uint waitSemaphoreArray, in ulong fenceValueArray, uint readGpu, GLEnum writeGpuMask, BufferHandle readBuffer, BufferHandle writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size, int signalSemaphoreCount, in uint signalSemaphoreArray, in ulong signalValueArray)
        {
            uint returnValue;
            fixed (uint* waitSemaphoreArray_ptr = &waitSemaphoreArray) // RefInsteadOfPointerLayer
            fixed (ulong* fenceValueArray_ptr = &fenceValueArray) // RefInsteadOfPointerLayer
            fixed (uint* signalSemaphoreArray_ptr = &signalSemaphoreArray) // RefInsteadOfPointerLayer
            fixed (ulong* signalValueArray_ptr = &signalValueArray) // RefInsteadOfPointerLayer
            {
                returnValue = glInstance.AsyncCopyBufferSubDataNVX(waitSemaphoreCount, waitSemaphoreArray_ptr, fenceValueArray_ptr, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray_ptr, signalValueArray_ptr);
            }
            return returnValue;
        }

        // AsyncCopyImageSubDataNVX overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe uint AsyncCopyImageSubDataNVX(this GL.NVXExtension glInstance, int waitSemaphoreCount, ReadOnlySpan<uint> waitSemaphoreArray, ReadOnlySpan<ulong> waitValueArray, uint srcGpu, GLEnum dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, ReadOnlySpan<uint> signalSemaphoreArray, ReadOnlySpan<ulong> signalValueArray)
        {
            uint returnValue;
            fixed (uint* waitSemaphoreArray_ptr = waitSemaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* waitValueArray_ptr = waitValueArray) // SpanOrArrayLayer
                {
                    fixed (uint* signalSemaphoreArray_ptr = signalSemaphoreArray) // SpanOrArrayLayer
                    {
                        fixed (ulong* signalValueArray_ptr = signalValueArray) // SpanOrArrayLayer
                        {
                            returnValue = glInstance.AsyncCopyImageSubDataNVX(waitSemaphoreCount, waitSemaphoreArray_ptr, waitValueArray_ptr, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray_ptr, signalValueArray_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe uint AsyncCopyImageSubDataNVX(this GL.NVXExtension glInstance, int waitSemaphoreCount, uint[] waitSemaphoreArray, ulong[] waitValueArray, uint srcGpu, GLEnum dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint[] signalSemaphoreArray, ulong[] signalValueArray)
        {
            uint returnValue;
            fixed (uint* waitSemaphoreArray_ptr = waitSemaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* waitValueArray_ptr = waitValueArray) // SpanOrArrayLayer
                {
                    fixed (uint* signalSemaphoreArray_ptr = signalSemaphoreArray) // SpanOrArrayLayer
                    {
                        fixed (ulong* signalValueArray_ptr = signalValueArray) // SpanOrArrayLayer
                        {
                            returnValue = glInstance.AsyncCopyImageSubDataNVX(waitSemaphoreCount, waitSemaphoreArray_ptr, waitValueArray_ptr, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray_ptr, signalValueArray_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe uint AsyncCopyImageSubDataNVX(this GL.NVXExtension glInstance, int waitSemaphoreCount, in uint waitSemaphoreArray, in ulong waitValueArray, uint srcGpu, GLEnum dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, in uint signalSemaphoreArray, in ulong signalValueArray)
        {
            uint returnValue;
            fixed (uint* waitSemaphoreArray_ptr = &waitSemaphoreArray) // RefInsteadOfPointerLayer
            fixed (ulong* waitValueArray_ptr = &waitValueArray) // RefInsteadOfPointerLayer
            fixed (uint* signalSemaphoreArray_ptr = &signalSemaphoreArray) // RefInsteadOfPointerLayer
            fixed (ulong* signalValueArray_ptr = &signalValueArray) // RefInsteadOfPointerLayer
            {
                returnValue = glInstance.AsyncCopyImageSubDataNVX(waitSemaphoreCount, waitSemaphoreArray_ptr, waitValueArray_ptr, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray_ptr, signalValueArray_ptr);
            }
            return returnValue;
        }

        // SignalSemaphoreui64NVX overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void SignalSemaphoreui64NVX(this GL.NVXExtension glInstance, uint signalGpu, int fenceObjectCount, ReadOnlySpan<uint> semaphoreArray, ReadOnlySpan<ulong> fenceValueArray)
        {
            fixed (uint* semaphoreArray_ptr = semaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* fenceValueArray_ptr = fenceValueArray) // SpanOrArrayLayer
                {
                    glInstance.SignalSemaphoreui64NVX(signalGpu, fenceObjectCount, semaphoreArray_ptr, fenceValueArray_ptr);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void SignalSemaphoreui64NVX(this GL.NVXExtension glInstance, uint signalGpu, int fenceObjectCount, uint[] semaphoreArray, ulong[] fenceValueArray)
        {
            fixed (uint* semaphoreArray_ptr = semaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* fenceValueArray_ptr = fenceValueArray) // SpanOrArrayLayer
                {
                    glInstance.SignalSemaphoreui64NVX(signalGpu, fenceObjectCount, semaphoreArray_ptr, fenceValueArray_ptr);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void SignalSemaphoreui64NVX(this GL.NVXExtension glInstance, uint signalGpu, int fenceObjectCount, in uint semaphoreArray, in ulong fenceValueArray)
        {
            fixed (uint* semaphoreArray_ptr = &semaphoreArray) // RefInsteadOfPointerLayer
            fixed (ulong* fenceValueArray_ptr = &fenceValueArray) // RefInsteadOfPointerLayer
            {
                glInstance.SignalSemaphoreui64NVX(signalGpu, fenceObjectCount, semaphoreArray_ptr, fenceValueArray_ptr);
            }
        }

        // WaitSemaphoreui64NVX overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void WaitSemaphoreui64NVX(this GL.NVXExtension glInstance, uint waitGpu, int fenceObjectCount, ReadOnlySpan<uint> semaphoreArray, ReadOnlySpan<ulong> fenceValueArray)
        {
            fixed (uint* semaphoreArray_ptr = semaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* fenceValueArray_ptr = fenceValueArray) // SpanOrArrayLayer
                {
                    glInstance.WaitSemaphoreui64NVX(waitGpu, fenceObjectCount, semaphoreArray_ptr, fenceValueArray_ptr);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void WaitSemaphoreui64NVX(this GL.NVXExtension glInstance, uint waitGpu, int fenceObjectCount, uint[] semaphoreArray, ulong[] fenceValueArray)
        {
            fixed (uint* semaphoreArray_ptr = semaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* fenceValueArray_ptr = fenceValueArray) // SpanOrArrayLayer
                {
                    glInstance.WaitSemaphoreui64NVX(waitGpu, fenceObjectCount, semaphoreArray_ptr, fenceValueArray_ptr);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void WaitSemaphoreui64NVX(this GL.NVXExtension glInstance, uint waitGpu, int fenceObjectCount, in uint semaphoreArray, in ulong fenceValueArray)
        {
            fixed (uint* semaphoreArray_ptr = &semaphoreArray) // RefInsteadOfPointerLayer
            fixed (ulong* fenceValueArray_ptr = &fenceValueArray) // RefInsteadOfPointerLayer
            {
                glInstance.WaitSemaphoreui64NVX(waitGpu, fenceObjectCount, semaphoreArray_ptr, fenceValueArray_ptr);
            }
        }

        // ClientWaitSemaphoreui64NVX overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void ClientWaitSemaphoreui64NVX(this GL.NVXExtension glInstance, int fenceObjectCount, ReadOnlySpan<uint> semaphoreArray, ReadOnlySpan<ulong> fenceValueArray)
        {
            fixed (uint* semaphoreArray_ptr = semaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* fenceValueArray_ptr = fenceValueArray) // SpanOrArrayLayer
                {
                    glInstance.ClientWaitSemaphoreui64NVX(fenceObjectCount, semaphoreArray_ptr, fenceValueArray_ptr);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.SpanAndArrayOverloader
        public static unsafe void ClientWaitSemaphoreui64NVX(this GL.NVXExtension glInstance, int fenceObjectCount, uint[] semaphoreArray, ulong[] fenceValueArray)
        {
            fixed (uint* semaphoreArray_ptr = semaphoreArray) // SpanOrArrayLayer
            {
                fixed (ulong* fenceValueArray_ptr = fenceValueArray) // SpanOrArrayLayer
                {
                    glInstance.ClientWaitSemaphoreui64NVX(fenceObjectCount, semaphoreArray_ptr, fenceValueArray_ptr);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void ClientWaitSemaphoreui64NVX(this GL.NVXExtension glInstance, int fenceObjectCount, in uint semaphoreArray, in ulong fenceValueArray)
        {
            fixed (uint* semaphoreArray_ptr = &semaphoreArray) // RefInsteadOfPointerLayer
            fixed (ulong* fenceValueArray_ptr = &fenceValueArray) // RefInsteadOfPointerLayer
            {
                glInstance.ClientWaitSemaphoreui64NVX(fenceObjectCount, semaphoreArray_ptr, fenceValueArray_ptr);
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}