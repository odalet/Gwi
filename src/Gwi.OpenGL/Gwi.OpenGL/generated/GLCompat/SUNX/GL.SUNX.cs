// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private SUNXExtension? _SUNX;
        public SUNXExtension SUNX => _SUNX ??= new SUNXExtension(this);

        public sealed unsafe partial class SUNXExtension
        {
            private readonly VTable vtable;

            internal SUNXExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void FinishTextureSUNX() => ((delegate* unmanaged[Cdecl]<void>)vtable.glFinishTextureSUNX)();
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
