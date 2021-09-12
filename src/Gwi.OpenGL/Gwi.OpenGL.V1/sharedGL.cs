using System;

namespace Gwi.OpenGL.GL4
{
    public sealed unsafe partial class GL : BaseGL
    {
        private readonly VTable vtable;

        public GL(INativeLib lib) : base(lib) => vtable = new VTable(lib);
    }
}

namespace Gwi.OpenGL.GLCompat
{
    public sealed unsafe partial class GL : BaseGL
    {
        private readonly VTable vtable;

        public GL(INativeLib lib) : base(lib) => vtable = new VTable(lib);
    }
}

namespace Gwi.OpenGL.GLES1
{
    public sealed unsafe partial class GL : BaseGL
    {
        private readonly VTable vtable;

        public GL(INativeLib lib) : base(lib) => vtable = new VTable(lib);
    }
}

namespace Gwi.OpenGL.GLES3
{
    public sealed unsafe partial class GL : BaseGL
    {
        private readonly VTable vtable;

        public GL(INativeLib lib) : base(lib) => vtable = new VTable(lib);
    }
}

namespace Gwi.OpenGL
{
    public abstract class BaseGL
    {
        protected BaseGL(INativeLib lib) => Lib = lib;
        protected INativeLib Lib { get; }
    }

    public static class GLLoader
    {
        public static class BindingsContext
        {
            public static nint GetProcAddress(string procedureName) => IntPtr.Zero;
        }
    }

    public abstract class BaseVTable
    {
        protected BaseVTable(INativeLib lib) => Lib = lib;

        protected INativeLib Lib { get; }
    }

    
}

namespace Gwi
{
    using System.Text;

    public enum NativeStringEncoding
    {
        BStr = 19,
        LPStr = 20,
        LPTStr = 22,
        LPUTF8Str = 48,
        LPWStr = 21,
        Ansi = 20,
        Auto = 22,
        Uni = 21,
        UTF8 = 48
    }

    public static class Marshaller
    {
        // Silk.NET
        public static string? PtrToString(nint input, NativeStringEncoding encoding = NativeStringEncoding.LPStr)
        {
            unsafe static string AnsiToString(nint ptr) => new string((sbyte*)ptr);
            unsafe static string BStrToString(nint ptr) => new string((char*)ptr, 0, (int)(*(uint*)(ptr - 4) / 2u));            
            unsafe static string WideToString(nint ptr) => new string((char*)ptr);
            unsafe static string Utf8PtrToString(nint ptr)
            {
                var span = new Span<byte>((void*)ptr, int.MaxValue);
                span = span.Slice(0, span.IndexOf<byte>(0));
                fixed (byte* bytes = span)
                    return Encoding.UTF8.GetString(bytes, span.Length);
            }

            return input == 0 ? null : encoding switch
            {
                NativeStringEncoding.BStr => BStrToString(input),
                NativeStringEncoding.LPStr => AnsiToString(input),
                NativeStringEncoding.LPTStr => Utf8PtrToString(input),
                NativeStringEncoding.LPUTF8Str => Utf8PtrToString(input),
                NativeStringEncoding.LPWStr => WideToString(input),
                _ => throw new ArgumentException($"Invalid string encoding: {encoding}", nameof(encoding))
            };
        }
    }

    public interface INativeLib
    {
        nint GetProcAddress(string procedureName);
    }
}
