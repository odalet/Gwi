// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private APPLEExtension? _APPLE;
        public APPLEExtension APPLE => _APPLE ??= new APPLEExtension(this);

        public sealed unsafe partial class APPLEExtension
        {
            private readonly VTable vtable;

            internal APPLEExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void ElementPointerAPPLE(ElementPointerTypeATI type, void* pointer) => ((delegate* unmanaged[Cdecl]<ElementPointerTypeATI, void*, void>)vtable.glElementPointerAPPLE)(type, pointer);
            public void DrawElementArrayAPPLE(PrimitiveType mode, int first, int count) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int, int, void>)vtable.glDrawElementArrayAPPLE)(mode, first, count);
            public void DrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int first, int count) => ((delegate* unmanaged[Cdecl]<PrimitiveType, uint, uint, int, int, void>)vtable.glDrawRangeElementArrayAPPLE)(mode, start, end, first, count);
            public void MultiDrawElementArrayAPPLE(PrimitiveType mode, int* first, int* count, int primcount) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int*, int*, int, void>)vtable.glMultiDrawElementArrayAPPLE)(mode, first, count, primcount);
            public void MultiDrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int* first, int* count, int primcount) => ((delegate* unmanaged[Cdecl]<PrimitiveType, uint, uint, int*, int*, int, void>)vtable.glMultiDrawRangeElementArrayAPPLE)(mode, start, end, first, count, primcount);
            public void GenFencesAPPLE(int n, uint* fences) => ((delegate* unmanaged[Cdecl]<int, uint*, void>)vtable.glGenFencesAPPLE)(n, fences);
            public void DeleteFencesAPPLE(int n, uint* fences) => ((delegate* unmanaged[Cdecl]<int, uint*, void>)vtable.glDeleteFencesAPPLE)(n, fences);
            public void SetFenceAPPLE(uint fence) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glSetFenceAPPLE)(fence);
            public byte IsFenceAPPLE(uint fence) => ((delegate* unmanaged[Cdecl]<uint, byte>)vtable.glIsFenceAPPLE)(fence);
            public byte TestFenceAPPLE(uint fence) => ((delegate* unmanaged[Cdecl]<uint, byte>)vtable.glTestFenceAPPLE)(fence);
            public void FinishFenceAPPLE(uint fence) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glFinishFenceAPPLE)(fence);
            public byte TestObjectAPPLE(ObjectTypeAPPLE obj, uint name) => ((delegate* unmanaged[Cdecl]<ObjectTypeAPPLE, uint, byte>)vtable.glTestObjectAPPLE)(obj, name);
            public void FinishObjectAPPLE(ObjectTypeAPPLE obj, int name) => ((delegate* unmanaged[Cdecl]<ObjectTypeAPPLE, int, void>)vtable.glFinishObjectAPPLE)(obj, name);
            public void BufferParameteriAPPLE(GLEnum target, GLEnum pname, int param) => ((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, int, void>)vtable.glBufferParameteriAPPLE)(target, pname, param);
            public void FlushMappedBufferRangeAPPLE(BufferTargetARB target, IntPtr offset, nint size) => ((delegate* unmanaged[Cdecl]<BufferTargetARB, IntPtr, nint, void>)vtable.glFlushMappedBufferRangeAPPLE)(target, offset, size);
            public GLEnum ObjectPurgeableAPPLE(GLEnum objectType, uint name, GLEnum option) => ((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)vtable.glObjectPurgeableAPPLE)(objectType, name, option);
            public GLEnum ObjectUnpurgeableAPPLE(GLEnum objectType, uint name, GLEnum option) => ((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)vtable.glObjectUnpurgeableAPPLE)(objectType, name, option);
            public void GetObjectParameterivAPPLE(GLEnum objectType, uint name, GLEnum pname, int* parameters) => ((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, int*, void>)vtable.glGetObjectParameterivAPPLE)(objectType, name, pname, parameters);
            public void TextureRangeAPPLE(GLEnum target, int length, void* pointer) => ((delegate* unmanaged[Cdecl]<GLEnum, int, void*, void>)vtable.glTextureRangeAPPLE)(target, length, pointer);
            public void GetTexParameterPointervAPPLE(GLEnum target, GLEnum pname, void** parameters) => ((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, void**, void>)vtable.glGetTexParameterPointervAPPLE)(target, pname, parameters);
            public void BindVertexArrayAPPLE(VertexArrayHandle array) => ((delegate* unmanaged[Cdecl]<VertexArrayHandle, void>)vtable.glBindVertexArrayAPPLE)(array);
            public void DeleteVertexArraysAPPLE(int n, VertexArrayHandle* arrays) => ((delegate* unmanaged[Cdecl]<int, VertexArrayHandle*, void>)vtable.glDeleteVertexArraysAPPLE)(n, arrays);
            public void GenVertexArraysAPPLE(int n, VertexArrayHandle* arrays) => ((delegate* unmanaged[Cdecl]<int, VertexArrayHandle*, void>)vtable.glGenVertexArraysAPPLE)(n, arrays);
            public byte IsVertexArrayAPPLE(VertexArrayHandle array) => ((delegate* unmanaged[Cdecl]<VertexArrayHandle, byte>)vtable.glIsVertexArrayAPPLE)(array);
            public void VertexArrayRangeAPPLE(int length, void* pointer) => ((delegate* unmanaged[Cdecl]<int, void*, void>)vtable.glVertexArrayRangeAPPLE)(length, pointer);
            public void FlushVertexArrayRangeAPPLE(int length, void* pointer) => ((delegate* unmanaged[Cdecl]<int, void*, void>)vtable.glFlushVertexArrayRangeAPPLE)(length, pointer);
            public void VertexArrayParameteriAPPLE(VertexArrayPNameAPPLE pname, int param) => ((delegate* unmanaged[Cdecl]<VertexArrayPNameAPPLE, int, void>)vtable.glVertexArrayParameteriAPPLE)(pname, param);
            public void EnableVertexAttribAPPLE(uint index, GLEnum pname) => ((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)vtable.glEnableVertexAttribAPPLE)(index, pname);
            public void DisableVertexAttribAPPLE(uint index, GLEnum pname) => ((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)vtable.glDisableVertexAttribAPPLE)(index, pname);
            public byte IsVertexAttribEnabledAPPLE(uint index, GLEnum pname) => ((delegate* unmanaged[Cdecl]<uint, GLEnum, byte>)vtable.glIsVertexAttribEnabledAPPLE)(index, pname);
            public void MapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double* points) => ((delegate* unmanaged[Cdecl]<uint, uint, double, double, int, int, double*, void>)vtable.glMapVertexAttrib1dAPPLE)(index, size, u1, u2, stride, order, points);
            public void MapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float* points) => ((delegate* unmanaged[Cdecl]<uint, uint, float, float, int, int, float*, void>)vtable.glMapVertexAttrib1fAPPLE)(index, size, u1, u2, stride, order, points);
            public void MapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points) => ((delegate* unmanaged[Cdecl]<uint, uint, double, double, int, int, double, double, int, int, double*, void>)vtable.glMapVertexAttrib2dAPPLE)(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            public void MapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points) => ((delegate* unmanaged[Cdecl]<uint, uint, float, float, int, int, float, float, int, int, float*, void>)vtable.glMapVertexAttrib2fAPPLE)(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
