using System;

namespace Gwi.OpenGL.GL4
{
    public delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam);
    public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcNV();
}

namespace Gwi.OpenGL.GLCompat
{
    public delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam);
    public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcNV();
}

namespace Gwi.OpenGL.GLES1
{
    public unsafe delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcNV();
}

namespace Gwi.OpenGL.GLES3
{
    public unsafe delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcNV();
}
