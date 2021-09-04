// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private AMDExtension? _AMD;
        public AMDExtension AMD => _AMD ??= new AMDExtension(this);

        public sealed unsafe partial class AMDExtension
        {
            private readonly VTable vtable;

            internal AMDExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void DebugMessageEnableAMD(GLEnum category, DebugSeverity severity, int count, uint* ids, byte enabled) => ((delegate* unmanaged[Cdecl]<GLEnum, DebugSeverity, int, uint*, byte, void>)vtable.glDebugMessageEnableAMD)(category, severity, count, ids, enabled);
            public void DebugMessageInsertAMD(GLEnum category, DebugSeverity severity, uint id, int length, byte* buf) => ((delegate* unmanaged[Cdecl]<GLEnum, DebugSeverity, uint, int, byte*, void>)vtable.glDebugMessageInsertAMD)(category, severity, id, length, buf);
            public void DebugMessageCallbackAMD(IntPtr callback, void* userParam) => ((delegate* unmanaged[Cdecl]<IntPtr, void*, void>)vtable.glDebugMessageCallbackAMD)(callback, userParam);
            public uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, uint* severities, uint* ids, int* lengths, byte* message) => ((delegate* unmanaged[Cdecl]<uint, int, GLEnum*, uint*, uint*, int*, byte*, uint>)vtable.glGetDebugMessageLogAMD)(count, bufSize, categories, severities, ids, lengths, message);
            public void BlendFuncIndexedAMD(uint buf, GLEnum src, GLEnum dst) => ((delegate* unmanaged[Cdecl]<uint, GLEnum, GLEnum, void>)vtable.glBlendFuncIndexedAMD)(buf, src, dst);
            public void BlendFuncSeparateIndexedAMD(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => ((delegate* unmanaged[Cdecl]<uint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)vtable.glBlendFuncSeparateIndexedAMD)(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            public void BlendEquationIndexedAMD(uint buf, BlendEquationModeEXT mode) => ((delegate* unmanaged[Cdecl]<uint, BlendEquationModeEXT, void>)vtable.glBlendEquationIndexedAMD)(buf, mode);
            public void BlendEquationSeparateIndexedAMD(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => ((delegate* unmanaged[Cdecl]<uint, BlendEquationModeEXT, BlendEquationModeEXT, void>)vtable.glBlendEquationSeparateIndexedAMD)(buf, modeRGB, modeAlpha);
            public void RenderbufferStorageMultisampleAdvancedAMD(RenderbufferTarget target, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<RenderbufferTarget, int, int, InternalFormat, int, int, void>)vtable.glRenderbufferStorageMultisampleAdvancedAMD)(target, samples, storageSamples, internalformat, width, height);
            public void NamedRenderbufferStorageMultisampleAdvancedAMD(RenderbufferHandle renderbuffer, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<RenderbufferHandle, int, int, InternalFormat, int, int, void>)vtable.glNamedRenderbufferStorageMultisampleAdvancedAMD)(renderbuffer, samples, storageSamples, internalformat, width, height);
            public void FramebufferSamplePositionsfvAMD(FramebufferTarget target, uint numsamples, uint pixelindex, float* values) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, uint, uint, float*, void>)vtable.glFramebufferSamplePositionsfvAMD)(target, numsamples, pixelindex, values);
            public void NamedFramebufferSamplePositionsfvAMD(FramebufferHandle framebuffer, uint numsamples, uint pixelindex, float* values) => ((delegate* unmanaged[Cdecl]<FramebufferHandle, uint, uint, float*, void>)vtable.glNamedFramebufferSamplePositionsfvAMD)(framebuffer, numsamples, pixelindex, values);
            public void GetFramebufferParameterfvAMD(FramebufferTarget target, FramebufferAttachmentParameterName pname, uint numsamples, uint pixelindex, int size, float* values) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, uint, uint, int, float*, void>)vtable.glGetFramebufferParameterfvAMD)(target, pname, numsamples, pixelindex, size, values);
            public void GetNamedFramebufferParameterfvAMD(FramebufferHandle framebuffer, GLEnum pname, uint numsamples, uint pixelindex, int size, float* values) => ((delegate* unmanaged[Cdecl]<FramebufferHandle, GLEnum, uint, uint, int, float*, void>)vtable.glGetNamedFramebufferParameterfvAMD)(framebuffer, pname, numsamples, pixelindex, size, values);
            public void Uniform1i64NV(int location, long x) => ((delegate* unmanaged[Cdecl]<int, long, void>)vtable.glUniform1i64NV)(location, x);
            public void Uniform2i64NV(int location, long x, long y) => ((delegate* unmanaged[Cdecl]<int, long, long, void>)vtable.glUniform2i64NV)(location, x, y);
            public void Uniform3i64NV(int location, long x, long y, long z) => ((delegate* unmanaged[Cdecl]<int, long, long, long, void>)vtable.glUniform3i64NV)(location, x, y, z);
            public void Uniform4i64NV(int location, long x, long y, long z, long w) => ((delegate* unmanaged[Cdecl]<int, long, long, long, long, void>)vtable.glUniform4i64NV)(location, x, y, z, w);
            public void Uniform1i64vNV(int location, int count, long* value) => ((delegate* unmanaged[Cdecl]<int, int, long*, void>)vtable.glUniform1i64vNV)(location, count, value);
            public void Uniform2i64vNV(int location, int count, long* value) => ((delegate* unmanaged[Cdecl]<int, int, long*, void>)vtable.glUniform2i64vNV)(location, count, value);
            public void Uniform3i64vNV(int location, int count, long* value) => ((delegate* unmanaged[Cdecl]<int, int, long*, void>)vtable.glUniform3i64vNV)(location, count, value);
            public void Uniform4i64vNV(int location, int count, long* value) => ((delegate* unmanaged[Cdecl]<int, int, long*, void>)vtable.glUniform4i64vNV)(location, count, value);
            public void Uniform1ui64NV(int location, ulong x) => ((delegate* unmanaged[Cdecl]<int, ulong, void>)vtable.glUniform1ui64NV)(location, x);
            public void Uniform2ui64NV(int location, ulong x, ulong y) => ((delegate* unmanaged[Cdecl]<int, ulong, ulong, void>)vtable.glUniform2ui64NV)(location, x, y);
            public void Uniform3ui64NV(int location, ulong x, ulong y, ulong z) => ((delegate* unmanaged[Cdecl]<int, ulong, ulong, ulong, void>)vtable.glUniform3ui64NV)(location, x, y, z);
            public void Uniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w) => ((delegate* unmanaged[Cdecl]<int, ulong, ulong, ulong, ulong, void>)vtable.glUniform4ui64NV)(location, x, y, z, w);
            public void Uniform1ui64vNV(int location, int count, ulong* value) => ((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)vtable.glUniform1ui64vNV)(location, count, value);
            public void Uniform2ui64vNV(int location, int count, ulong* value) => ((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)vtable.glUniform2ui64vNV)(location, count, value);
            public void Uniform3ui64vNV(int location, int count, ulong* value) => ((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)vtable.glUniform3ui64vNV)(location, count, value);
            public void Uniform4ui64vNV(int location, int count, ulong* value) => ((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)vtable.glUniform4ui64vNV)(location, count, value);
            public void GetUniformi64vNV(ProgramHandle program, int location, long* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, long*, void>)vtable.glGetUniformi64vNV)(program, location, parameters);
            public void GetUniformui64vNV(ProgramHandle program, int location, ulong* parameters) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, ulong*, void>)vtable.glGetUniformui64vNV)(program, location, parameters);
            public void ProgramUniform1i64NV(ProgramHandle program, int location, long x) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, long, void>)vtable.glProgramUniform1i64NV)(program, location, x);
            public void ProgramUniform2i64NV(ProgramHandle program, int location, long x, long y) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, long, long, void>)vtable.glProgramUniform2i64NV)(program, location, x, y);
            public void ProgramUniform3i64NV(ProgramHandle program, int location, long x, long y, long z) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, long, long, long, void>)vtable.glProgramUniform3i64NV)(program, location, x, y, z);
            public void ProgramUniform4i64NV(ProgramHandle program, int location, long x, long y, long z, long w) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, long, long, long, long, void>)vtable.glProgramUniform4i64NV)(program, location, x, y, z, w);
            public void ProgramUniform1i64vNV(ProgramHandle program, int location, int count, long* value) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, long*, void>)vtable.glProgramUniform1i64vNV)(program, location, count, value);
            public void ProgramUniform2i64vNV(ProgramHandle program, int location, int count, long* value) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, long*, void>)vtable.glProgramUniform2i64vNV)(program, location, count, value);
            public void ProgramUniform3i64vNV(ProgramHandle program, int location, int count, long* value) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, long*, void>)vtable.glProgramUniform3i64vNV)(program, location, count, value);
            public void ProgramUniform4i64vNV(ProgramHandle program, int location, int count, long* value) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, long*, void>)vtable.glProgramUniform4i64vNV)(program, location, count, value);
            public void ProgramUniform1ui64NV(ProgramHandle program, int location, ulong x) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, ulong, void>)vtable.glProgramUniform1ui64NV)(program, location, x);
            public void ProgramUniform2ui64NV(ProgramHandle program, int location, ulong x, ulong y) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, ulong, ulong, void>)vtable.glProgramUniform2ui64NV)(program, location, x, y);
            public void ProgramUniform3ui64NV(ProgramHandle program, int location, ulong x, ulong y, ulong z) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, ulong, ulong, ulong, void>)vtable.glProgramUniform3ui64NV)(program, location, x, y, z);
            public void ProgramUniform4ui64NV(ProgramHandle program, int location, ulong x, ulong y, ulong z, ulong w) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, ulong, ulong, ulong, ulong, void>)vtable.glProgramUniform4ui64NV)(program, location, x, y, z, w);
            public void ProgramUniform1ui64vNV(ProgramHandle program, int location, int count, ulong* value) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, ulong*, void>)vtable.glProgramUniform1ui64vNV)(program, location, count, value);
            public void ProgramUniform2ui64vNV(ProgramHandle program, int location, int count, ulong* value) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, ulong*, void>)vtable.glProgramUniform2ui64vNV)(program, location, count, value);
            public void ProgramUniform3ui64vNV(ProgramHandle program, int location, int count, ulong* value) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, ulong*, void>)vtable.glProgramUniform3ui64vNV)(program, location, count, value);
            public void ProgramUniform4ui64vNV(ProgramHandle program, int location, int count, ulong* value) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int, ulong*, void>)vtable.glProgramUniform4ui64vNV)(program, location, count, value);
            public void VertexAttribParameteriAMD(uint index, GLEnum pname, int param) => ((delegate* unmanaged[Cdecl]<uint, GLEnum, int, void>)vtable.glVertexAttribParameteriAMD)(index, pname, param);
            public void MultiDrawArraysIndirectAMD(PrimitiveType mode, void* indirect, int primcount, int stride) => ((delegate* unmanaged[Cdecl]<PrimitiveType, void*, int, int, void>)vtable.glMultiDrawArraysIndirectAMD)(mode, indirect, primcount, stride);
            public void MultiDrawElementsIndirectAMD(PrimitiveType mode, DrawElementsType type, void* indirect, int primcount, int stride) => ((delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, int, int, void>)vtable.glMultiDrawElementsIndirectAMD)(mode, type, indirect, primcount, stride);
            public void GenNamesAMD(GLEnum identifier, uint num, uint* names) => ((delegate* unmanaged[Cdecl]<GLEnum, uint, uint*, void>)vtable.glGenNamesAMD)(identifier, num, names);
            public void DeleteNamesAMD(GLEnum identifier, uint num, uint* names) => ((delegate* unmanaged[Cdecl]<GLEnum, uint, uint*, void>)vtable.glDeleteNamesAMD)(identifier, num, names);
            public byte IsNameAMD(GLEnum identifier, uint name) => ((delegate* unmanaged[Cdecl]<GLEnum, uint, byte>)vtable.glIsNameAMD)(identifier, name);
            public void QueryObjectParameteruiAMD(QueryTarget target, QueryHandle id, GLEnum pname, uint param) => ((delegate* unmanaged[Cdecl]<QueryTarget, QueryHandle, GLEnum, uint, void>)vtable.glQueryObjectParameteruiAMD)(target, id, pname, param);
            public void GetPerfMonitorGroupsAMD(int* numGroups, int groupsSize, uint* groups) => ((delegate* unmanaged[Cdecl]<int*, int, uint*, void>)vtable.glGetPerfMonitorGroupsAMD)(numGroups, groupsSize, groups);
            public void GetPerfMonitorCountersAMD(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters) => ((delegate* unmanaged[Cdecl]<uint, int*, int*, int, uint*, void>)vtable.glGetPerfMonitorCountersAMD)(group, numCounters, maxActiveCounters, counterSize, counters);
            public void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, byte* groupString) => ((delegate* unmanaged[Cdecl]<uint, int, int*, byte*, void>)vtable.glGetPerfMonitorGroupStringAMD)(group, bufSize, length, groupString);
            public void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, byte* counterString) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int*, byte*, void>)vtable.glGetPerfMonitorCounterStringAMD)(group, counter, bufSize, length, counterString);
            public void GetPerfMonitorCounterInfoAMD(uint group, uint counter, GLEnum pname, void* data) => ((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, void*, void>)vtable.glGetPerfMonitorCounterInfoAMD)(group, counter, pname, data);
            public void GenPerfMonitorsAMD(int n, uint* monitors) => ((delegate* unmanaged[Cdecl]<int, uint*, void>)vtable.glGenPerfMonitorsAMD)(n, monitors);
            public void DeletePerfMonitorsAMD(int n, uint* monitors) => ((delegate* unmanaged[Cdecl]<int, uint*, void>)vtable.glDeletePerfMonitorsAMD)(n, monitors);
            public void SelectPerfMonitorCountersAMD(uint monitor, byte enable, uint group, int numCounters, uint* counterList) => ((delegate* unmanaged[Cdecl]<uint, byte, uint, int, uint*, void>)vtable.glSelectPerfMonitorCountersAMD)(monitor, enable, group, numCounters, counterList);
            public void BeginPerfMonitorAMD(uint monitor) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glBeginPerfMonitorAMD)(monitor);
            public void EndPerfMonitorAMD(uint monitor) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glEndPerfMonitorAMD)(monitor);
            public void GetPerfMonitorCounterDataAMD(uint monitor, GLEnum pname, int dataSize, uint* data, int* bytesWritten) => ((delegate* unmanaged[Cdecl]<uint, GLEnum, int, uint*, int*, void>)vtable.glGetPerfMonitorCounterDataAMD)(monitor, pname, dataSize, data, bytesWritten);
            public void SetMultisamplefvAMD(GLEnum pname, uint index, float* val) => ((delegate* unmanaged[Cdecl]<GLEnum, uint, float*, void>)vtable.glSetMultisamplefvAMD)(pname, index, val);
            public void TexStorageSparseAMD(TextureTarget target, SizedInternalFormat internalFormat, int width, int height, int depth, int layers, TextureStorageMaskAMD flags) => ((delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, int, int, int, int, TextureStorageMaskAMD, void>)vtable.glTexStorageSparseAMD)(target, internalFormat, width, height, depth, layers, flags);
            public void TextureStorageSparseAMD(TextureHandle texture, GLEnum target, SizedInternalFormat internalFormat, int width, int height, int depth, int layers, TextureStorageMaskAMD flags) => ((delegate* unmanaged[Cdecl]<TextureHandle, GLEnum, SizedInternalFormat, int, int, int, int, TextureStorageMaskAMD, void>)vtable.glTextureStorageSparseAMD)(texture, target, internalFormat, width, height, depth, layers, flags);
            public void StencilOpValueAMD(StencilFaceDirection face, uint value) => ((delegate* unmanaged[Cdecl]<StencilFaceDirection, uint, void>)vtable.glStencilOpValueAMD)(face, value);
            public void TessellationFactorAMD(float factor) => ((delegate* unmanaged[Cdecl]<float, void>)vtable.glTessellationFactorAMD)(factor);
            public void TessellationModeAMD(GLEnum mode) => ((delegate* unmanaged[Cdecl]<GLEnum, void>)vtable.glTessellationModeAMD)(mode);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
