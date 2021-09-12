// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GL4
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private PGIExtension? _PGI;
        public PGIExtension PGI => _PGI ??= new PGIExtension(this);

        public sealed unsafe partial class PGIExtension
        {
            private readonly VTable vtable;

            internal PGIExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void HintPGI(HintTargetPGI target, int mode) => ((delegate* unmanaged[Cdecl]<HintTargetPGI, int, void>)vtable.glHintPGI)(target, mode);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
