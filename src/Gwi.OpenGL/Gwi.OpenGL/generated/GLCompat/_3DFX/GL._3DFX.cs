// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private _3DFXExtension? __3DFX;
        public _3DFXExtension _3DFX => __3DFX ??= new _3DFXExtension(this);

        public sealed unsafe partial class _3DFXExtension
        {
            private readonly VTable vtable;

            internal _3DFXExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void TbufferMask3DFX(uint mask) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glTbufferMask3DFX)(mask);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
