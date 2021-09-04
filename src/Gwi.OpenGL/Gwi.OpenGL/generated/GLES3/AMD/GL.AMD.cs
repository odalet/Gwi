// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES3
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

            public void RenderbufferStorageMultisampleAdvancedAMD(RenderbufferTarget target, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<RenderbufferTarget, int, int, InternalFormat, int, int, void>)vtable.glRenderbufferStorageMultisampleAdvancedAMD)(target, samples, storageSamples, internalformat, width, height);
            public void NamedRenderbufferStorageMultisampleAdvancedAMD(RenderbufferHandle renderbuffer, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => ((delegate* unmanaged[Cdecl]<RenderbufferHandle, int, int, InternalFormat, int, int, void>)vtable.glNamedRenderbufferStorageMultisampleAdvancedAMD)(renderbuffer, samples, storageSamples, internalformat, width, height);
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
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
