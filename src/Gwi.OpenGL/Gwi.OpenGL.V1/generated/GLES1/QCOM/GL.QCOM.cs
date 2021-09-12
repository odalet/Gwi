// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES1
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private QCOMExtension? _QCOM;
        public QCOMExtension QCOM => _QCOM ??= new QCOMExtension(this);

        public sealed unsafe partial class QCOMExtension
        {
            private readonly VTable vtable;

            internal QCOMExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void GetDriverControlsQCOM(int* num, int size, uint* driverControls) => ((delegate* unmanaged[Cdecl]<int*, int, uint*, void>)vtable.glGetDriverControlsQCOM)(num, size, driverControls);
            public void GetDriverControlStringQCOM(uint driverControl, int bufSize, int* length, byte* driverControlString) => ((delegate* unmanaged[Cdecl]<uint, int, int*, byte*, void>)vtable.glGetDriverControlStringQCOM)(driverControl, bufSize, length, driverControlString);
            public void EnableDriverControlQCOM(uint driverControl) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glEnableDriverControlQCOM)(driverControl);
            public void DisableDriverControlQCOM(uint driverControl) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glDisableDriverControlQCOM)(driverControl);
            public void ExtGetTexturesQCOM(TextureHandle* textures, int maxTextures, int* numTextures) => ((delegate* unmanaged[Cdecl]<TextureHandle*, int, int*, void>)vtable.glExtGetTexturesQCOM)(textures, maxTextures, numTextures);
            public void ExtGetBuffersQCOM(BufferHandle* buffers, int maxBuffers, int* numBuffers) => ((delegate* unmanaged[Cdecl]<BufferHandle*, int, int*, void>)vtable.glExtGetBuffersQCOM)(buffers, maxBuffers, numBuffers);
            public void ExtGetRenderbuffersQCOM(RenderbufferHandle* renderbuffers, int maxRenderbuffers, int* numRenderbuffers) => ((delegate* unmanaged[Cdecl]<RenderbufferHandle*, int, int*, void>)vtable.glExtGetRenderbuffersQCOM)(renderbuffers, maxRenderbuffers, numRenderbuffers);
            public void ExtGetFramebuffersQCOM(FramebufferHandle* framebuffers, int maxFramebuffers, int* numFramebuffers) => ((delegate* unmanaged[Cdecl]<FramebufferHandle*, int, int*, void>)vtable.glExtGetFramebuffersQCOM)(framebuffers, maxFramebuffers, numFramebuffers);
            public void ExtGetTexLevelParameterivQCOM(TextureHandle texture, GLEnum face, int level, GLEnum pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureHandle, GLEnum, int, GLEnum, int*, void>)vtable.glExtGetTexLevelParameterivQCOM)(texture, face, level, pname, parameters);
            public void ExtTexObjectStateOverrideiQCOM(GLEnum target, GLEnum pname, int param) => ((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, int, void>)vtable.glExtTexObjectStateOverrideiQCOM)(target, pname, param);
            public void ExtGetTexSubImageQCOM(GLEnum target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels) => ((delegate* unmanaged[Cdecl]<GLEnum, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)vtable.glExtGetTexSubImageQCOM)(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
            public void ExtGetBufferPointervQCOM(GLEnum target, void** parameters) => ((delegate* unmanaged[Cdecl]<GLEnum, void**, void>)vtable.glExtGetBufferPointervQCOM)(target, parameters);
            public void ExtGetShadersQCOM(ShaderHandle* shaders, int maxShaders, int* numShaders) => ((delegate* unmanaged[Cdecl]<ShaderHandle*, int, int*, void>)vtable.glExtGetShadersQCOM)(shaders, maxShaders, numShaders);
            public void ExtGetProgramsQCOM(ProgramHandle* programs, int maxPrograms, int* numPrograms) => ((delegate* unmanaged[Cdecl]<ProgramHandle*, int, int*, void>)vtable.glExtGetProgramsQCOM)(programs, maxPrograms, numPrograms);
            public byte ExtIsProgramBinaryQCOM(ProgramHandle program) => ((delegate* unmanaged[Cdecl]<ProgramHandle, byte>)vtable.glExtIsProgramBinaryQCOM)(program);
            public void ExtGetProgramBinarySourceQCOM(ProgramHandle program, ShaderType shadertype, byte* source, int* length) => ((delegate* unmanaged[Cdecl]<ProgramHandle, ShaderType, byte*, int*, void>)vtable.glExtGetProgramBinarySourceQCOM)(program, shadertype, source, length);
            public void StartTilingQCOM(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => ((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, BufferBitQCOM, void>)vtable.glStartTilingQCOM)(x, y, width, height, preserveMask);
            public void EndTilingQCOM(BufferBitQCOM preserveMask) => ((delegate* unmanaged[Cdecl]<BufferBitQCOM, void>)vtable.glEndTilingQCOM)(preserveMask);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
