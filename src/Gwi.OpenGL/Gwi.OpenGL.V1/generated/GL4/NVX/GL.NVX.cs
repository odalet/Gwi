// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GL4
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private NVXExtension? _NVX;
        public NVXExtension NVX => _NVX ??= new NVXExtension(this);

        public sealed unsafe partial class NVXExtension
        {
            private readonly VTable vtable;

            internal NVXExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void BeginConditionalRenderNVX(uint id) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glBeginConditionalRenderNVX)(id);
            public void EndConditionalRenderNVX() => ((delegate* unmanaged[Cdecl]<void>)vtable.glEndConditionalRenderNVX)();
            public void LGPUNamedBufferSubDataNVX(GLEnum gpuMask, BufferHandle buffer, IntPtr offset, nint size, void* data) => ((delegate* unmanaged[Cdecl]<GLEnum, BufferHandle, IntPtr, nint, void*, void>)vtable.glLGPUNamedBufferSubDataNVX)(gpuMask, buffer, offset, size, data);
            public void LGPUCopyImageSubDataNVX(uint sourceGpu, GLEnum destinationGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srxY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) => ((delegate* unmanaged[Cdecl]<uint, GLEnum, uint, GLEnum, int, int, int, int, uint, GLEnum, int, int, int, int, int, int, int, void>)vtable.glLGPUCopyImageSubDataNVX)(sourceGpu, destinationGpuMask, srcName, srcTarget, srcLevel, srcX, srxY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            public void LGPUInterlockNVX() => ((delegate* unmanaged[Cdecl]<void>)vtable.glLGPUInterlockNVX)();
            public void UploadGpuMaskNVX(GLEnum mask) => ((delegate* unmanaged[Cdecl]<GLEnum, void>)vtable.glUploadGpuMaskNVX)(mask);
            public void MulticastViewportArrayvNVX(uint gpu, uint first, int count, float* v) => ((delegate* unmanaged[Cdecl]<uint, uint, int, float*, void>)vtable.glMulticastViewportArrayvNVX)(gpu, first, count, v);
            public void MulticastViewportPositionWScaleNVX(uint gpu, uint index, float xcoeff, float ycoeff) => ((delegate* unmanaged[Cdecl]<uint, uint, float, float, void>)vtable.glMulticastViewportPositionWScaleNVX)(gpu, index, xcoeff, ycoeff);
            public void MulticastScissorArrayvNVX(uint gpu, uint first, int count, int* v) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int*, void>)vtable.glMulticastScissorArrayvNVX)(gpu, first, count, v);
            public uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, GLEnum writeGpuMask, BufferHandle readBuffer, BufferHandle writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray) => ((delegate* unmanaged[Cdecl]<int, uint*, ulong*, uint, GLEnum, BufferHandle, BufferHandle, IntPtr, IntPtr, nint, int, uint*, ulong*, uint>)vtable.glAsyncCopyBufferSubDataNVX)(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
            public uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, GLEnum dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray) => ((delegate* unmanaged[Cdecl]<int, uint*, ulong*, uint, GLEnum, uint, GLEnum, int, int, int, int, uint, GLEnum, int, int, int, int, int, int, int, int, uint*, ulong*, uint>)vtable.glAsyncCopyImageSubDataNVX)(waitSemaphoreCount, waitSemaphoreArray, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
            public uint CreateProgressFenceNVX() => ((delegate* unmanaged[Cdecl]<uint>)vtable.glCreateProgressFenceNVX)();
            public void SignalSemaphoreui64NVX(uint signalGpu, int fenceObjectCount, uint* semaphoreArray, ulong* fenceValueArray) => ((delegate* unmanaged[Cdecl]<uint, int, uint*, ulong*, void>)vtable.glSignalSemaphoreui64NVX)(signalGpu, fenceObjectCount, semaphoreArray, fenceValueArray);
            public void WaitSemaphoreui64NVX(uint waitGpu, int fenceObjectCount, uint* semaphoreArray, ulong* fenceValueArray) => ((delegate* unmanaged[Cdecl]<uint, int, uint*, ulong*, void>)vtable.glWaitSemaphoreui64NVX)(waitGpu, fenceObjectCount, semaphoreArray, fenceValueArray);
            public void ClientWaitSemaphoreui64NVX(int fenceObjectCount, uint* semaphoreArray, ulong* fenceValueArray) => ((delegate* unmanaged[Cdecl]<int, uint*, ulong*, void>)vtable.glClientWaitSemaphoreui64NVX)(fenceObjectCount, semaphoreArray, fenceValueArray);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
