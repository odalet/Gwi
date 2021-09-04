// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable IDE1006 // Naming Styles

    unsafe partial class GL
    {
        private SGIXExtension? _SGIX;
        public SGIXExtension SGIX => _SGIX ??= new SGIXExtension(this);

        public sealed unsafe partial class SGIXExtension
        {
            private readonly VTable vtable;

            internal SGIXExtension(GL gl) => vtable = new VTable(gl.Lib);

            public void AsyncMarkerSGIX(uint marker) => ((delegate* unmanaged[Cdecl]<uint, void>)vtable.glAsyncMarkerSGIX)(marker);
            public int FinishAsyncSGIX(uint* markerp) => ((delegate* unmanaged[Cdecl]<uint*, int>)vtable.glFinishAsyncSGIX)(markerp);
            public int PollAsyncSGIX(uint* markerp) => ((delegate* unmanaged[Cdecl]<uint*, int>)vtable.glPollAsyncSGIX)(markerp);
            public uint GenAsyncMarkersSGIX(int range) => ((delegate* unmanaged[Cdecl]<int, uint>)vtable.glGenAsyncMarkersSGIX)(range);
            public void DeleteAsyncMarkersSGIX(uint marker, int range) => ((delegate* unmanaged[Cdecl]<uint, int, void>)vtable.glDeleteAsyncMarkersSGIX)(marker, range);
            public byte IsAsyncMarkerSGIX(uint marker) => ((delegate* unmanaged[Cdecl]<uint, byte>)vtable.glIsAsyncMarkerSGIX)(marker);
            public void FlushRasterSGIX() => ((delegate* unmanaged[Cdecl]<void>)vtable.glFlushRasterSGIX)();
            public void FragmentColorMaterialSGIX(MaterialFace face, MaterialParameter mode) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, void>)vtable.glFragmentColorMaterialSGIX)(face, mode);
            public void FragmentLightfSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float param) => ((delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, float, void>)vtable.glFragmentLightfSGIX)(light, pname, param);
            public void FragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float* parameters) => ((delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, float*, void>)vtable.glFragmentLightfvSGIX)(light, pname, parameters);
            public void FragmentLightiSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int param) => ((delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, int, void>)vtable.glFragmentLightiSGIX)(light, pname, param);
            public void FragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int* parameters) => ((delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, int*, void>)vtable.glFragmentLightivSGIX)(light, pname, parameters);
            public void FragmentLightModelfSGIX(FragmentLightModelParameterSGIX pname, float param) => ((delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, float, void>)vtable.glFragmentLightModelfSGIX)(pname, param);
            public void FragmentLightModelfvSGIX(FragmentLightModelParameterSGIX pname, float* parameters) => ((delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, float*, void>)vtable.glFragmentLightModelfvSGIX)(pname, parameters);
            public void FragmentLightModeliSGIX(FragmentLightModelParameterSGIX pname, int param) => ((delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, int, void>)vtable.glFragmentLightModeliSGIX)(pname, param);
            public void FragmentLightModelivSGIX(FragmentLightModelParameterSGIX pname, int* parameters) => ((delegate* unmanaged[Cdecl]<FragmentLightModelParameterSGIX, int*, void>)vtable.glFragmentLightModelivSGIX)(pname, parameters);
            public void FragmentMaterialfSGIX(MaterialFace face, MaterialParameter pname, float param) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, float, void>)vtable.glFragmentMaterialfSGIX)(face, pname, param);
            public void FragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, float* parameters) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, float*, void>)vtable.glFragmentMaterialfvSGIX)(face, pname, parameters);
            public void FragmentMaterialiSGIX(MaterialFace face, MaterialParameter pname, int param) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, int, void>)vtable.glFragmentMaterialiSGIX)(face, pname, param);
            public void FragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, int*, void>)vtable.glFragmentMaterialivSGIX)(face, pname, parameters);
            public void GetFragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float* parameters) => ((delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, float*, void>)vtable.glGetFragmentLightfvSGIX)(light, pname, parameters);
            public void GetFragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int* parameters) => ((delegate* unmanaged[Cdecl]<FragmentLightNameSGIX, FragmentLightParameterSGIX, int*, void>)vtable.glGetFragmentLightivSGIX)(light, pname, parameters);
            public void GetFragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, float* parameters) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, float*, void>)vtable.glGetFragmentMaterialfvSGIX)(face, pname, parameters);
            public void GetFragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, int*, void>)vtable.glGetFragmentMaterialivSGIX)(face, pname, parameters);
            public void LightEnviSGIX(LightEnvParameterSGIX pname, int param) => ((delegate* unmanaged[Cdecl]<LightEnvParameterSGIX, int, void>)vtable.glLightEnviSGIX)(pname, param);
            public void FrameZoomSGIX(int factor) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glFrameZoomSGIX)(factor);
            public void IglooInterfaceSGIX(GLEnum pname, void* parameters) => ((delegate* unmanaged[Cdecl]<GLEnum, void*, void>)vtable.glIglooInterfaceSGIX)(pname, parameters);
            public int GetInstrumentsSGIX() => ((delegate* unmanaged[Cdecl]<int>)vtable.glGetInstrumentsSGIX)();
            public void InstrumentsBufferSGIX(int size, int* buffer) => ((delegate* unmanaged[Cdecl]<int, int*, void>)vtable.glInstrumentsBufferSGIX)(size, buffer);
            public int PollInstrumentsSGIX(int* marker_p) => ((delegate* unmanaged[Cdecl]<int*, int>)vtable.glPollInstrumentsSGIX)(marker_p);
            public void ReadInstrumentsSGIX(int marker) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glReadInstrumentsSGIX)(marker);
            public void StartInstrumentsSGIX() => ((delegate* unmanaged[Cdecl]<void>)vtable.glStartInstrumentsSGIX)();
            public void StopInstrumentsSGIX(int marker) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glStopInstrumentsSGIX)(marker);
            public void GetListParameterfvSGIX(uint list, ListParameterName pname, float* parameters) => ((delegate* unmanaged[Cdecl]<uint, ListParameterName, float*, void>)vtable.glGetListParameterfvSGIX)(list, pname, parameters);
            public void GetListParameterivSGIX(uint list, ListParameterName pname, int* parameters) => ((delegate* unmanaged[Cdecl]<uint, ListParameterName, int*, void>)vtable.glGetListParameterivSGIX)(list, pname, parameters);
            public void ListParameterfSGIX(uint list, ListParameterName pname, float param) => ((delegate* unmanaged[Cdecl]<uint, ListParameterName, float, void>)vtable.glListParameterfSGIX)(list, pname, param);
            public void ListParameterfvSGIX(uint list, ListParameterName pname, float* parameters) => ((delegate* unmanaged[Cdecl]<uint, ListParameterName, float*, void>)vtable.glListParameterfvSGIX)(list, pname, parameters);
            public void ListParameteriSGIX(uint list, ListParameterName pname, int param) => ((delegate* unmanaged[Cdecl]<uint, ListParameterName, int, void>)vtable.glListParameteriSGIX)(list, pname, param);
            public void ListParameterivSGIX(uint list, ListParameterName pname, int* parameters) => ((delegate* unmanaged[Cdecl]<uint, ListParameterName, int*, void>)vtable.glListParameterivSGIX)(list, pname, parameters);
            public void PixelTexGenSGIX(PixelTexGenModeSGIX mode) => ((delegate* unmanaged[Cdecl]<PixelTexGenModeSGIX, void>)vtable.glPixelTexGenSGIX)(mode);
            public void DeformationMap3dSGIX(FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double* points) => ((delegate* unmanaged[Cdecl]<FfdTargetSGIX, double, double, int, int, double, double, int, int, double, double, int, int, double*, void>)vtable.glDeformationMap3dSGIX)(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
            public void DeformationMap3fSGIX(FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float* points) => ((delegate* unmanaged[Cdecl]<FfdTargetSGIX, float, float, int, int, float, float, int, int, float, float, int, int, float*, void>)vtable.glDeformationMap3fSGIX)(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
            public void DeformSGIX(FfdMaskSGIX mask) => ((delegate* unmanaged[Cdecl]<FfdMaskSGIX, void>)vtable.glDeformSGIX)(mask);
            public void LoadIdentityDeformationMapSGIX(FfdMaskSGIX mask) => ((delegate* unmanaged[Cdecl]<FfdMaskSGIX, void>)vtable.glLoadIdentityDeformationMapSGIX)(mask);
            public void ReferencePlaneSGIX(double* equation) => ((delegate* unmanaged[Cdecl]<double*, void>)vtable.glReferencePlaneSGIX)(equation);
            public void SpriteParameterfSGIX(SpriteParameterNameSGIX pname, float param) => ((delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, float, void>)vtable.glSpriteParameterfSGIX)(pname, param);
            public void SpriteParameterfvSGIX(SpriteParameterNameSGIX pname, float* parameters) => ((delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, float*, void>)vtable.glSpriteParameterfvSGIX)(pname, parameters);
            public void SpriteParameteriSGIX(SpriteParameterNameSGIX pname, int param) => ((delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, int, void>)vtable.glSpriteParameteriSGIX)(pname, param);
            public void SpriteParameterivSGIX(SpriteParameterNameSGIX pname, int* parameters) => ((delegate* unmanaged[Cdecl]<SpriteParameterNameSGIX, int*, void>)vtable.glSpriteParameterivSGIX)(pname, parameters);
            public void TagSampleBufferSGIX() => ((delegate* unmanaged[Cdecl]<void>)vtable.glTagSampleBufferSGIX)();
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
