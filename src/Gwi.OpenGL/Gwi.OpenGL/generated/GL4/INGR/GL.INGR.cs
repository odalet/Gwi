// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GL4
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private INGRExtension? _INGR;
        public INGRExtension INGR => _INGR ??= new INGRExtension(this);

        public sealed unsafe partial class INGRExtension
        {
            private readonly VTable vtable;

            internal INGRExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void BlendFuncSeparateINGR(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => ((delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)vtable.glBlendFuncSeparateINGR)(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
