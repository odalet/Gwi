// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES3
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private OESExtension? _OES;
        public OESExtension OES => _OES ??= new OESExtension(this);

        public sealed unsafe partial class OESExtension
        {
            private readonly VTable vtable;

            internal OESExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void EGLImageTargetTexture2DOES(GLEnum target, void* image) => ((delegate* unmanaged[Cdecl]<GLEnum, void*, void>)vtable.glEGLImageTargetTexture2DOES)(target, image);
            public void EGLImageTargetRenderbufferStorageOES(GLEnum target, void* image) => ((delegate* unmanaged[Cdecl]<GLEnum, void*, void>)vtable.glEGLImageTargetRenderbufferStorageOES)(target, image);
            public void CopyImageSubDataOES(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => ((delegate* unmanaged[Cdecl]<uint, CopyBufferSubDataTarget, int, int, int, int, uint, CopyBufferSubDataTarget, int, int, int, int, int, int, int, void>)vtable.glCopyImageSubDataOES)(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            public void EnableiOES(EnableCap target, uint index) => ((delegate* unmanaged[Cdecl]<EnableCap, uint, void>)vtable.glEnableiOES)(target, index);
            public void DisableiOES(EnableCap target, uint index) => ((delegate* unmanaged[Cdecl]<EnableCap, uint, void>)vtable.glDisableiOES)(target, index);
            public void BlendEquationiOES(uint buf, BlendEquationModeEXT mode) => ((delegate* unmanaged[Cdecl]<uint, BlendEquationModeEXT, void>)vtable.glBlendEquationiOES)(buf, mode);
            public void BlendEquationSeparateiOES(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => ((delegate* unmanaged[Cdecl]<uint, BlendEquationModeEXT, BlendEquationModeEXT, void>)vtable.glBlendEquationSeparateiOES)(buf, modeRGB, modeAlpha);
            public void BlendFunciOES(uint buf, BlendingFactor src, BlendingFactor dst) => ((delegate* unmanaged[Cdecl]<uint, BlendingFactor, BlendingFactor, void>)vtable.glBlendFunciOES)(buf, src, dst);
            public void BlendFuncSeparateiOES(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => ((delegate* unmanaged[Cdecl]<uint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)vtable.glBlendFuncSeparateiOES)(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            public void ColorMaskiOES(uint index, byte r, byte g, byte b, byte a) => ((delegate* unmanaged[Cdecl]<uint, byte, byte, byte, byte, void>)vtable.glColorMaskiOES)(index, r, g, b, a);
            public byte IsEnablediOES(EnableCap target, uint index) => ((delegate* unmanaged[Cdecl]<EnableCap, uint, byte>)vtable.glIsEnablediOES)(target, index);
            public void DrawElementsBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int, DrawElementsType, void*, int, void>)vtable.glDrawElementsBaseVertexOES)(mode, count, type, indices, basevertex);
            public void DrawRangeElementsBaseVertexOES(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => ((delegate* unmanaged[Cdecl]<PrimitiveType, uint, uint, int, DrawElementsType, void*, int, void>)vtable.glDrawRangeElementsBaseVertexOES)(mode, start, end, count, type, indices, basevertex);
            public void DrawElementsInstancedBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int, DrawElementsType, void*, int, int, void>)vtable.glDrawElementsInstancedBaseVertexOES)(mode, count, type, indices, instancecount, basevertex);
            public void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int*, DrawElementsType, void**, int, int*, void>)vtable.glMultiDrawElementsBaseVertexEXT)(mode, count, type, indices, drawcount, basevertex);
            public void FramebufferTextureOES(FramebufferTarget target, FramebufferAttachment attachment, TextureHandle texture, int level) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureHandle, int, void>)vtable.glFramebufferTextureOES)(target, attachment, texture, level);
            public void GetProgramBinaryOES(ProgramHandle program, int bufSize, int* length, GLEnum* binaryFormat, void* binary) => ((delegate* unmanaged[Cdecl]<ProgramHandle, int, int*, GLEnum*, void*, void>)vtable.glGetProgramBinaryOES)(program, bufSize, length, binaryFormat, binary);
            public void ProgramBinaryOES(ProgramHandle program, GLEnum binaryFormat, void* binary, int length) => ((delegate* unmanaged[Cdecl]<ProgramHandle, GLEnum, void*, int, void>)vtable.glProgramBinaryOES)(program, binaryFormat, binary, length);
            public void* MapBufferOES(BufferTargetARB target, BufferAccessARB access) => ((delegate* unmanaged[Cdecl]<BufferTargetARB, BufferAccessARB, void*>)vtable.glMapBufferOES)(target, access);
            public byte UnmapBufferOES(GLEnum target) => ((delegate* unmanaged[Cdecl]<GLEnum, byte>)vtable.glUnmapBufferOES)(target);
            public void GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => ((delegate* unmanaged[Cdecl]<BufferTargetARB, BufferPointerNameARB, void**, void>)vtable.glGetBufferPointervOES)(target, pname, parameters);
            public void PrimitiveBoundingBoxOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, float, float, void>)vtable.glPrimitiveBoundingBoxOES)(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            public void MinSampleShadingOES(float value) => ((delegate* unmanaged[Cdecl]<float, void>)vtable.glMinSampleShadingOES)(value);
            public void PatchParameteriOES(PatchParameterName pname, int value) => ((delegate* unmanaged[Cdecl]<PatchParameterName, int, void>)vtable.glPatchParameteriOES)(pname, value);
            public void TexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, InternalFormat, int, int, int, int, PixelFormat, PixelType, void*, void>)vtable.glTexImage3DOES)(target, level, internalformat, width, height, depth, border, format, type, pixels);
            public void TexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)vtable.glTexSubImage3DOES)(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
            public void CopyTexSubImage3DOES(GLEnum target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => ((delegate* unmanaged[Cdecl]<GLEnum, int, int, int, int, int, int, int, int, void>)vtable.glCopyTexSubImage3DOES)(target, level, xoffset, yoffset, zoffset, x, y, width, height);
            public void CompressedTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, InternalFormat, int, int, int, int, int, void*, void>)vtable.glCompressedTexImage3DOES)(target, level, internalformat, width, height, depth, border, imageSize, data);
            public void CompressedTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*, void>)vtable.glCompressedTexSubImage3DOES)(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
            public void FramebufferTexture3DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int zoffset) => ((delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)vtable.glFramebufferTexture3DOES)(target, attachment, textarget, texture, level, zoffset);
            public void TexParameterIivOES(TextureTarget target, TextureParameterName pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, int*, void>)vtable.glTexParameterIivOES)(target, pname, parameters);
            public void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, uint* parameters) => ((delegate* unmanaged[Cdecl]<TextureTarget, TextureParameterName, uint*, void>)vtable.glTexParameterIuivOES)(target, pname, parameters);
            public void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, int*, void>)vtable.glGetTexParameterIivOES)(target, pname, parameters);
            public void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, uint* parameters) => ((delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, uint*, void>)vtable.glGetTexParameterIuivOES)(target, pname, parameters);
            public void SamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int* param) => ((delegate* unmanaged[Cdecl]<SamplerHandle, SamplerParameterI, int*, void>)vtable.glSamplerParameterIivOES)(sampler, pname, param);
            public void SamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint* param) => ((delegate* unmanaged[Cdecl]<SamplerHandle, SamplerParameterI, uint*, void>)vtable.glSamplerParameterIuivOES)(sampler, pname, param);
            public void GetSamplerParameterIivOES(SamplerHandle sampler, SamplerParameterI pname, int* parameters) => ((delegate* unmanaged[Cdecl]<SamplerHandle, SamplerParameterI, int*, void>)vtable.glGetSamplerParameterIivOES)(sampler, pname, parameters);
            public void GetSamplerParameterIuivOES(SamplerHandle sampler, SamplerParameterI pname, uint* parameters) => ((delegate* unmanaged[Cdecl]<SamplerHandle, SamplerParameterI, uint*, void>)vtable.glGetSamplerParameterIuivOES)(sampler, pname, parameters);
            public void TexBufferOES(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer) => ((delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, BufferHandle, void>)vtable.glTexBufferOES)(target, internalformat, buffer);
            public void TexBufferRangeOES(TextureTarget target, SizedInternalFormat internalformat, BufferHandle buffer, IntPtr offset, nint size) => ((delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, BufferHandle, IntPtr, nint, void>)vtable.glTexBufferRangeOES)(target, internalformat, buffer, offset, size);
            public void TexStorage3DMultisampleOES(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, byte fixedsamplelocations) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, SizedInternalFormat, int, int, int, byte, void>)vtable.glTexStorage3DMultisampleOES)(target, samples, internalformat, width, height, depth, fixedsamplelocations);
            public void TextureViewOES(TextureHandle texture, TextureTarget target, TextureHandle origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => ((delegate* unmanaged[Cdecl]<TextureHandle, TextureTarget, TextureHandle, SizedInternalFormat, uint, uint, uint, uint, void>)vtable.glTextureViewOES)(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
            public void BindVertexArrayOES(VertexArrayHandle array) => ((delegate* unmanaged[Cdecl]<VertexArrayHandle, void>)vtable.glBindVertexArrayOES)(array);
            public void DeleteVertexArraysOES(int n, VertexArrayHandle* arrays) => ((delegate* unmanaged[Cdecl]<int, VertexArrayHandle*, void>)vtable.glDeleteVertexArraysOES)(n, arrays);
            public void GenVertexArraysOES(int n, VertexArrayHandle* arrays) => ((delegate* unmanaged[Cdecl]<int, VertexArrayHandle*, void>)vtable.glGenVertexArraysOES)(n, arrays);
            public byte IsVertexArrayOES(VertexArrayHandle array) => ((delegate* unmanaged[Cdecl]<VertexArrayHandle, byte>)vtable.glIsVertexArrayOES)(array);
            public void ViewportArrayvOES(uint first, int count, float* v) => ((delegate* unmanaged[Cdecl]<uint, int, float*, void>)vtable.glViewportArrayvOES)(first, count, v);
            public void ViewportIndexedfOES(uint index, float x, float y, float w, float h) => ((delegate* unmanaged[Cdecl]<uint, float, float, float, float, void>)vtable.glViewportIndexedfOES)(index, x, y, w, h);
            public void ViewportIndexedfvOES(uint index, float* v) => ((delegate* unmanaged[Cdecl]<uint, float*, void>)vtable.glViewportIndexedfvOES)(index, v);
            public void ScissorArrayvOES(uint first, int count, int* v) => ((delegate* unmanaged[Cdecl]<uint, int, int*, void>)vtable.glScissorArrayvOES)(first, count, v);
            public void ScissorIndexedOES(uint index, int left, int bottom, int width, int height) => ((delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)vtable.glScissorIndexedOES)(index, left, bottom, width, height);
            public void ScissorIndexedvOES(uint index, int* v) => ((delegate* unmanaged[Cdecl]<uint, int*, void>)vtable.glScissorIndexedvOES)(index, v);
            public void DepthRangeArrayfvOES(uint first, int count, float* v) => ((delegate* unmanaged[Cdecl]<uint, int, float*, void>)vtable.glDepthRangeArrayfvOES)(first, count, v);
            public void DepthRangeIndexedfOES(uint index, float n, float f) => ((delegate* unmanaged[Cdecl]<uint, float, float, void>)vtable.glDepthRangeIndexedfOES)(index, n, f);
            public void GetFloati_vOES(GetPName target, uint index, float* data) => ((delegate* unmanaged[Cdecl]<GetPName, uint, float*, void>)vtable.glGetFloati_vOES)(target, index, data);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
