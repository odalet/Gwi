// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private KHRExtension? _KHR;
        public KHRExtension KHR => _KHR ??= new KHRExtension(this);

        public sealed unsafe partial class KHRExtension
        {
            private readonly VTable vtable;

            internal KHRExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void BlendBarrierKHR() => ((delegate* unmanaged[Cdecl]<void>)vtable.glBlendBarrierKHR)();
            public void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => ((delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)vtable.glDebugMessageControl)(source, type, severity, count, ids, enabled);
            public void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => ((delegate* unmanaged[Cdecl]<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)vtable.glDebugMessageInsert)(source, type, id, severity, length, buf);
            public void DebugMessageCallback(IntPtr callback, void* userParam) => ((delegate* unmanaged[Cdecl]<IntPtr, void*, void>)vtable.glDebugMessageCallback)(callback, userParam);
            public uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => ((delegate* unmanaged[Cdecl]<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)vtable.glGetDebugMessageLog)(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            public void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => ((delegate* unmanaged[Cdecl]<DebugSource, uint, int, byte*, void>)vtable.glPushDebugGroup)(source, id, length, message);
            public void PopDebugGroup() => ((delegate* unmanaged[Cdecl]<void>)vtable.glPopDebugGroup)();
            public void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => ((delegate* unmanaged[Cdecl]<ObjectIdentifier, uint, int, byte*, void>)vtable.glObjectLabel)(identifier, name, length, label);
            public void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => ((delegate* unmanaged[Cdecl]<ObjectIdentifier, uint, int, int*, byte*, void>)vtable.glGetObjectLabel)(identifier, name, bufSize, length, label);
            public void ObjectPtrLabel(void* ptr, int length, byte* label) => ((delegate* unmanaged[Cdecl]<void*, int, byte*, void>)vtable.glObjectPtrLabel)(ptr, length, label);
            public void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => ((delegate* unmanaged[Cdecl]<void*, int, int*, byte*, void>)vtable.glGetObjectPtrLabel)(ptr, bufSize, length, label);
            public void GetPointerv(GetPointervPName pname, void** parameters) => ((delegate* unmanaged[Cdecl]<GetPointervPName, void**, void>)vtable.glGetPointerv)(pname, parameters);
            public void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => ((delegate* unmanaged[Cdecl]<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)vtable.glDebugMessageControlKHR)(source, type, severity, count, ids, enabled);
            public void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => ((delegate* unmanaged[Cdecl]<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)vtable.glDebugMessageInsertKHR)(source, type, id, severity, length, buf);
            public void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => ((delegate* unmanaged[Cdecl]<IntPtr, void*, void>)vtable.glDebugMessageCallbackKHR)(callback, userParam);
            public uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => ((delegate* unmanaged[Cdecl]<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)vtable.glGetDebugMessageLogKHR)(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            public void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => ((delegate* unmanaged[Cdecl]<DebugSource, uint, int, byte*, void>)vtable.glPushDebugGroupKHR)(source, id, length, message);
            public void PopDebugGroupKHR() => ((delegate* unmanaged[Cdecl]<void>)vtable.glPopDebugGroupKHR)();
            public void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => ((delegate* unmanaged[Cdecl]<ObjectIdentifier, uint, int, byte*, void>)vtable.glObjectLabelKHR)(identifier, name, length, label);
            public void GetObjectLabelKHR(GLEnum identifier, uint name, int bufSize, int* length, byte* label) => ((delegate* unmanaged[Cdecl]<GLEnum, uint, int, int*, byte*, void>)vtable.glGetObjectLabelKHR)(identifier, name, bufSize, length, label);
            public void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => ((delegate* unmanaged[Cdecl]<void*, int, byte*, void>)vtable.glObjectPtrLabelKHR)(ptr, length, label);
            public void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => ((delegate* unmanaged[Cdecl]<void*, int, int*, byte*, void>)vtable.glGetObjectPtrLabelKHR)(ptr, bufSize, length, label);
            public void GetPointervKHR(GLEnum pname, void** parameters) => ((delegate* unmanaged[Cdecl]<GLEnum, void**, void>)vtable.glGetPointervKHR)(pname, parameters);
            public GraphicsResetStatus GetGraphicsResetStatus() => ((delegate* unmanaged[Cdecl]<GraphicsResetStatus>)vtable.glGetGraphicsResetStatus)();
            public void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => ((delegate* unmanaged[Cdecl]<int, int, int, int, PixelFormat, PixelType, int, void*, void>)vtable.glReadnPixels)(x, y, width, height, format, type, bufSize, data);
            public void GetnUniformfv(ProgramHandle program, int location, int bufSize, float* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, float*, void>)vtable.glGetnUniformfv)(program, location, bufSize, parameters);
            public void GetnUniformiv(ProgramHandle program, int location, int bufSize, int* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, int*, void>)vtable.glGetnUniformiv)(program, location, bufSize, parameters);
            public void GetnUniformuiv(ProgramHandle program, int location, int bufSize, uint* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, uint*, void>)vtable.glGetnUniformuiv)(program, location, bufSize, parameters);
            public GraphicsResetStatus GetGraphicsResetStatusKHR() => ((delegate* unmanaged[Cdecl]<GraphicsResetStatus>)vtable.glGetGraphicsResetStatusKHR)();
            public void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => ((delegate* unmanaged[Cdecl]<int, int, int, int, PixelFormat, PixelType, int, void*, void>)vtable.glReadnPixelsKHR)(x, y, width, height, format, type, bufSize, data);
            public void GetnUniformfvKHR(ProgramHandle program, int location, int bufSize, float* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, float*, void>)vtable.glGetnUniformfvKHR)(program, location, bufSize, parameters);
            public void GetnUniformivKHR(ProgramHandle program, int location, int bufSize, int* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, int*, void>)vtable.glGetnUniformivKHR)(program, location, bufSize, parameters);
            public void GetnUniformuivKHR(ProgramHandle program, int location, int bufSize, uint* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, uint*, void>)vtable.glGetnUniformuivKHR)(program, location, bufSize, parameters);
            public void MaxShaderCompilerThreadsKHR(uint count) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glMaxShaderCompilerThreadsKHR)(count);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
