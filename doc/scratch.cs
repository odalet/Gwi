[NativeName("Name", "ColorBuffer")]
public enum ColorBuffer
{
	[NativeName("Name", "GL_NONE")]
	None = 0,
	[NativeName("Name", "GL_FRONT_LEFT")]
	FrontLeft = 0x400,

    // ...
}

public class GL : NativeAPI
{
    private sealed class GeneratedVTable : IVTable, IDisposable
    {
        private INativeContext _ctx;

        private IntPtr _glNamedFramebufferReadBuffer;
        private IntPtr _glPixelStoref;
        private IntPtr _glPolygonOffsetClamp;

        [System.Runtime.CompilerServices.NativeInteger]
        public IntPtr GlNamedFramebufferReadBuffer
        {
            [return: System.Runtime.CompilerServices.NativeInteger]
            get
            {
                return (_glNamedFramebufferReadBuffer != (IntPtr)0) ? _glNamedFramebufferReadBuffer : (_glNamedFramebufferReadBuffer = _ctx.GetProcAddress("glNamedFramebufferReadBuffer"));
            }
        }

        [System.Runtime.CompilerServices.NativeInteger]
        public IntPtr GlPixelStoref
        {
            [return: System.Runtime.CompilerServices.NativeInteger]
            get
            {
                return (_glPixelStoref != (IntPtr)0) ? _glPixelStoref : (_glPixelStoref = _ctx.GetProcAddress("glPixelStoref"));
            }
        }

        [System.Runtime.CompilerServices.NativeInteger]
        public IntPtr GlPolygonOffsetClamp
        {
            [return: System.Runtime.CompilerServices.NativeInteger]
            get
            {
                return (_glPolygonOffsetClamp != (IntPtr)0) ? _glPolygonOffsetClamp : (_glPolygonOffsetClamp = _ctx.GetProcAddress("glPolygonOffsetClamp"));
            }
        }
    }

    // [NativeApi(EntryPoint = "glPolygonOffsetClamp")]
    // public void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp)
    // {
    // 	throw null;
    // }

    [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
    public unsafe void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer src)
    {
        ((System.UIntPtr/*delegate* unmanaged[Cdecl]<uint, ColorBuffer, void>*/)(void*)(long)(base.CurrentVTable as GeneratedVTable).GlNamedFramebufferReadBuffer)(framebuffer, src);
    }

    [NativeApi(EntryPoint = "glPolygonOffsetClamp")]
    public unsafe void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp)
    {
        ((UIntPtr/*delegate* unmanaged[Cdecl]<float, float, float, void>*/)(void*)(long)(base.CurrentVTable as GeneratedVTable).GlPolygonOffsetClamp)(factor, units, clamp);
    }

    [NativeApi(EntryPoint = "glPixelStoref")]
    public unsafe void PixelStore([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param)
    {
        ((System.UIntPtr/*delegate* unmanaged[Cdecl]<GLEnum, float, void>*/)(void*)(long)(base.CurrentVTable as GeneratedVTable).GlPixelStoref)(pname, param);
    }
}

// ------------------------------------------------------------------------------------------------
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/function-pointers
// https://github.com/dotnet/csharplang/issues/191
// https://devblogs.microsoft.com/dotnet/c-9-0-on-the-record/
// https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callconvsuppressgctransition?view=net-6.0
public interface INativeContext : IDisposable
{
    nint GetProcAddress(string proc, int? slot = default);    
    bool TryGetProcAddress(string proc, out nint addr, int? slot = default);
}

public struct GlfwNativeWindow : INativeWindow
{
    [DllImport("user32", EntryPoint = "GetDC")]
    private static extern nint Win32GetDC(nint hwnd);

    public unsafe GlfwNativeWindow(Glfw api, WindowHandle* window) : this()
    {
        Kind |= NativeWindowFlags.Glfw;
        Glfw = (nint)window;
        if (api.Context.TryGetProcAddress("glfwGetWin32Window", out var getHwnd))
        {
            var hwnd = ((delegate* unmanaged[Cdecl]<WindowHandle*, nint>)getHwnd)(window);
            Kind |= NativeWindowFlags.Win32;
            Win32 = (hwnd, Win32GetDC(hwnd), GetWindowLongPtr(hwnd, GwlpHInstance));
            return;
        }

        // ...
    }
}