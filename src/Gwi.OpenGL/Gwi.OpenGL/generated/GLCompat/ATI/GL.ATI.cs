// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private ATIExtension? _ATI;
        public ATIExtension ATI => _ATI ??= new ATIExtension(this);

        public sealed unsafe partial class ATIExtension
        {
            private readonly VTable vtable;

            internal ATIExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void DrawBuffersATI(int n, DrawBufferMode* bufs) => ((delegate* unmanaged[Cdecl]<int, DrawBufferMode*, void>)vtable.glDrawBuffersATI)(n, bufs);
            public void ElementPointerATI(ElementPointerTypeATI type, void* pointer) => ((delegate* unmanaged[Cdecl]<ElementPointerTypeATI, void*, void>)vtable.glElementPointerATI)(type, pointer);
            public void DrawElementArrayATI(PrimitiveType mode, int count) => ((delegate* unmanaged[Cdecl]<PrimitiveType, int, void>)vtable.glDrawElementArrayATI)(mode, count);
            public void DrawRangeElementArrayATI(PrimitiveType mode, uint start, uint end, int count) => ((delegate* unmanaged[Cdecl]<PrimitiveType, uint, uint, int, void>)vtable.glDrawRangeElementArrayATI)(mode, start, end, count);
            public void TexBumpParameterivATI(TexBumpParameterATI pname, int* param) => ((delegate* unmanaged[Cdecl]<TexBumpParameterATI, int*, void>)vtable.glTexBumpParameterivATI)(pname, param);
            public void TexBumpParameterfvATI(TexBumpParameterATI pname, float* param) => ((delegate* unmanaged[Cdecl]<TexBumpParameterATI, float*, void>)vtable.glTexBumpParameterfvATI)(pname, param);
            public void GetTexBumpParameterivATI(GetTexBumpParameterATI pname, int* param) => ((delegate* unmanaged[Cdecl]<GetTexBumpParameterATI, int*, void>)vtable.glGetTexBumpParameterivATI)(pname, param);
            public void GetTexBumpParameterfvATI(GetTexBumpParameterATI pname, float* param) => ((delegate* unmanaged[Cdecl]<GetTexBumpParameterATI, float*, void>)vtable.glGetTexBumpParameterfvATI)(pname, param);
            public uint GenFragmentShadersATI(uint range) => ((delegate* unmanaged[Cdecl]<uint, uint>)vtable.glGenFragmentShadersATI)(range);
            public void BindFragmentShaderATI(uint id) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glBindFragmentShaderATI)(id);
            public void DeleteFragmentShaderATI(uint id) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glDeleteFragmentShaderATI)(id);
            public void BeginFragmentShaderATI() => ((delegate* unmanaged[Cdecl]<void>)vtable.glBeginFragmentShaderATI)();
            public void EndFragmentShaderATI() => ((delegate* unmanaged[Cdecl]<void>)vtable.glEndFragmentShaderATI)();
            public void PassTexCoordATI(uint dst, uint coord, SwizzleOpATI swizzle) => ((delegate* unmanaged[Cdecl]<uint, uint, SwizzleOpATI, void>)vtable.glPassTexCoordATI)(dst, coord, swizzle);
            public void SampleMapATI(uint dst, uint interp, SwizzleOpATI swizzle) => ((delegate* unmanaged[Cdecl]<uint, uint, SwizzleOpATI, void>)vtable.glSampleMapATI)(dst, interp, swizzle);
            public void ColorFragmentOp1ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod) => ((delegate* unmanaged[Cdecl]<FragmentOpATI, uint, uint, uint, uint, uint, uint, void>)vtable.glColorFragmentOp1ATI)(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);
            public void ColorFragmentOp2ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod) => ((delegate* unmanaged[Cdecl]<FragmentOpATI, uint, uint, uint, uint, uint, uint, uint, uint, uint, void>)vtable.glColorFragmentOp2ATI)(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
            public void ColorFragmentOp3ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod) => ((delegate* unmanaged[Cdecl]<FragmentOpATI, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, void>)vtable.glColorFragmentOp3ATI)(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
            public void AlphaFragmentOp1ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod) => ((delegate* unmanaged[Cdecl]<FragmentOpATI, uint, uint, uint, uint, uint, void>)vtable.glAlphaFragmentOp1ATI)(op, dst, dstMod, arg1, arg1Rep, arg1Mod);
            public void AlphaFragmentOp2ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod) => ((delegate* unmanaged[Cdecl]<FragmentOpATI, uint, uint, uint, uint, uint, uint, uint, uint, void>)vtable.glAlphaFragmentOp2ATI)(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
            public void AlphaFragmentOp3ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod) => ((delegate* unmanaged[Cdecl]<FragmentOpATI, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, void>)vtable.glAlphaFragmentOp3ATI)(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
            public void SetFragmentShaderConstantATI(uint dst, float* value) => ((delegate* unmanaged[Cdecl]<uint, float*, void>)vtable.glSetFragmentShaderConstantATI)(dst, value);
            public void* MapObjectBufferATI(BufferHandle buffer) => ((delegate* unmanaged[Cdecl]<BufferHandle, void*>)vtable.glMapObjectBufferATI)(buffer);
            public void UnmapObjectBufferATI(BufferHandle buffer) => ((delegate* unmanaged[Cdecl]<BufferHandle, void>)vtable.glUnmapObjectBufferATI)(buffer);
            public void PNTrianglesiATI(PNTrianglesPNameATI pname, int param) => ((delegate* unmanaged[Cdecl]<PNTrianglesPNameATI, int, void>)vtable.glPNTrianglesiATI)(pname, param);
            public void PNTrianglesfATI(PNTrianglesPNameATI pname, float param) => ((delegate* unmanaged[Cdecl]<PNTrianglesPNameATI, float, void>)vtable.glPNTrianglesfATI)(pname, param);
            public void StencilOpSeparateATI(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => ((delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void>)vtable.glStencilOpSeparateATI)(face, sfail, dpfail, dppass);
            public void StencilFuncSeparateATI(StencilFunction frontfunc, StencilFunction backfunc, int reference, uint mask) => ((delegate* unmanaged[Cdecl]<StencilFunction, StencilFunction, int, uint, void>)vtable.glStencilFuncSeparateATI)(frontfunc, backfunc, reference, mask);
            public uint NewObjectBufferATI(int size, void* pointer, ArrayObjectUsageATI usage) => ((delegate* unmanaged[Cdecl]<int, void*, ArrayObjectUsageATI, uint>)vtable.glNewObjectBufferATI)(size, pointer, usage);
            public byte IsObjectBufferATI(BufferHandle buffer) => ((delegate* unmanaged[Cdecl]<BufferHandle, byte>)vtable.glIsObjectBufferATI)(buffer);
            public void UpdateObjectBufferATI(BufferHandle buffer, uint offset, int size, void* pointer, PreserveModeATI preserve) => ((delegate* unmanaged[Cdecl]<BufferHandle, uint, int, void*, PreserveModeATI, void>)vtable.glUpdateObjectBufferATI)(buffer, offset, size, pointer, preserve);
            public void GetObjectBufferfvATI(BufferHandle buffer, ArrayObjectPNameATI pname, float* parameters) => ((delegate* unmanaged[Cdecl]<BufferHandle, ArrayObjectPNameATI, float*, void>)vtable.glGetObjectBufferfvATI)(buffer, pname, parameters);
            public void GetObjectBufferivATI(BufferHandle buffer, ArrayObjectPNameATI pname, int* parameters) => ((delegate* unmanaged[Cdecl]<BufferHandle, ArrayObjectPNameATI, int*, void>)vtable.glGetObjectBufferivATI)(buffer, pname, parameters);
            public void FreeObjectBufferATI(BufferHandle buffer) => ((delegate* unmanaged[Cdecl]<BufferHandle, void>)vtable.glFreeObjectBufferATI)(buffer);
            public void ArrayObjectATI(EnableCap array, int size, ScalarType type, int stride, BufferHandle buffer, uint offset) => ((delegate* unmanaged[Cdecl]<EnableCap, int, ScalarType, int, BufferHandle, uint, void>)vtable.glArrayObjectATI)(array, size, type, stride, buffer, offset);
            public void GetArrayObjectfvATI(EnableCap array, ArrayObjectPNameATI pname, float* parameters) => ((delegate* unmanaged[Cdecl]<EnableCap, ArrayObjectPNameATI, float*, void>)vtable.glGetArrayObjectfvATI)(array, pname, parameters);
            public void GetArrayObjectivATI(EnableCap array, ArrayObjectPNameATI pname, int* parameters) => ((delegate* unmanaged[Cdecl]<EnableCap, ArrayObjectPNameATI, int*, void>)vtable.glGetArrayObjectivATI)(array, pname, parameters);
            public void VariantArrayObjectATI(uint id, ScalarType type, int stride, BufferHandle buffer, uint offset) => ((delegate* unmanaged[Cdecl]<uint, ScalarType, int, BufferHandle, uint, void>)vtable.glVariantArrayObjectATI)(id, type, stride, buffer, offset);
            public void GetVariantArrayObjectfvATI(uint id, ArrayObjectPNameATI pname, float* parameters) => ((delegate* unmanaged[Cdecl]<uint, ArrayObjectPNameATI, float*, void>)vtable.glGetVariantArrayObjectfvATI)(id, pname, parameters);
            public void GetVariantArrayObjectivATI(uint id, ArrayObjectPNameATI pname, int* parameters) => ((delegate* unmanaged[Cdecl]<uint, ArrayObjectPNameATI, int*, void>)vtable.glGetVariantArrayObjectivATI)(id, pname, parameters);
            public void VertexAttribArrayObjectATI(uint index, int size, VertexAttribPointerType type, byte normalized, int stride, BufferHandle buffer, uint offset) => ((delegate* unmanaged[Cdecl]<uint, int, VertexAttribPointerType, byte, int, BufferHandle, uint, void>)vtable.glVertexAttribArrayObjectATI)(index, size, type, normalized, stride, buffer, offset);
            public void GetVertexAttribArrayObjectfvATI(uint index, ArrayObjectPNameATI pname, float* parameters) => ((delegate* unmanaged[Cdecl]<uint, ArrayObjectPNameATI, float*, void>)vtable.glGetVertexAttribArrayObjectfvATI)(index, pname, parameters);
            public void GetVertexAttribArrayObjectivATI(uint index, ArrayObjectPNameATI pname, int* parameters) => ((delegate* unmanaged[Cdecl]<uint, ArrayObjectPNameATI, int*, void>)vtable.glGetVertexAttribArrayObjectivATI)(index, pname, parameters);
            public void VertexStream1sATI(VertexStreamATI stream, short x) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short, void>)vtable.glVertexStream1sATI)(stream, x);
            public void VertexStream1svATI(VertexStreamATI stream, short* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short*, void>)vtable.glVertexStream1svATI)(stream, coords);
            public void VertexStream1iATI(VertexStreamATI stream, int x) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int, void>)vtable.glVertexStream1iATI)(stream, x);
            public void VertexStream1ivATI(VertexStreamATI stream, int* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int*, void>)vtable.glVertexStream1ivATI)(stream, coords);
            public void VertexStream1fATI(VertexStreamATI stream, float x) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float, void>)vtable.glVertexStream1fATI)(stream, x);
            public void VertexStream1fvATI(VertexStreamATI stream, float* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float*, void>)vtable.glVertexStream1fvATI)(stream, coords);
            public void VertexStream1dATI(VertexStreamATI stream, double x) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double, void>)vtable.glVertexStream1dATI)(stream, x);
            public void VertexStream1dvATI(VertexStreamATI stream, double* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double*, void>)vtable.glVertexStream1dvATI)(stream, coords);
            public void VertexStream2sATI(VertexStreamATI stream, short x, short y) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short, short, void>)vtable.glVertexStream2sATI)(stream, x, y);
            public void VertexStream2svATI(VertexStreamATI stream, short* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short*, void>)vtable.glVertexStream2svATI)(stream, coords);
            public void VertexStream2iATI(VertexStreamATI stream, int x, int y) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int, int, void>)vtable.glVertexStream2iATI)(stream, x, y);
            public void VertexStream2ivATI(VertexStreamATI stream, int* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int*, void>)vtable.glVertexStream2ivATI)(stream, coords);
            public void VertexStream2fATI(VertexStreamATI stream, float x, float y) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float, float, void>)vtable.glVertexStream2fATI)(stream, x, y);
            public void VertexStream2fvATI(VertexStreamATI stream, float* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float*, void>)vtable.glVertexStream2fvATI)(stream, coords);
            public void VertexStream2dATI(VertexStreamATI stream, double x, double y) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double, double, void>)vtable.glVertexStream2dATI)(stream, x, y);
            public void VertexStream2dvATI(VertexStreamATI stream, double* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double*, void>)vtable.glVertexStream2dvATI)(stream, coords);
            public void VertexStream3sATI(VertexStreamATI stream, short x, short y, short z) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short, short, short, void>)vtable.glVertexStream3sATI)(stream, x, y, z);
            public void VertexStream3svATI(VertexStreamATI stream, short* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short*, void>)vtable.glVertexStream3svATI)(stream, coords);
            public void VertexStream3iATI(VertexStreamATI stream, int x, int y, int z) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int, int, int, void>)vtable.glVertexStream3iATI)(stream, x, y, z);
            public void VertexStream3ivATI(VertexStreamATI stream, int* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int*, void>)vtable.glVertexStream3ivATI)(stream, coords);
            public void VertexStream3fATI(VertexStreamATI stream, float x, float y, float z) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float, float, float, void>)vtable.glVertexStream3fATI)(stream, x, y, z);
            public void VertexStream3fvATI(VertexStreamATI stream, float* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float*, void>)vtable.glVertexStream3fvATI)(stream, coords);
            public void VertexStream3dATI(VertexStreamATI stream, double x, double y, double z) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double, double, double, void>)vtable.glVertexStream3dATI)(stream, x, y, z);
            public void VertexStream3dvATI(VertexStreamATI stream, double* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double*, void>)vtable.glVertexStream3dvATI)(stream, coords);
            public void VertexStream4sATI(VertexStreamATI stream, short x, short y, short z, short w) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short, short, short, short, void>)vtable.glVertexStream4sATI)(stream, x, y, z, w);
            public void VertexStream4svATI(VertexStreamATI stream, short* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short*, void>)vtable.glVertexStream4svATI)(stream, coords);
            public void VertexStream4iATI(VertexStreamATI stream, int x, int y, int z, int w) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int, int, int, int, void>)vtable.glVertexStream4iATI)(stream, x, y, z, w);
            public void VertexStream4ivATI(VertexStreamATI stream, int* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int*, void>)vtable.glVertexStream4ivATI)(stream, coords);
            public void VertexStream4fATI(VertexStreamATI stream, float x, float y, float z, float w) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float, float, float, float, void>)vtable.glVertexStream4fATI)(stream, x, y, z, w);
            public void VertexStream4fvATI(VertexStreamATI stream, float* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float*, void>)vtable.glVertexStream4fvATI)(stream, coords);
            public void VertexStream4dATI(VertexStreamATI stream, double x, double y, double z, double w) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double, double, double, double, void>)vtable.glVertexStream4dATI)(stream, x, y, z, w);
            public void VertexStream4dvATI(VertexStreamATI stream, double* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double*, void>)vtable.glVertexStream4dvATI)(stream, coords);
            public void NormalStream3bATI(VertexStreamATI stream, sbyte nx, sbyte ny, sbyte nz) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, sbyte, sbyte, sbyte, void>)vtable.glNormalStream3bATI)(stream, nx, ny, nz);
            public void NormalStream3bvATI(VertexStreamATI stream, sbyte* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, sbyte*, void>)vtable.glNormalStream3bvATI)(stream, coords);
            public void NormalStream3sATI(VertexStreamATI stream, short nx, short ny, short nz) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short, short, short, void>)vtable.glNormalStream3sATI)(stream, nx, ny, nz);
            public void NormalStream3svATI(VertexStreamATI stream, short* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, short*, void>)vtable.glNormalStream3svATI)(stream, coords);
            public void NormalStream3iATI(VertexStreamATI stream, int nx, int ny, int nz) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int, int, int, void>)vtable.glNormalStream3iATI)(stream, nx, ny, nz);
            public void NormalStream3ivATI(VertexStreamATI stream, int* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int*, void>)vtable.glNormalStream3ivATI)(stream, coords);
            public void NormalStream3fATI(VertexStreamATI stream, float nx, float ny, float nz) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float, float, float, void>)vtable.glNormalStream3fATI)(stream, nx, ny, nz);
            public void NormalStream3fvATI(VertexStreamATI stream, float* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float*, void>)vtable.glNormalStream3fvATI)(stream, coords);
            public void NormalStream3dATI(VertexStreamATI stream, double nx, double ny, double nz) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double, double, double, void>)vtable.glNormalStream3dATI)(stream, nx, ny, nz);
            public void NormalStream3dvATI(VertexStreamATI stream, double* coords) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, double*, void>)vtable.glNormalStream3dvATI)(stream, coords);
            public void ClientActiveVertexStreamATI(VertexStreamATI stream) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, void>)vtable.glClientActiveVertexStreamATI)(stream);
            public void VertexBlendEnviATI(VertexStreamATI pname, int param) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, int, void>)vtable.glVertexBlendEnviATI)(pname, param);
            public void VertexBlendEnvfATI(VertexStreamATI pname, float param) => ((delegate* unmanaged[Cdecl]<VertexStreamATI, float, void>)vtable.glVertexBlendEnvfATI)(pname, param);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
