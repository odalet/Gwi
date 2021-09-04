// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES3
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

            public void CopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int, void>)vtable.glCopyTextureLevelsAPPLE)(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            public void RenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<RenderbufferTarget, int, InternalFormat, int, int, void>)vtable.glRenderbufferStorageMultisampleAPPLE)(target, samples, internalformat, width, height);
            public void ResolveMultisampleFramebufferAPPLE() => ((delegate* unmanaged[Cdecl]<void>)vtable.glResolveMultisampleFramebufferAPPLE)();
            public GLSync FenceSyncAPPLE(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync)((delegate* unmanaged[Cdecl]<SyncCondition, SyncBehaviorFlags, IntPtr>)vtable.glFenceSyncAPPLE)(condition, flags);
            public byte IsSyncAPPLE(GLSync sync) => ((delegate* unmanaged[Cdecl]<GLSync, byte>)vtable.glIsSyncAPPLE)(sync);
            public void DeleteSyncAPPLE(GLSync sync) => ((delegate* unmanaged[Cdecl]<GLSync, void>)vtable.glDeleteSyncAPPLE)(sync);
            public SyncStatus ClientWaitSyncAPPLE(GLSync sync, SyncObjectMask flags, ulong timeout) => ((delegate* unmanaged[Cdecl]<GLSync, SyncObjectMask, ulong, SyncStatus>)vtable.glClientWaitSyncAPPLE)(sync, flags, timeout);
            public void WaitSyncAPPLE(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => ((delegate* unmanaged[Cdecl]<GLSync, SyncBehaviorFlags, ulong, void>)vtable.glWaitSyncAPPLE)(sync, flags, timeout);
            public void GetInteger64vAPPLE(GetPName pname, long* parameters) => ((delegate* unmanaged[Cdecl]<GetPName, long*, void>)vtable.glGetInteger64vAPPLE)(pname, parameters);
            public void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => ((delegate* unmanaged[Cdecl]<GLSync, SyncParameterName, int, int*, int*, void>)vtable.glGetSyncivAPPLE)(sync, pname, count, length, values);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
