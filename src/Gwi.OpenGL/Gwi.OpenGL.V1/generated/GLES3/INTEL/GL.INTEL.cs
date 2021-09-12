// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES3
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private INTELExtension? _INTEL;
        public INTELExtension INTEL => _INTEL ??= new INTELExtension(this);

        public sealed unsafe partial class INTELExtension
        {
            private readonly VTable vtable;

            internal INTELExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void ApplyFramebufferAttachmentCMAAINTEL() => ((delegate* unmanaged[Cdecl]<void>)vtable.glApplyFramebufferAttachmentCMAAINTEL)();
            public void BeginPerfQueryINTEL(uint queryHandle) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glBeginPerfQueryINTEL)(queryHandle);
            public void CreatePerfQueryINTEL(uint queryId, uint* queryHandle) => ((delegate* unmanaged[Cdecl]<uint, uint*, void>)vtable.glCreatePerfQueryINTEL)(queryId, queryHandle);
            public void DeletePerfQueryINTEL(uint queryHandle) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glDeletePerfQueryINTEL)(queryHandle);
            public void EndPerfQueryINTEL(uint queryHandle) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glEndPerfQueryINTEL)(queryHandle);
            public void GetFirstPerfQueryIdINTEL(uint* queryId) => ((delegate* unmanaged[Cdecl]<uint*, void>)vtable.glGetFirstPerfQueryIdINTEL)(queryId);
            public void GetNextPerfQueryIdINTEL(uint queryId, uint* nextQueryId) => ((delegate* unmanaged[Cdecl]<uint, uint*, void>)vtable.glGetNextPerfQueryIdINTEL)(queryId, nextQueryId);
            public void GetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue) => ((delegate* unmanaged[Cdecl]<uint, uint, uint, byte*, uint, byte*, uint*, uint*, uint*, uint*, ulong*, void>)vtable.glGetPerfCounterInfoINTEL)(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
            public void GetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten) => ((delegate* unmanaged[Cdecl]<uint, uint, int, void*, uint*, void>)vtable.glGetPerfQueryDataINTEL)(queryHandle, flags, dataSize, data, bytesWritten);
            public void GetPerfQueryIdByNameINTEL(byte* queryName, uint* queryId) => ((delegate* unmanaged[Cdecl]<byte*, uint*, void>)vtable.glGetPerfQueryIdByNameINTEL)(queryName, queryId);
            public void GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, byte* queryName, uint* dataSize, uint* noCounters, uint* noInstances, uint* capsMask) => ((delegate* unmanaged[Cdecl]<uint, uint, byte*, uint*, uint*, uint*, uint*, void>)vtable.glGetPerfQueryInfoINTEL)(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
