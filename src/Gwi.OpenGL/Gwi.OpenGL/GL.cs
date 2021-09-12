using System;

namespace Gwi.OpenGL
{
    public abstract class BaseLibrary
    {
        private readonly Func<string, nint> getProcAddress;
        protected BaseLibrary(Func<string, nint> getProcAddressFunc) => getProcAddress = getProcAddressFunc;
        protected nint GetProcAddress(string name) => getProcAddress(name);
    }

    public sealed partial class GL : BaseLibrary
    {
        public unsafe partial interface IGLApi { }

        private sealed unsafe partial class GLApi : IGLApi
        {
            private sealed unsafe partial class VTable
            {
                private readonly Func<string, nint> getProcAddress;

                public VTable(Func<string, nint> getProcAddressFunc) => getProcAddress = getProcAddressFunc;

                private nint GetProcAddress(string name) => getProcAddress(name);
            }

            private readonly VTable vtable;

            public GLApi(Func<string, nint> getProcAddressFunc) => vtable = new VTable(getProcAddressFunc);
        }

        public GL(Func<string, nint> getProcAddressFunc) : base(getProcAddressFunc) =>
            Api = new GLApi(getProcAddressFunc);

        public IGLApi Api { get; }
    }
}
