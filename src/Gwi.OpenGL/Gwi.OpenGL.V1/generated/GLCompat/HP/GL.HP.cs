// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private HPExtension? _HP;
        public HPExtension HP => _HP ??= new HPExtension(this);

        public sealed unsafe partial class HPExtension
        {
            private readonly VTable vtable;

            internal HPExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void ImageTransformParameteriHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int param) => ((delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, int, void>)vtable.glImageTransformParameteriHP)(target, pname, param);
            public void ImageTransformParameterfHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float param) => ((delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, float, void>)vtable.glImageTransformParameterfHP)(target, pname, param);
            public void ImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int* parameters) => ((delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, int*, void>)vtable.glImageTransformParameterivHP)(target, pname, parameters);
            public void ImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float* parameters) => ((delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, float*, void>)vtable.glImageTransformParameterfvHP)(target, pname, parameters);
            public void GetImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int* parameters) => ((delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, int*, void>)vtable.glGetImageTransformParameterivHP)(target, pname, parameters);
            public void GetImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float* parameters) => ((delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, float*, void>)vtable.glGetImageTransformParameterfvHP)(target, pname, parameters);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
