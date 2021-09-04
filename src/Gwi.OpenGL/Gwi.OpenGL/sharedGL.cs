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
    public interface INativeLib
    {
        nint GetProcAddress(string procedureName);
    }
}
