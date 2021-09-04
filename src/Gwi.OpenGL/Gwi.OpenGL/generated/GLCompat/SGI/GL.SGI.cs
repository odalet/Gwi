// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private SGIExtension? _SGI;
        public SGIExtension SGI => _SGI ??= new SGIExtension(this);

        public sealed unsafe partial class SGIExtension
        {
            private readonly VTable vtable;

            internal SGIExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void ColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table) => ((delegate* unmanaged[Cdecl]<ColorTableTargetSGI, InternalFormat, int, PixelFormat, PixelType, void*, void>)vtable.glColorTableSGI)(target, internalformat, width, format, type, table);
            public void ColorTableParameterfvSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float* parameters) => ((delegate* unmanaged[Cdecl]<ColorTableTargetSGI, ColorTableParameterPNameSGI, float*, void>)vtable.glColorTableParameterfvSGI)(target, pname, parameters);
            public void ColorTableParameterivSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, int* parameters) => ((delegate* unmanaged[Cdecl]<ColorTableTargetSGI, ColorTableParameterPNameSGI, int*, void>)vtable.glColorTableParameterivSGI)(target, pname, parameters);
            public void CopyColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, int x, int y, int width) => ((delegate* unmanaged[Cdecl]<ColorTableTargetSGI, InternalFormat, int, int, int, void>)vtable.glCopyColorTableSGI)(target, internalformat, x, y, width);
            public void GetColorTableSGI(ColorTableTargetSGI target, PixelFormat format, PixelType type, void* table) => ((delegate* unmanaged[Cdecl]<ColorTableTargetSGI, PixelFormat, PixelType, void*, void>)vtable.glGetColorTableSGI)(target, format, type, table);
            public void GetColorTableParameterfvSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, float* parameters) => ((delegate* unmanaged[Cdecl]<ColorTableTargetSGI, GetColorTableParameterPNameSGI, float*, void>)vtable.glGetColorTableParameterfvSGI)(target, pname, parameters);
            public void GetColorTableParameterivSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, int* parameters) => ((delegate* unmanaged[Cdecl]<ColorTableTargetSGI, GetColorTableParameterPNameSGI, int*, void>)vtable.glGetColorTableParameterivSGI)(target, pname, parameters);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
