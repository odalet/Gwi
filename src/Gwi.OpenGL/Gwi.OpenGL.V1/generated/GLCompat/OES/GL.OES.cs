// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
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

            public void MultiTexCoord1bOES(TextureUnit texture, sbyte s) => ((delegate* unmanaged[Cdecl]<TextureUnit, sbyte, void>)vtable.glMultiTexCoord1bOES)(texture, s);
            public void MultiTexCoord1bvOES(TextureUnit texture, sbyte* coords) => ((delegate* unmanaged[Cdecl]<TextureUnit, sbyte*, void>)vtable.glMultiTexCoord1bvOES)(texture, coords);
            public void MultiTexCoord2bOES(TextureUnit texture, sbyte s, sbyte t) => ((delegate* unmanaged[Cdecl]<TextureUnit, sbyte, sbyte, void>)vtable.glMultiTexCoord2bOES)(texture, s, t);
            public void MultiTexCoord2bvOES(TextureUnit texture, sbyte* coords) => ((delegate* unmanaged[Cdecl]<TextureUnit, sbyte*, void>)vtable.glMultiTexCoord2bvOES)(texture, coords);
            public void MultiTexCoord3bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r) => ((delegate* unmanaged[Cdecl]<TextureUnit, sbyte, sbyte, sbyte, void>)vtable.glMultiTexCoord3bOES)(texture, s, t, r);
            public void MultiTexCoord3bvOES(TextureUnit texture, sbyte* coords) => ((delegate* unmanaged[Cdecl]<TextureUnit, sbyte*, void>)vtable.glMultiTexCoord3bvOES)(texture, coords);
            public void MultiTexCoord4bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q) => ((delegate* unmanaged[Cdecl]<TextureUnit, sbyte, sbyte, sbyte, sbyte, void>)vtable.glMultiTexCoord4bOES)(texture, s, t, r, q);
            public void MultiTexCoord4bvOES(TextureUnit texture, sbyte* coords) => ((delegate* unmanaged[Cdecl]<TextureUnit, sbyte*, void>)vtable.glMultiTexCoord4bvOES)(texture, coords);
            public void TexCoord1bOES(sbyte s) => ((delegate* unmanaged[Cdecl]<sbyte, void>)vtable.glTexCoord1bOES)(s);
            public void TexCoord1bvOES(sbyte* coords) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)vtable.glTexCoord1bvOES)(coords);
            public void TexCoord2bOES(sbyte s, sbyte t) => ((delegate* unmanaged[Cdecl]<sbyte, sbyte, void>)vtable.glTexCoord2bOES)(s, t);
            public void TexCoord2bvOES(sbyte* coords) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)vtable.glTexCoord2bvOES)(coords);
            public void TexCoord3bOES(sbyte s, sbyte t, sbyte r) => ((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, void>)vtable.glTexCoord3bOES)(s, t, r);
            public void TexCoord3bvOES(sbyte* coords) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)vtable.glTexCoord3bvOES)(coords);
            public void TexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q) => ((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, sbyte, void>)vtable.glTexCoord4bOES)(s, t, r, q);
            public void TexCoord4bvOES(sbyte* coords) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)vtable.glTexCoord4bvOES)(coords);
            public void Vertex2bOES(sbyte x, sbyte y) => ((delegate* unmanaged[Cdecl]<sbyte, sbyte, void>)vtable.glVertex2bOES)(x, y);
            public void Vertex2bvOES(sbyte* coords) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)vtable.glVertex2bvOES)(coords);
            public void Vertex3bOES(sbyte x, sbyte y, sbyte z) => ((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, void>)vtable.glVertex3bOES)(x, y, z);
            public void Vertex3bvOES(sbyte* coords) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)vtable.glVertex3bvOES)(coords);
            public void Vertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w) => ((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, sbyte, void>)vtable.glVertex4bOES)(x, y, z, w);
            public void Vertex4bvOES(sbyte* coords) => ((delegate* unmanaged[Cdecl]<sbyte*, void>)vtable.glVertex4bvOES)(coords);
            public void AlphaFuncxOES(AlphaFunction func, int reference) => ((delegate* unmanaged[Cdecl]<AlphaFunction, int, void>)vtable.glAlphaFuncxOES)(func, reference);
            public void ClearColorxOES(int red, int green, int blue, int alpha) => ((delegate* unmanaged[Cdecl]<int, int, int, int, void>)vtable.glClearColorxOES)(red, green, blue, alpha);
            public void ClearDepthxOES(int depth) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glClearDepthxOES)(depth);
            public void ClipPlanexOES(ClipPlaneName plane, int* equation) => ((delegate* unmanaged[Cdecl]<ClipPlaneName, int*, void>)vtable.glClipPlanexOES)(plane, equation);
            public void Color4xOES(int red, int green, int blue, int alpha) => ((delegate* unmanaged[Cdecl]<int, int, int, int, void>)vtable.glColor4xOES)(red, green, blue, alpha);
            public void DepthRangexOES(int n, int f) => ((delegate* unmanaged[Cdecl]<int, int, void>)vtable.glDepthRangexOES)(n, f);
            public void FogxOES(FogPName pname, int param) => ((delegate* unmanaged[Cdecl]<FogPName, int, void>)vtable.glFogxOES)(pname, param);
            public void FogxvOES(FogPName pname, int* param) => ((delegate* unmanaged[Cdecl]<FogPName, int*, void>)vtable.glFogxvOES)(pname, param);
            public void FrustumxOES(int l, int r, int b, int t, int n, int f) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, int, void>)vtable.glFrustumxOES)(l, r, b, t, n, f);
            public void GetClipPlanexOES(ClipPlaneName plane, int* equation) => ((delegate* unmanaged[Cdecl]<ClipPlaneName, int*, void>)vtable.glGetClipPlanexOES)(plane, equation);
            public void GetFixedvOES(GetPName pname, int* parameters) => ((delegate* unmanaged[Cdecl]<GetPName, int*, void>)vtable.glGetFixedvOES)(pname, parameters);
            public void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, int*, void>)vtable.glGetTexEnvxvOES)(target, pname, parameters);
            public void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, int*, void>)vtable.glGetTexParameterxvOES)(target, pname, parameters);
            public void LightModelxOES(LightModelParameter pname, int param) => ((delegate* unmanaged[Cdecl]<LightModelParameter, int, void>)vtable.glLightModelxOES)(pname, param);
            public void LightModelxvOES(LightModelParameter pname, int* param) => ((delegate* unmanaged[Cdecl]<LightModelParameter, int*, void>)vtable.glLightModelxvOES)(pname, param);
            public void LightxOES(LightName light, LightParameter pname, int param) => ((delegate* unmanaged[Cdecl]<LightName, LightParameter, int, void>)vtable.glLightxOES)(light, pname, param);
            public void LightxvOES(LightName light, LightParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<LightName, LightParameter, int*, void>)vtable.glLightxvOES)(light, pname, parameters);
            public void LineWidthxOES(int width) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glLineWidthxOES)(width);
            public void LoadMatrixxOES(int* m) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glLoadMatrixxOES)(m);
            public void MaterialxOES(MaterialFace face, MaterialParameter pname, int param) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, int, void>)vtable.glMaterialxOES)(face, pname, param);
            public void MaterialxvOES(MaterialFace face, MaterialParameter pname, int* param) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, int*, void>)vtable.glMaterialxvOES)(face, pname, param);
            public void MultMatrixxOES(int* m) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glMultMatrixxOES)(m);
            public void MultiTexCoord4xOES(TextureUnit texture, int s, int t, int r, int q) => ((delegate* unmanaged[Cdecl]<TextureUnit, int, int, int, int, void>)vtable.glMultiTexCoord4xOES)(texture, s, t, r, q);
            public void Normal3xOES(int nx, int ny, int nz) => ((delegate* unmanaged[Cdecl]<int, int, int, void>)vtable.glNormal3xOES)(nx, ny, nz);
            public void OrthoxOES(int l, int r, int b, int t, int n, int f) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, int, void>)vtable.glOrthoxOES)(l, r, b, t, n, f);
            public void PointParameterxvOES(PointParameterNameARB pname, int* parameters) => ((delegate* unmanaged[Cdecl]<PointParameterNameARB, int*, void>)vtable.glPointParameterxvOES)(pname, parameters);
            public void PointSizexOES(int size) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glPointSizexOES)(size);
            public void PolygonOffsetxOES(int factor, int units) => ((delegate* unmanaged[Cdecl]<int, int, void>)vtable.glPolygonOffsetxOES)(factor, units);
            public void RotatexOES(int angle, int x, int y, int z) => ((delegate* unmanaged[Cdecl]<int, int, int, int, void>)vtable.glRotatexOES)(angle, x, y, z);
            public void ScalexOES(int x, int y, int z) => ((delegate* unmanaged[Cdecl]<int, int, int, void>)vtable.glScalexOES)(x, y, z);
            public void TexEnvxOES(TextureEnvTarget target, TextureEnvParameter pname, int param) => ((delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, int, void>)vtable.glTexEnvxOES)(target, pname, param);
            public void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, int*, void>)vtable.glTexEnvxvOES)(target, pname, parameters);
            public void TexParameterxOES(TextureTarget target, GetTextureParameter pname, int param) => ((delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, int, void>)vtable.glTexParameterxOES)(target, pname, param);
            public void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, int*, void>)vtable.glTexParameterxvOES)(target, pname, parameters);
            public void TranslatexOES(int x, int y, int z) => ((delegate* unmanaged[Cdecl]<int, int, int, void>)vtable.glTranslatexOES)(x, y, z);
            public void GetLightxvOES(LightName light, LightParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<LightName, LightParameter, int*, void>)vtable.glGetLightxvOES)(light, pname, parameters);
            public void GetMaterialxvOES(MaterialFace face, MaterialParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, int*, void>)vtable.glGetMaterialxvOES)(face, pname, parameters);
            public void PointParameterxOES(PointParameterNameARB pname, int param) => ((delegate* unmanaged[Cdecl]<PointParameterNameARB, int, void>)vtable.glPointParameterxOES)(pname, param);
            public void SampleCoveragexOES(int value, byte invert) => ((delegate* unmanaged[Cdecl]<int, byte, void>)vtable.glSampleCoveragexOES)(value, invert);
            public void AccumxOES(GLEnum op, int value) => ((delegate* unmanaged[Cdecl]<GLEnum, int, void>)vtable.glAccumxOES)(op, value);
            public void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, int, byte*, void>)vtable.glBitmapxOES)(width, height, xorig, yorig, xmove, ymove, bitmap);
            public void BlendColorxOES(int red, int green, int blue, int alpha) => ((delegate* unmanaged[Cdecl]<int, int, int, int, void>)vtable.glBlendColorxOES)(red, green, blue, alpha);
            public void ClearAccumxOES(int red, int green, int blue, int alpha) => ((delegate* unmanaged[Cdecl]<int, int, int, int, void>)vtable.glClearAccumxOES)(red, green, blue, alpha);
            public void Color3xOES(int red, int green, int blue) => ((delegate* unmanaged[Cdecl]<int, int, int, void>)vtable.glColor3xOES)(red, green, blue);
            public void Color3xvOES(int* components) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glColor3xvOES)(components);
            public void Color4xvOES(int* components) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glColor4xvOES)(components);
            public void ConvolutionParameterxOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int param) => ((delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, int, void>)vtable.glConvolutionParameterxOES)(target, pname, param);
            public void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int* parameters) => ((delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, int*, void>)vtable.glConvolutionParameterxvOES)(target, pname, parameters);
            public void EvalCoord1xOES(int u) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glEvalCoord1xOES)(u);
            public void EvalCoord1xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glEvalCoord1xvOES)(coords);
            public void EvalCoord2xOES(int u, int v) => ((delegate* unmanaged[Cdecl]<int, int, void>)vtable.glEvalCoord2xOES)(u, v);
            public void EvalCoord2xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glEvalCoord2xvOES)(coords);
            public void FeedbackBufferxOES(int n, GLEnum type, int* buffer) => ((delegate* unmanaged[Cdecl]<int, GLEnum, int*, void>)vtable.glFeedbackBufferxOES)(n, type, buffer);
            public void GetConvolutionParameterxvOES(GLEnum target, GLEnum pname, int* parameters) => ((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, int*, void>)vtable.glGetConvolutionParameterxvOES)(target, pname, parameters);
            public void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters) => ((delegate* unmanaged[Cdecl]<HistogramTargetEXT, GetHistogramParameterPNameEXT, int*, void>)vtable.glGetHistogramParameterxvOES)(target, pname, parameters);
            public void GetLightxOES(LightName light, LightParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<LightName, LightParameter, int*, void>)vtable.glGetLightxOES)(light, pname, parameters);
            public void GetMapxvOES(MapTarget target, GetMapQuery query, int* v) => ((delegate* unmanaged[Cdecl]<MapTarget, GetMapQuery, int*, void>)vtable.glGetMapxvOES)(target, query, v);
            public void GetMaterialxOES(MaterialFace face, MaterialParameter pname, int param) => ((delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, int, void>)vtable.glGetMaterialxOES)(face, pname, param);
            public void GetPixelMapxv(PixelMap map, int size, int* values) => ((delegate* unmanaged[Cdecl]<PixelMap, int, int*, void>)vtable.glGetPixelMapxv)(map, size, values);
            public void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, int*, void>)vtable.glGetTexGenxvOES)(coord, pname, parameters);
            public void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureTarget, int, GetTextureParameter, int*, void>)vtable.glGetTexLevelParameterxvOES)(target, level, pname, parameters);
            public void IndexxOES(int component) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glIndexxOES)(component);
            public void IndexxvOES(int* component) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glIndexxvOES)(component);
            public void LoadTransposeMatrixxOES(int* m) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glLoadTransposeMatrixxOES)(m);
            public void Map1xOES(MapTarget target, int u1, int u2, int stride, int order, int points) => ((delegate* unmanaged[Cdecl]<MapTarget, int, int, int, int, int, void>)vtable.glMap1xOES)(target, u1, u2, stride, order, points);
            public void Map2xOES(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) => ((delegate* unmanaged[Cdecl]<MapTarget, int, int, int, int, int, int, int, int, int, void>)vtable.glMap2xOES)(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            public void MapGrid1xOES(int n, int u1, int u2) => ((delegate* unmanaged[Cdecl]<int, int, int, void>)vtable.glMapGrid1xOES)(n, u1, u2);
            public void MapGrid2xOES(int n, int u1, int u2, int v1, int v2) => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, void>)vtable.glMapGrid2xOES)(n, u1, u2, v1, v2);
            public void MultTransposeMatrixxOES(int* m) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glMultTransposeMatrixxOES)(m);
            public void MultiTexCoord1xOES(TextureUnit texture, int s) => ((delegate* unmanaged[Cdecl]<TextureUnit, int, void>)vtable.glMultiTexCoord1xOES)(texture, s);
            public void MultiTexCoord1xvOES(TextureUnit texture, int* coords) => ((delegate* unmanaged[Cdecl]<TextureUnit, int*, void>)vtable.glMultiTexCoord1xvOES)(texture, coords);
            public void MultiTexCoord2xOES(TextureUnit texture, int s, int t) => ((delegate* unmanaged[Cdecl]<TextureUnit, int, int, void>)vtable.glMultiTexCoord2xOES)(texture, s, t);
            public void MultiTexCoord2xvOES(TextureUnit texture, int* coords) => ((delegate* unmanaged[Cdecl]<TextureUnit, int*, void>)vtable.glMultiTexCoord2xvOES)(texture, coords);
            public void MultiTexCoord3xOES(TextureUnit texture, int s, int t, int r) => ((delegate* unmanaged[Cdecl]<TextureUnit, int, int, int, void>)vtable.glMultiTexCoord3xOES)(texture, s, t, r);
            public void MultiTexCoord3xvOES(TextureUnit texture, int* coords) => ((delegate* unmanaged[Cdecl]<TextureUnit, int*, void>)vtable.glMultiTexCoord3xvOES)(texture, coords);
            public void MultiTexCoord4xvOES(TextureUnit texture, int* coords) => ((delegate* unmanaged[Cdecl]<TextureUnit, int*, void>)vtable.glMultiTexCoord4xvOES)(texture, coords);
            public void Normal3xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glNormal3xvOES)(coords);
            public void PassThroughxOES(int token) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glPassThroughxOES)(token);
            public void PixelMapx(PixelMap map, int size, int* values) => ((delegate* unmanaged[Cdecl]<PixelMap, int, int*, void>)vtable.glPixelMapx)(map, size, values);
            public void PixelStorex(PixelStoreParameter pname, int param) => ((delegate* unmanaged[Cdecl]<PixelStoreParameter, int, void>)vtable.glPixelStorex)(pname, param);
            public void PixelTransferxOES(PixelTransferParameter pname, int param) => ((delegate* unmanaged[Cdecl]<PixelTransferParameter, int, void>)vtable.glPixelTransferxOES)(pname, param);
            public void PixelZoomxOES(int xfactor, int yfactor) => ((delegate* unmanaged[Cdecl]<int, int, void>)vtable.glPixelZoomxOES)(xfactor, yfactor);
            public void PrioritizeTexturesxOES(int n, TextureHandle* textures, int* priorities) => ((delegate* unmanaged[Cdecl]<int, TextureHandle*, int*, void>)vtable.glPrioritizeTexturesxOES)(n, textures, priorities);
            public void RasterPos2xOES(int x, int y) => ((delegate* unmanaged[Cdecl]<int, int, void>)vtable.glRasterPos2xOES)(x, y);
            public void RasterPos2xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glRasterPos2xvOES)(coords);
            public void RasterPos3xOES(int x, int y, int z) => ((delegate* unmanaged[Cdecl]<int, int, int, void>)vtable.glRasterPos3xOES)(x, y, z);
            public void RasterPos3xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glRasterPos3xvOES)(coords);
            public void RasterPos4xOES(int x, int y, int z, int w) => ((delegate* unmanaged[Cdecl]<int, int, int, int, void>)vtable.glRasterPos4xOES)(x, y, z, w);
            public void RasterPos4xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glRasterPos4xvOES)(coords);
            public void RectxOES(int x1, int y1, int x2, int y2) => ((delegate* unmanaged[Cdecl]<int, int, int, int, void>)vtable.glRectxOES)(x1, y1, x2, y2);
            public void RectxvOES(int* v1, int* v2) => ((delegate* unmanaged[Cdecl]<int*, int*, void>)vtable.glRectxvOES)(v1, v2);
            public void TexCoord1xOES(int s) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glTexCoord1xOES)(s);
            public void TexCoord1xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glTexCoord1xvOES)(coords);
            public void TexCoord2xOES(int s, int t) => ((delegate* unmanaged[Cdecl]<int, int, void>)vtable.glTexCoord2xOES)(s, t);
            public void TexCoord2xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glTexCoord2xvOES)(coords);
            public void TexCoord3xOES(int s, int t, int r) => ((delegate* unmanaged[Cdecl]<int, int, int, void>)vtable.glTexCoord3xOES)(s, t, r);
            public void TexCoord3xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glTexCoord3xvOES)(coords);
            public void TexCoord4xOES(int s, int t, int r, int q) => ((delegate* unmanaged[Cdecl]<int, int, int, int, void>)vtable.glTexCoord4xOES)(s, t, r, q);
            public void TexCoord4xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glTexCoord4xvOES)(coords);
            public void TexGenxOES(TextureCoordName coord, TextureGenParameter pname, int param) => ((delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, int, void>)vtable.glTexGenxOES)(coord, pname, param);
            public void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => ((delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, int*, void>)vtable.glTexGenxvOES)(coord, pname, parameters);
            public void Vertex2xOES(int x) => ((delegate* unmanaged[Cdecl]<int, void>)vtable.glVertex2xOES)(x);
            public void Vertex2xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glVertex2xvOES)(coords);
            public void Vertex3xOES(int x, int y) => ((delegate* unmanaged[Cdecl]<int, int, void>)vtable.glVertex3xOES)(x, y);
            public void Vertex3xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glVertex3xvOES)(coords);
            public void Vertex4xOES(int x, int y, int z) => ((delegate* unmanaged[Cdecl]<int, int, int, void>)vtable.glVertex4xOES)(x, y, z);
            public void Vertex4xvOES(int* coords) => ((delegate* unmanaged[Cdecl]<int*, void>)vtable.glVertex4xvOES)(coords);
            public GLEnum QueryMatrixxOES(int* mantissa, int* exponent) => ((delegate* unmanaged[Cdecl]<int*, int*, GLEnum>)vtable.glQueryMatrixxOES)(mantissa, exponent);
            public void ClearDepthfOES(float depth) => ((delegate* unmanaged[Cdecl]<float, void>)vtable.glClearDepthfOES)(depth);
            public void ClipPlanefOES(ClipPlaneName plane, float* equation) => ((delegate* unmanaged[Cdecl]<ClipPlaneName, float*, void>)vtable.glClipPlanefOES)(plane, equation);
            public void DepthRangefOES(float n, float f) => ((delegate* unmanaged[Cdecl]<float, float, void>)vtable.glDepthRangefOES)(n, f);
            public void FrustumfOES(float l, float r, float b, float t, float n, float f) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, void>)vtable.glFrustumfOES)(l, r, b, t, n, f);
            public void GetClipPlanefOES(ClipPlaneName plane, float* equation) => ((delegate* unmanaged[Cdecl]<ClipPlaneName, float*, void>)vtable.glGetClipPlanefOES)(plane, equation);
            public void OrthofOES(float l, float r, float b, float t, float n, float f) => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float, void>)vtable.glOrthofOES)(l, r, b, t, n, f);
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
