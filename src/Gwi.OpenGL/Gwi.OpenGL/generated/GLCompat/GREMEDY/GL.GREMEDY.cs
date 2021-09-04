// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private GREMEDYExtension? _GREMEDY;
        public GREMEDYExtension GREMEDY => _GREMEDY ??= new GREMEDYExtension(this);

        public sealed unsafe partial class GREMEDYExtension
        {
            private readonly VTable vtable;

            internal GREMEDYExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void FrameTerminatorGREMEDY() => ((delegate* unmanaged[Cdecl]<void>)vtable.glFrameTerminatorGREMEDY)();
            public void StringMarkerGREMEDY(int len, void* str) => ((delegate* unmanaged[Cdecl]<int, void*, void>)vtable.glStringMarkerGREMEDY)(len, str);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
