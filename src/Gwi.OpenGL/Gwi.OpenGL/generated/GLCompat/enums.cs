// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLCompat
{
#pragma warning disable CA1069 // Enums should not have duplicate values

    // TODO: Temporary fake definition needed to satisfy NV extension
    public enum SampleMaskNV : uint { }

    [Flags]
    public enum AttribMask : uint
    {
        CurrentBit = 1,
        PointBit = 2,
        LineBit = 4,
        PolygonBit = 8,
        PolygonStippleBit = 16,
        PixelModeBit = 32,
        LightingBit = 64,
        FogBit = 128,
        DepthBufferBit = 256,
        AccumBufferBit = 512,
        StencilBufferBit = 1024,
        ViewportBit = 2048,
        TransformBit = 4096,
        EnableBit = 8192,
        ColorBufferBit = 16384,
        HintBit = 32768,
        EvalBit = 65536,
        ListBit = 131072,
        TextureBit = 262144,
        ScissorBit = 524288,
        MultisampleBit = 536870912,
        MultisampleBit3dfx = 536870912,
        MultisampleBitArb = 536870912,
        MultisampleBitExt = 536870912,
        AllAttribBits = 4294967295
    }

    [Flags]
    public enum ClearBufferMask : uint
    {
        DepthBufferBit = 256,
        AccumBufferBit = 512,
        StencilBufferBit = 1024,
        ColorBufferBit = 16384
    }

    [Flags]
    public enum BufferStorageMask : uint
    {
        MapReadBit = 1,
        MapWriteBit = 2,
        MapPersistentBit = 64,
        MapCoherentBit = 128,
        DynamicStorageBit = 256,
        ClientStorageBit = 512,
        SparseStorageBitArb = 1024,
        LgpuSeparateStorageBitNvx = 2048,
        PerGpuStorageBitNv = 2048
    }

    [Flags]
    public enum ClientAttribMask : uint
    {
        ClientPixelStoreBit = 1,
        ClientVertexArrayBit = 2,
        ClientAllAttribBits = 4294967295
    }

    [Flags]
    public enum ContextFlagMask : uint
    {
        ContextFlagForwardCompatibleBit = 1,
        ContextFlagDebugBit = 2,
        ContextFlagDebugBitKhr = 2,
        ContextFlagRobustAccessBit = 4,
        ContextFlagRobustAccessBitArb = 4,
        ContextFlagNoErrorBit = 8,
        ContextFlagNoErrorBitKhr = 8
    }

    [Flags]
    public enum ContextProfileMask : uint
    {
        ContextCoreProfileBit = 1,
        ContextCompatibilityProfileBit = 2
    }

    [Flags]
    public enum MapBufferAccessMask : uint
    {
        MapReadBit = 1,
        MapWriteBit = 2,
        MapInvalidateRangeBit = 4,
        MapInvalidateBufferBit = 8,
        MapFlushExplicitBit = 16,
        MapUnsynchronizedBit = 32,
        MapPersistentBit = 64,
        MapCoherentBit = 128
    }

    [Flags]
    public enum MemoryBarrierMask : uint
    {
        VertexAttribArrayBarrierBit = 1,
        VertexAttribArrayBarrierBitExt = 1,
        ElementArrayBarrierBit = 2,
        ElementArrayBarrierBitExt = 2,
        UniformBarrierBit = 4,
        UniformBarrierBitExt = 4,
        TextureFetchBarrierBit = 8,
        TextureFetchBarrierBitExt = 8,
        ShaderGlobalAccessBarrierBitNv = 16,
        ShaderImageAccessBarrierBit = 32,
        ShaderImageAccessBarrierBitExt = 32,
        CommandBarrierBit = 64,
        CommandBarrierBitExt = 64,
        PixelBufferBarrierBit = 128,
        PixelBufferBarrierBitExt = 128,
        TextureUpdateBarrierBit = 256,
        TextureUpdateBarrierBitExt = 256,
        BufferUpdateBarrierBit = 512,
        BufferUpdateBarrierBitExt = 512,
        FramebufferBarrierBit = 1024,
        FramebufferBarrierBitExt = 1024,
        TransformFeedbackBarrierBit = 2048,
        TransformFeedbackBarrierBitExt = 2048,
        AtomicCounterBarrierBit = 4096,
        AtomicCounterBarrierBitExt = 4096,
        ShaderStorageBarrierBit = 8192,
        ClientMappedBufferBarrierBit = 16384,
        QueryBufferBarrierBit = 32768,
        AllBarrierBits = 4294967295,
        AllBarrierBitsExt = 4294967295
    }

    [Flags]
    public enum OcclusionQueryEventMaskAMD : uint
    {
        QueryDepthPassEventBitAmd = 1,
        QueryDepthFailEventBitAmd = 2,
        QueryStencilFailEventBitAmd = 4,
        QueryDepthBoundsFailEventBitAmd = 8,
        QueryAllEventBitsAmd = 4294967295
    }

    [Flags]
    public enum SyncObjectMask : uint
    {
        SyncFlushCommandsBit = 1
    }

    [Flags]
    public enum UseProgramStageMask : uint
    {
        VertexShaderBit = 1,
        VertexShaderBitExt = 1,
        FragmentShaderBit = 2,
        FragmentShaderBitExt = 2,
        GeometryShaderBit = 4,
        TessControlShaderBit = 8,
        TessEvaluationShaderBit = 16,
        ComputeShaderBit = 32,
        MeshShaderBitNv = 64,
        TaskShaderBitNv = 128,
        AllShaderBits = 4294967295,
        AllShaderBitsExt = 4294967295
    }

    [Flags]
    public enum SubgroupSupportedFeatures : uint
    {
        SubgroupFeatureBasicBitKhr = 1,
        SubgroupFeatureVoteBitKhr = 2,
        SubgroupFeatureArithmeticBitKhr = 4,
        SubgroupFeatureBallotBitKhr = 8,
        SubgroupFeatureShuffleBitKhr = 16,
        SubgroupFeatureShuffleRelativeBitKhr = 32,
        SubgroupFeatureClusteredBitKhr = 64,
        SubgroupFeatureQuadBitKhr = 128,
        SubgroupFeaturePartitionedBitNv = 256
    }

    [Flags]
    public enum TextureStorageMaskAMD : uint
    {
        TextureStorageSparseBitAmd = 1
    }

    [Flags]
    public enum FragmentShaderDestMaskATI : uint
    {
        RedBitAti = 1,
        GreenBitAti = 2,
        BlueBitAti = 4
    }

    [Flags]
    public enum FragmentShaderDestModMaskATI : uint
    {
        _2xBitAti = 1,
        _4xBitAti = 2,
        _8xBitAti = 4,
        HalfBitAti = 8,
        QuarterBitAti = 16,
        EighthBitAti = 32,
        SaturateBitAti = 64
    }

    [Flags]
    public enum FragmentShaderColorModMaskATI : uint
    {
        CompBitAti = 2,
        NegateBitAti = 4,
        BiasBitAti = 8
    }

    [Flags]
    public enum PathFontStyle : uint
    {
        None = 0,
        BoldBitNv = 1,
        ItalicBitNv = 2
    }

    [Flags]
    public enum PathMetricMask : uint
    {
        GlyphWidthBitNv = 1,
        GlyphHeightBitNv = 2,
        GlyphHorizontalBearingXBitNv = 4,
        GlyphHorizontalBearingYBitNv = 8,
        GlyphHorizontalBearingAdvanceBitNv = 16,
        GlyphVerticalBearingXBitNv = 32,
        GlyphVerticalBearingYBitNv = 64,
        GlyphVerticalBearingAdvanceBitNv = 128,
        GlyphHasKerningBitNv = 256,
        FontXMinBoundsBitNv = 65536,
        FontYMinBoundsBitNv = 131072,
        FontXMaxBoundsBitNv = 262144,
        FontYMaxBoundsBitNv = 524288,
        FontUnitsPerEmBitNv = 1048576,
        FontAscenderBitNv = 2097152,
        FontDescenderBitNv = 4194304,
        FontHeightBitNv = 8388608,
        FontMaxAdvanceWidthBitNv = 16777216,
        FontMaxAdvanceHeightBitNv = 33554432,
        FontUnderlinePositionBitNv = 67108864,
        FontUnderlineThicknessBitNv = 134217728,
        FontHasKerningBitNv = 268435456,
        FontNumGlyphIndicesBitNv = 536870912
    }

    [Flags]
    public enum PerformanceQueryCapsMaskINTEL : uint
    {
        PerfquerySingleContextIntel = 0,
        PerfqueryGlobalContextIntel = 1
    }

    [Flags]
    public enum VertexHintsMaskPGI : uint
    {
        Vertex23BitPgi = 4,
        Vertex4BitPgi = 8,
        Color3BitPgi = 65536,
        Color4BitPgi = 131072,
        EdgeflagBitPgi = 262144,
        IndexBitPgi = 524288,
        MatAmbientBitPgi = 1048576,
        MatAmbientAndDiffuseBitPgi = 2097152,
        MatDiffuseBitPgi = 4194304,
        MatEmissionBitPgi = 8388608,
        MatColorIndexesBitPgi = 16777216,
        MatShininessBitPgi = 33554432,
        MatSpecularBitPgi = 67108864,
        NormalBitPgi = 134217728,
        Texcoord1BitPgi = 268435456,
        Texcoord2BitPgi = 536870912,
        Texcoord3BitPgi = 1073741824,
        Texcoord4BitPgi = 2147483648
    }

    [Flags]
    public enum FfdMaskSGIX : uint
    {
        TextureDeformationBitSgix = 1,
        GeometryDeformationBitSgix = 2
    }

    public enum CommandOpcodesNV : uint
    {
        TerminateSequenceCommandNv = 0,
        NopCommandNv = 1,
        DrawElementsCommandNv = 2,
        DrawArraysCommandNv = 3,
        DrawElementsStripCommandNv = 4,
        DrawArraysStripCommandNv = 5,
        DrawElementsInstancedCommandNv = 6,
        DrawArraysInstancedCommandNv = 7,
        ElementAddressCommandNv = 8,
        AttributeAddressCommandNv = 9,
        UniformAddressCommandNv = 10,
        BlendColorCommandNv = 11,
        StencilRefCommandNv = 12,
        LineWidthCommandNv = 13,
        PolygonOffsetCommandNv = 14,
        AlphaRefCommandNv = 15,
        ViewportCommandNv = 16,
        ScissorCommandNv = 17,
        FrontFaceCommandNv = 18
    }

    public enum MapTextureFormatINTEL : uint
    {
        LayoutDefaultIntel = 0,
        LayoutLinearIntel = 1,
        LayoutLinearCpuCachedIntel = 2
    }

    public enum PathCoordType : uint
    {
        ClosePathNv = 0,
        MoveToNv = 2,
        RelativeMoveToNv = 3,
        LineToNv = 4,
        RelativeLineToNv = 5,
        HorizontalLineToNv = 6,
        RelativeHorizontalLineToNv = 7,
        VerticalLineToNv = 8,
        RelativeVerticalLineToNv = 9,
        QuadraticCurveToNv = 10,
        RelativeQuadraticCurveToNv = 11,
        CubicCurveToNv = 12,
        RelativeCubicCurveToNv = 13,
        SmoothQuadraticCurveToNv = 14,
        RelativeSmoothQuadraticCurveToNv = 15,
        SmoothCubicCurveToNv = 16,
        RelativeSmoothCubicCurveToNv = 17,
        SmallCcwArcToNv = 18,
        RelativeSmallCcwArcToNv = 19,
        SmallCwArcToNv = 20,
        RelativeSmallCwArcToNv = 21,
        LargeCcwArcToNv = 22,
        RelativeLargeCcwArcToNv = 23,
        LargeCwArcToNv = 24,
        RelativeLargeCwArcToNv = 25,
        ConicCurveToNv = 26,
        RelativeConicCurveToNv = 27,
        RoundedRectNv = 232,
        RelativeRoundedRectNv = 233,
        RoundedRect2Nv = 234,
        RelativeRoundedRect2Nv = 235,
        RoundedRect4Nv = 236,
        RelativeRoundedRect4Nv = 237,
        RoundedRect8Nv = 238,
        RelativeRoundedRect8Nv = 239,
        RestartPathNv = 240,
        DupFirstCubicCurveToNv = 242,
        DupLastCubicCurveToNv = 244,
        RectNv = 246,
        RelativeRectNv = 247,
        CircularCcwArcToNv = 248,
        CircularCwArcToNv = 250,
        CircularTangentArcToNv = 252,
        ArcToNv = 254,
        RelativeArcToNv = 255
    }

    public enum TransformFeedbackTokenNV : uint
    {
        SkipComponents1Nv = 4294967290,
        SkipComponents2Nv = 4294967291,
        SkipComponents3Nv = 4294967292,
        SkipComponents4Nv = 4294967293,
        NextBufferNv = 4294967294
    }

    public enum TriangleListSUN : uint
    {
        RestartSun = 1,
        ReplaceMiddleSun = 2,
        ReplaceOldestSun = 3
    }

    public enum Boolean : uint
    {
        False = 0,
        True = 1
    }

    public enum VertexShaderWriteMaskEXT : uint
    {
        False = 0,
        True = 1
    }

    public enum ClampColorModeARB : uint
    {
        False = 0,
        True = 1,
        FixedOnly = 35101,
        FixedOnlyArb = 35101
    }

    public enum GraphicsResetStatus : uint
    {
        NoError = 0,
        GuiltyContextReset = 33363,
        InnocentContextReset = 33364,
        UnknownContextReset = 33365
    }

    public enum ErrorCode : uint
    {
        NoError = 0,
        InvalidEnum = 1280,
        InvalidValue = 1281,
        InvalidOperation = 1282,
        StackOverflow = 1283,
        StackUnderflow = 1284,
        OutOfMemory = 1285,
        InvalidFramebufferOperation = 1286,
        InvalidFramebufferOperationExt = 1286,
        TableTooLarge = 32817,
        TableTooLargeExt = 32817,
        TextureTooLargeExt = 32869
    }

    public enum TextureSwizzle : uint
    {
        Zero = 0,
        One = 1,
        Red = 6403,
        Green = 6404,
        Blue = 6405,
        Alpha = 6406
    }

    public enum StencilOp : uint
    {
        Zero = 0,
        Invert = 5386,
        Keep = 7680,
        Replace = 7681,
        Incr = 7682,
        Decr = 7683,
        IncrWrap = 34055,
        DecrWrap = 34056
    }

    public enum BlendingFactor : uint
    {
        Zero = 0,
        One = 1,
        SrcColor = 768,
        OneMinusSrcColor = 769,
        SrcAlpha = 770,
        OneMinusSrcAlpha = 771,
        DstAlpha = 772,
        OneMinusDstAlpha = 773,
        DstColor = 774,
        OneMinusDstColor = 775,
        SrcAlphaSaturate = 776,
        ConstantColor = 32769,
        OneMinusConstantColor = 32770,
        ConstantAlpha = 32771,
        OneMinusConstantAlpha = 32772,
        Src1Alpha = 34185,
        Src1Color = 35065,
        OneMinusSrc1Color = 35066,
        OneMinusSrc1Alpha = 35067
    }

    public enum SyncBehaviorFlags : uint
    {
        None = 0
    }

    public enum TextureCompareMode : uint
    {
        None = 0,
        CompareRToTexture = 34894,
        CompareRefToTexture = 34894
    }

    public enum PathColorFormat : uint
    {
        None = 0,
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410,
        Intensity = 32841
    }

    public enum CombinerBiasNV : uint
    {
        None = 0,
        BiasByNegativeOneHalfNv = 34113
    }

    public enum CombinerScaleNV : uint
    {
        None = 0,
        ScaleByTwoNv = 34110,
        ScaleByFourNv = 34111,
        ScaleByOneHalfNv = 34112
    }

    public enum DrawBufferMode : uint
    {
        None = 0,
        FrontLeft = 1024,
        FrontRight = 1025,
        BackLeft = 1026,
        BackRight = 1027,
        Front = 1028,
        Back = 1029,
        Left = 1030,
        Right = 1031,
        FrontAndBack = 1032,
        Aux0 = 1033,
        Aux1 = 1034,
        Aux2 = 1035,
        Aux3 = 1036,
        ColorAttachment0 = 36064,
        ColorAttachment1 = 36065,
        ColorAttachment2 = 36066,
        ColorAttachment3 = 36067,
        ColorAttachment4 = 36068,
        ColorAttachment5 = 36069,
        ColorAttachment6 = 36070,
        ColorAttachment7 = 36071,
        ColorAttachment8 = 36072,
        ColorAttachment9 = 36073,
        ColorAttachment10 = 36074,
        ColorAttachment11 = 36075,
        ColorAttachment12 = 36076,
        ColorAttachment13 = 36077,
        ColorAttachment14 = 36078,
        ColorAttachment15 = 36079,
        ColorAttachment16 = 36080,
        ColorAttachment17 = 36081,
        ColorAttachment18 = 36082,
        ColorAttachment19 = 36083,
        ColorAttachment20 = 36084,
        ColorAttachment21 = 36085,
        ColorAttachment22 = 36086,
        ColorAttachment23 = 36087,
        ColorAttachment24 = 36088,
        ColorAttachment25 = 36089,
        ColorAttachment26 = 36090,
        ColorAttachment27 = 36091,
        ColorAttachment28 = 36092,
        ColorAttachment29 = 36093,
        ColorAttachment30 = 36094,
        ColorAttachment31 = 36095
    }

    public enum PixelTexGenMode : uint
    {
        None = 0,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410
    }

    public enum ReadBufferMode : uint
    {
        None = 0,
        FrontLeft = 1024,
        FrontRight = 1025,
        BackLeft = 1026,
        BackRight = 1027,
        Front = 1028,
        Back = 1029,
        Left = 1030,
        Right = 1031,
        Aux0 = 1033,
        Aux1 = 1034,
        Aux2 = 1035,
        Aux3 = 1036,
        ColorAttachment0 = 36064,
        ColorAttachment1 = 36065,
        ColorAttachment2 = 36066,
        ColorAttachment3 = 36067,
        ColorAttachment4 = 36068,
        ColorAttachment5 = 36069,
        ColorAttachment6 = 36070,
        ColorAttachment7 = 36071,
        ColorAttachment8 = 36072,
        ColorAttachment9 = 36073,
        ColorAttachment10 = 36074,
        ColorAttachment11 = 36075,
        ColorAttachment12 = 36076,
        ColorAttachment13 = 36077,
        ColorAttachment14 = 36078,
        ColorAttachment15 = 36079
    }

    public enum ColorBuffer : uint
    {
        None = 0,
        FrontLeft = 1024,
        FrontRight = 1025,
        BackLeft = 1026,
        BackRight = 1027,
        Front = 1028,
        Back = 1029,
        Left = 1030,
        Right = 1031,
        FrontAndBack = 1032,
        ColorAttachment0 = 36064,
        ColorAttachment1 = 36065,
        ColorAttachment2 = 36066,
        ColorAttachment3 = 36067,
        ColorAttachment4 = 36068,
        ColorAttachment5 = 36069,
        ColorAttachment6 = 36070,
        ColorAttachment7 = 36071,
        ColorAttachment8 = 36072,
        ColorAttachment9 = 36073,
        ColorAttachment10 = 36074,
        ColorAttachment11 = 36075,
        ColorAttachment12 = 36076,
        ColorAttachment13 = 36077,
        ColorAttachment14 = 36078,
        ColorAttachment15 = 36079,
        ColorAttachment16 = 36080,
        ColorAttachment17 = 36081,
        ColorAttachment18 = 36082,
        ColorAttachment19 = 36083,
        ColorAttachment20 = 36084,
        ColorAttachment21 = 36085,
        ColorAttachment22 = 36086,
        ColorAttachment23 = 36087,
        ColorAttachment24 = 36088,
        ColorAttachment25 = 36089,
        ColorAttachment26 = 36090,
        ColorAttachment27 = 36091,
        ColorAttachment28 = 36092,
        ColorAttachment29 = 36093,
        ColorAttachment30 = 36094,
        ColorAttachment31 = 36095
    }

    public enum PathGenMode : uint
    {
        None = 0,
        EyeLinear = 9216,
        ObjectLinear = 9217,
        Constant = 34166,
        PathObjectBoundingBoxNv = 37002
    }

    public enum PathTransformType : uint
    {
        None = 0,
        TranslateXNv = 37006,
        TranslateYNv = 37007,
        Translate2dNv = 37008,
        Translate3dNv = 37009,
        Affine2dNv = 37010,
        Affine3dNv = 37012,
        TransposeAffine2dNv = 37014,
        TransposeAffine3dNv = 37016
    }

    public enum PrimitiveType : uint
    {
        Points = 0,
        Lines = 1,
        LineLoop = 2,
        LineStrip = 3,
        Triangles = 4,
        TriangleStrip = 5,
        TriangleFan = 6,
        Quads = 7,
        QuadStrip = 8,
        Polygon = 9,
        LinesAdjacency = 10,
        LinesAdjacencyArb = 10,
        LinesAdjacencyExt = 10,
        LineStripAdjacency = 11,
        LineStripAdjacencyArb = 11,
        LineStripAdjacencyExt = 11,
        TrianglesAdjacency = 12,
        TrianglesAdjacencyArb = 12,
        TrianglesAdjacencyExt = 12,
        TriangleStripAdjacency = 13,
        TriangleStripAdjacencyArb = 13,
        TriangleStripAdjacencyExt = 13,
        Patches = 14
    }

    public enum AccumOp : uint
    {
        Accum = 256,
        Load = 257,
        Return = 258,
        Mult = 259,
        Add = 260
    }

    public enum TextureEnvMode : uint
    {
        Add = 260,
        Blend = 3042,
        Modulate = 8448,
        Decal = 8449,
        ReplaceExt = 32866,
        TextureEnvBiasSgix = 32958
    }

    public enum LightEnvModeSGIX : uint
    {
        Add = 260,
        Replace = 7681,
        Modulate = 8448
    }

    public enum StencilFunction : uint
    {
        Never = 512,
        Less = 513,
        Equal = 514,
        Lequal = 515,
        Greater = 516,
        Notequal = 517,
        Gequal = 518,
        Always = 519
    }

    public enum IndexFunctionEXT : uint
    {
        Never = 512,
        Less = 513,
        Equal = 514,
        Lequal = 515,
        Greater = 516,
        Notequal = 517,
        Gequal = 518,
        Always = 519
    }

    public enum AlphaFunction : uint
    {
        Never = 512,
        Less = 513,
        Equal = 514,
        Lequal = 515,
        Greater = 516,
        Notequal = 517,
        Gequal = 518,
        Always = 519
    }

    public enum DepthFunction : uint
    {
        Never = 512,
        Less = 513,
        Equal = 514,
        Lequal = 515,
        Greater = 516,
        Notequal = 517,
        Gequal = 518,
        Always = 519
    }

    public enum ColorMaterialFace : uint
    {
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032
    }

    public enum CullFaceMode : uint
    {
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032
    }

    public enum StencilFaceDirection : uint
    {
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032
    }

    public enum MaterialFace : uint
    {
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032
    }

    public enum FeedbackType : uint
    {
        _2d = 1536,
        _3d = 1537,
        _3dColor = 1538,
        _3dColorTexture = 1539,
        _4dColorTexture = 1540
    }

    public enum FeedBackToken : uint
    {
        PassThroughToken = 1792,
        PointToken = 1793,
        LineToken = 1794,
        PolygonToken = 1795,
        BitmapToken = 1796,
        DrawPixelToken = 1797,
        CopyPixelToken = 1798,
        LineResetToken = 1799
    }

    public enum FogMode : uint
    {
        Exp = 2048,
        Exp2 = 2049,
        Linear = 9729,
        FogFuncSgis = 33066
    }

    public enum FrontFaceDirection : uint
    {
        Cw = 2304,
        Ccw = 2305
    }

    public enum MapQuery : uint
    {
        Coeff = 2560,
        Order = 2561,
        Domain = 2562
    }

    public enum GetMapQuery : uint
    {
        Coeff = 2560,
        Order = 2561,
        Domain = 2562
    }

    public enum GetPName : uint
    {
        CurrentColor = 2816,
        CurrentIndex = 2817,
        CurrentNormal = 2818,
        CurrentTextureCoords = 2819,
        CurrentRasterColor = 2820,
        CurrentRasterIndex = 2821,
        CurrentRasterTextureCoords = 2822,
        CurrentRasterPosition = 2823,
        CurrentRasterPositionValid = 2824,
        CurrentRasterDistance = 2825,
        PointSmooth = 2832,
        PointSize = 2833,
        PointSizeRange = 2834,
        SmoothPointSizeRange = 2834,
        PointSizeGranularity = 2835,
        SmoothPointSizeGranularity = 2835,
        LineSmooth = 2848,
        LineWidth = 2849,
        LineWidthRange = 2850,
        SmoothLineWidthRange = 2850,
        LineWidthGranularity = 2851,
        SmoothLineWidthGranularity = 2851,
        LineStipple = 2852,
        LineStipplePattern = 2853,
        LineStippleRepeat = 2854,
        ListMode = 2864,
        MaxListNesting = 2865,
        ListBase = 2866,
        ListIndex = 2867,
        PolygonMode = 2880,
        PolygonSmooth = 2881,
        PolygonStipple = 2882,
        EdgeFlag = 2883,
        CullFace = 2884,
        CullFaceMode = 2885,
        FrontFace = 2886,
        Lighting = 2896,
        LightModelLocalViewer = 2897,
        LightModelTwoSide = 2898,
        LightModelAmbient = 2899,
        ShadeModel = 2900,
        ColorMaterialFace = 2901,
        ColorMaterialParameter = 2902,
        ColorMaterial = 2903,
        Fog = 2912,
        FogIndex = 2913,
        FogDensity = 2914,
        FogStart = 2915,
        FogEnd = 2916,
        FogMode = 2917,
        FogColor = 2918,
        DepthRange = 2928,
        DepthTest = 2929,
        DepthWritemask = 2930,
        DepthClearValue = 2931,
        DepthFunc = 2932,
        AccumClearValue = 2944,
        StencilTest = 2960,
        StencilClearValue = 2961,
        StencilFunc = 2962,
        StencilValueMask = 2963,
        StencilFail = 2964,
        StencilPassDepthFail = 2965,
        StencilPassDepthPass = 2966,
        StencilRef = 2967,
        StencilWritemask = 2968,
        MatrixMode = 2976,
        Normalize = 2977,
        Viewport = 2978,
        ModelviewStackDepth = 2979,
        Modelview0StackDepthExt = 2979,
        ProjectionStackDepth = 2980,
        TextureStackDepth = 2981,
        ModelviewMatrix = 2982,
        Modelview0MatrixExt = 2982,
        ProjectionMatrix = 2983,
        TextureMatrix = 2984,
        AttribStackDepth = 2992,
        ClientAttribStackDepth = 2993,
        AlphaTest = 3008,
        AlphaTestFunc = 3009,
        AlphaTestRef = 3010,
        Dither = 3024,
        BlendDst = 3040,
        BlendSrc = 3041,
        Blend = 3042,
        LogicOpMode = 3056,
        LogicOp = 3057,
        IndexLogicOp = 3057,
        ColorLogicOp = 3058,
        AuxBuffers = 3072,
        DrawBuffer = 3073,
        ReadBuffer = 3074,
        ScissorBox = 3088,
        ScissorTest = 3089,
        IndexClearValue = 3104,
        IndexWritemask = 3105,
        ColorClearValue = 3106,
        ColorWritemask = 3107,
        IndexMode = 3120,
        RgbaMode = 3121,
        Doublebuffer = 3122,
        Stereo = 3123,
        RenderMode = 3136,
        PerspectiveCorrectionHint = 3152,
        PointSmoothHint = 3153,
        LineSmoothHint = 3154,
        PolygonSmoothHint = 3155,
        FogHint = 3156,
        TextureGenS = 3168,
        TextureGenT = 3169,
        TextureGenR = 3170,
        TextureGenQ = 3171,
        PixelMapIToISize = 3248,
        PixelMapSToSSize = 3249,
        PixelMapIToRSize = 3250,
        PixelMapIToGSize = 3251,
        PixelMapIToBSize = 3252,
        PixelMapIToASize = 3253,
        PixelMapRToRSize = 3254,
        PixelMapGToGSize = 3255,
        PixelMapBToBSize = 3256,
        PixelMapAToASize = 3257,
        UnpackSwapBytes = 3312,
        UnpackLsbFirst = 3313,
        UnpackRowLength = 3314,
        UnpackSkipRows = 3315,
        UnpackSkipPixels = 3316,
        UnpackAlignment = 3317,
        PackSwapBytes = 3328,
        PackLsbFirst = 3329,
        PackRowLength = 3330,
        PackSkipRows = 3331,
        PackSkipPixels = 3332,
        PackAlignment = 3333,
        MapColor = 3344,
        MapStencil = 3345,
        IndexShift = 3346,
        IndexOffset = 3347,
        RedScale = 3348,
        RedBias = 3349,
        ZoomX = 3350,
        ZoomY = 3351,
        GreenScale = 3352,
        GreenBias = 3353,
        BlueScale = 3354,
        BlueBias = 3355,
        AlphaScale = 3356,
        AlphaBias = 3357,
        DepthScale = 3358,
        DepthBias = 3359,
        MaxEvalOrder = 3376,
        MaxLights = 3377,
        MaxClipPlanes = 3378,
        MaxClipDistances = 3378,
        MaxTextureSize = 3379,
        MaxPixelMapTable = 3380,
        MaxAttribStackDepth = 3381,
        MaxModelviewStackDepth = 3382,
        MaxNameStackDepth = 3383,
        MaxProjectionStackDepth = 3384,
        MaxTextureStackDepth = 3385,
        MaxViewportDims = 3386,
        MaxClientAttribStackDepth = 3387,
        SubpixelBits = 3408,
        IndexBits = 3409,
        RedBits = 3410,
        GreenBits = 3411,
        BlueBits = 3412,
        AlphaBits = 3413,
        DepthBits = 3414,
        StencilBits = 3415,
        AccumRedBits = 3416,
        AccumGreenBits = 3417,
        AccumBlueBits = 3418,
        AccumAlphaBits = 3419,
        NameStackDepth = 3440,
        AutoNormal = 3456,
        Map1Color4 = 3472,
        Map1Index = 3473,
        Map1Normal = 3474,
        Map1TextureCoord1 = 3475,
        Map1TextureCoord2 = 3476,
        Map1TextureCoord3 = 3477,
        Map1TextureCoord4 = 3478,
        Map1Vertex3 = 3479,
        Map1Vertex4 = 3480,
        Map2Color4 = 3504,
        Map2Index = 3505,
        Map2Normal = 3506,
        Map2TextureCoord1 = 3507,
        Map2TextureCoord2 = 3508,
        Map2TextureCoord3 = 3509,
        Map2TextureCoord4 = 3510,
        Map2Vertex3 = 3511,
        Map2Vertex4 = 3512,
        Map1GridDomain = 3536,
        Map1GridSegments = 3537,
        Map2GridDomain = 3538,
        Map2GridSegments = 3539,
        Texture1d = 3552,
        Texture2d = 3553,
        FeedbackBufferSize = 3569,
        FeedbackBufferType = 3570,
        SelectionBufferSize = 3572,
        PolygonOffsetUnits = 10752,
        PolygonOffsetPoint = 10753,
        PolygonOffsetLine = 10754,
        ClipPlane0 = 12288,
        ClipPlane1 = 12289,
        ClipPlane2 = 12290,
        ClipPlane3 = 12291,
        ClipPlane4 = 12292,
        ClipPlane5 = 12293,
        Light0 = 16384,
        Light1 = 16385,
        Light2 = 16386,
        Light3 = 16387,
        Light4 = 16388,
        Light5 = 16389,
        Light6 = 16390,
        Light7 = 16391,
        BlendColor = 32773,
        BlendColorExt = 32773,
        BlendEquationRgb = 32777,
        BlendEquationExt = 32777,
        PackCmykHintExt = 32782,
        UnpackCmykHintExt = 32783,
        Convolution1dExt = 32784,
        Convolution2dExt = 32785,
        Separable2dExt = 32786,
        PostConvolutionRedScaleExt = 32796,
        PostConvolutionGreenScaleExt = 32797,
        PostConvolutionBlueScaleExt = 32798,
        PostConvolutionAlphaScaleExt = 32799,
        PostConvolutionRedBiasExt = 32800,
        PostConvolutionGreenBiasExt = 32801,
        PostConvolutionBlueBiasExt = 32802,
        PostConvolutionAlphaBiasExt = 32803,
        HistogramExt = 32804,
        MinmaxExt = 32814,
        PolygonOffsetFill = 32823,
        PolygonOffsetFactor = 32824,
        PolygonOffsetBiasExt = 32825,
        RescaleNormalExt = 32826,
        TextureBinding1d = 32872,
        TextureBinding2d = 32873,
        TextureBinding3d = 32874,
        Texture3dBindingExt = 32874,
        PackSkipImages = 32875,
        PackSkipImagesExt = 32875,
        PackImageHeight = 32876,
        PackImageHeightExt = 32876,
        UnpackSkipImages = 32877,
        UnpackSkipImagesExt = 32877,
        UnpackImageHeight = 32878,
        UnpackImageHeightExt = 32878,
        Texture3dExt = 32879,
        Max3dTextureSize = 32883,
        Max3dTextureSizeExt = 32883,
        VertexArray = 32884,
        NormalArray = 32885,
        ColorArray = 32886,
        IndexArray = 32887,
        TextureCoordArray = 32888,
        EdgeFlagArray = 32889,
        VertexArraySize = 32890,
        VertexArrayType = 32891,
        VertexArrayStride = 32892,
        VertexArrayCountExt = 32893,
        NormalArrayType = 32894,
        NormalArrayStride = 32895,
        NormalArrayCountExt = 32896,
        ColorArraySize = 32897,
        ColorArrayType = 32898,
        ColorArrayStride = 32899,
        ColorArrayCountExt = 32900,
        IndexArrayType = 32901,
        IndexArrayStride = 32902,
        IndexArrayCountExt = 32903,
        TextureCoordArraySize = 32904,
        TextureCoordArrayType = 32905,
        TextureCoordArrayStride = 32906,
        TextureCoordArrayCountExt = 32907,
        EdgeFlagArrayStride = 32908,
        EdgeFlagArrayCountExt = 32909,
        InterlaceSgix = 32916,
        DetailTexture2dBindingSgis = 32918,
        MultisampleSgis = 32925,
        SampleAlphaToMaskSgis = 32926,
        SampleAlphaToOneSgis = 32927,
        SampleMaskSgis = 32928,
        SampleBuffers = 32936,
        SampleBuffersSgis = 32936,
        Samples = 32937,
        SamplesSgis = 32937,
        SampleCoverageValue = 32938,
        SampleMaskValueSgis = 32938,
        SampleCoverageInvert = 32939,
        SampleMaskInvertSgis = 32939,
        SamplePatternSgis = 32940,
        ColorMatrixSgi = 32945,
        ColorMatrixStackDepthSgi = 32946,
        MaxColorMatrixStackDepthSgi = 32947,
        PostColorMatrixRedScaleSgi = 32948,
        PostColorMatrixGreenScaleSgi = 32949,
        PostColorMatrixBlueScaleSgi = 32950,
        PostColorMatrixAlphaScaleSgi = 32951,
        PostColorMatrixRedBiasSgi = 32952,
        PostColorMatrixGreenBiasSgi = 32953,
        PostColorMatrixBlueBiasSgi = 32954,
        PostColorMatrixAlphaBiasSgi = 32955,
        TextureColorTableSgi = 32956,
        BlendDstRgb = 32968,
        BlendSrcRgb = 32969,
        BlendDstAlpha = 32970,
        BlendSrcAlpha = 32971,
        ColorTableSgi = 32976,
        PostConvolutionColorTableSgi = 32977,
        PostColorMatrixColorTableSgi = 32978,
        MaxElementsVertices = 33000,
        MaxElementsIndices = 33001,
        PointSizeMinSgis = 33062,
        PointSizeMaxSgis = 33063,
        PointFadeThresholdSize = 33064,
        PointFadeThresholdSizeSgis = 33064,
        DistanceAttenuationSgis = 33065,
        FogFuncPointsSgis = 33067,
        MaxFogFuncPointsSgis = 33068,
        PackSkipVolumesSgis = 33072,
        PackImageDepthSgis = 33073,
        UnpackSkipVolumesSgis = 33074,
        UnpackImageDepthSgis = 33075,
        Texture4dSgis = 33076,
        Max4dTextureSizeSgis = 33080,
        PixelTexGenSgix = 33081,
        PixelTileBestAlignmentSgix = 33086,
        PixelTileCacheIncrementSgix = 33087,
        PixelTileWidthSgix = 33088,
        PixelTileHeightSgix = 33089,
        PixelTileGridWidthSgix = 33090,
        PixelTileGridHeightSgix = 33091,
        PixelTileGridDepthSgix = 33092,
        PixelTileCacheSizeSgix = 33093,
        SpriteSgix = 33096,
        SpriteModeSgix = 33097,
        SpriteAxisSgix = 33098,
        SpriteTranslationSgix = 33099,
        Texture4dBindingSgis = 33103,
        MaxClipmapDepthSgix = 33143,
        MaxClipmapVirtualDepthSgix = 33144,
        PostTextureFilterBiasRangeSgix = 33147,
        PostTextureFilterScaleRangeSgix = 33148,
        ReferencePlaneSgix = 33149,
        ReferencePlaneEquationSgix = 33150,
        IrInstrument1Sgix = 33151,
        InstrumentMeasurementsSgix = 33153,
        CalligraphicFragmentSgix = 33155,
        FramezoomSgix = 33163,
        FramezoomFactorSgix = 33164,
        MaxFramezoomFactorSgix = 33165,
        GenerateMipmapHintSgis = 33170,
        DeformationsMaskSgix = 33174,
        FogOffsetSgix = 33176,
        FogOffsetValueSgix = 33177,
        LightModelColorControl = 33272,
        SharedTexturePaletteExt = 33275,
        MajorVersion = 33307,
        MinorVersion = 33308,
        NumExtensions = 33309,
        ContextFlags = 33310,
        ProgramPipelineBinding = 33370,
        MaxViewports = 33371,
        ViewportSubpixelBits = 33372,
        ViewportBoundsRange = 33373,
        LayerProvokingVertex = 33374,
        ViewportIndexProvokingVertex = 33375,
        MaxComputeUniformComponents = 33379,
        MaxComputeAtomicCounterBuffers = 33380,
        MaxComputeAtomicCounters = 33381,
        MaxCombinedComputeUniformComponents = 33382,
        MaxDebugGroupStackDepth = 33388,
        DebugGroupStackDepth = 33389,
        MaxUniformLocations = 33390,
        VertexBindingDivisor = 33494,
        VertexBindingOffset = 33495,
        VertexBindingStride = 33496,
        MaxVertexAttribRelativeOffset = 33497,
        MaxVertexAttribBindings = 33498,
        MaxLabelLength = 33512,
        ConvolutionHintSgix = 33558,
        AsyncMarkerSgix = 33577,
        PixelTexGenModeSgix = 33579,
        AsyncHistogramSgix = 33580,
        MaxAsyncHistogramSgix = 33581,
        PixelTextureSgis = 33619,
        AsyncTexImageSgix = 33628,
        AsyncDrawPixelsSgix = 33629,
        AsyncReadPixelsSgix = 33630,
        MaxAsyncTexImageSgix = 33631,
        MaxAsyncDrawPixelsSgix = 33632,
        MaxAsyncReadPixelsSgix = 33633,
        VertexPreclipSgix = 33774,
        VertexPreclipHintSgix = 33775,
        FragmentLightingSgix = 33792,
        FragmentColorMaterialSgix = 33793,
        FragmentColorMaterialFaceSgix = 33794,
        FragmentColorMaterialParameterSgix = 33795,
        MaxFragmentLightsSgix = 33796,
        MaxActiveLightsSgix = 33797,
        LightEnvModeSgix = 33799,
        FragmentLightModelLocalViewerSgix = 33800,
        FragmentLightModelTwoSideSgix = 33801,
        FragmentLightModelAmbientSgix = 33802,
        FragmentLightModelNormalInterpolationSgix = 33803,
        FragmentLight0Sgix = 33804,
        PackResampleSgix = 33838,
        UnpackResampleSgix = 33839,
        AliasedPointSizeRange = 33901,
        AliasedLineWidthRange = 33902,
        ActiveTexture = 34016,
        MaxRenderbufferSize = 34024,
        TextureCompressionHint = 34031,
        TextureBindingRectangle = 34038,
        MaxRectangleTextureSize = 34040,
        MaxTextureLodBias = 34045,
        TextureBindingCubeMap = 34068,
        MaxCubeMapTextureSize = 34076,
        PackSubsampleRateSgix = 34208,
        UnpackSubsampleRateSgix = 34209,
        VertexArrayBinding = 34229,
        ProgramPointSize = 34370,
        NumCompressedTextureFormats = 34466,
        CompressedTextureFormats = 34467,
        NumProgramBinaryFormats = 34814,
        ProgramBinaryFormats = 34815,
        StencilBackFunc = 34816,
        StencilBackFail = 34817,
        StencilBackPassDepthFail = 34818,
        StencilBackPassDepthPass = 34819,
        MaxDrawBuffers = 34852,
        BlendEquationAlpha = 34877,
        MaxVertexAttribs = 34921,
        MaxTextureImageUnits = 34930,
        ArrayBufferBinding = 34964,
        ElementArrayBufferBinding = 34965,
        PixelPackBufferBinding = 35053,
        PixelUnpackBufferBinding = 35055,
        MaxDualSourceDrawBuffers = 35068,
        MaxArrayTextureLayers = 35071,
        MinProgramTexelOffset = 35076,
        MaxProgramTexelOffset = 35077,
        SamplerBinding = 35097,
        UniformBufferBinding = 35368,
        UniformBufferStart = 35369,
        UniformBufferSize = 35370,
        MaxVertexUniformBlocks = 35371,
        MaxGeometryUniformBlocks = 35372,
        MaxFragmentUniformBlocks = 35373,
        MaxCombinedUniformBlocks = 35374,
        MaxUniformBufferBindings = 35375,
        MaxUniformBlockSize = 35376,
        MaxCombinedVertexUniformComponents = 35377,
        MaxCombinedGeometryUniformComponents = 35378,
        MaxCombinedFragmentUniformComponents = 35379,
        UniformBufferOffsetAlignment = 35380,
        MaxFragmentUniformComponents = 35657,
        MaxVertexUniformComponents = 35658,
        MaxVaryingFloats = 35659,
        MaxVaryingComponents = 35659,
        MaxVertexTextureImageUnits = 35660,
        MaxCombinedTextureImageUnits = 35661,
        FragmentShaderDerivativeHint = 35723,
        CurrentProgram = 35725,
        ImplementationColorReadType = 35738,
        ImplementationColorReadFormat = 35739,
        TextureBinding1dArray = 35868,
        TextureBinding2dArray = 35869,
        MaxGeometryTextureImageUnits = 35881,
        MaxTextureBufferSize = 35883,
        TextureBindingBuffer = 35884,
        TransformFeedbackBufferStart = 35972,
        TransformFeedbackBufferSize = 35973,
        TransformFeedbackBufferBinding = 35983,
        StencilBackRef = 36003,
        StencilBackValueMask = 36004,
        StencilBackWritemask = 36005,
        DrawFramebufferBinding = 36006,
        RenderbufferBinding = 36007,
        ReadFramebufferBinding = 36010,
        MaxElementIndex = 36203,
        MaxGeometryUniformComponents = 36319,
        ShaderBinaryFormats = 36344,
        NumShaderBinaryFormats = 36345,
        ShaderCompiler = 36346,
        MaxVertexUniformVectors = 36347,
        MaxVaryingVectors = 36348,
        MaxFragmentUniformVectors = 36349,
        Timestamp = 36392,
        ProvokingVertex = 36431,
        MaxSampleMaskWords = 36441,
        MaxTessControlUniformBlocks = 36489,
        MaxTessEvaluationUniformBlocks = 36490,
        PrimitiveRestartIndex = 36766,
        MinMapBufferAlignment = 37052,
        ShaderStorageBufferBinding = 37075,
        ShaderStorageBufferStart = 37076,
        ShaderStorageBufferSize = 37077,
        MaxVertexShaderStorageBlocks = 37078,
        MaxGeometryShaderStorageBlocks = 37079,
        MaxTessControlShaderStorageBlocks = 37080,
        MaxTessEvaluationShaderStorageBlocks = 37081,
        MaxFragmentShaderStorageBlocks = 37082,
        MaxComputeShaderStorageBlocks = 37083,
        MaxCombinedShaderStorageBlocks = 37084,
        MaxShaderStorageBufferBindings = 37085,
        ShaderStorageBufferOffsetAlignment = 37087,
        MaxComputeWorkGroupInvocations = 37099,
        DispatchIndirectBufferBinding = 37103,
        TextureBinding2dMultisample = 37124,
        TextureBinding2dMultisampleArray = 37125,
        MaxColorTextureSamples = 37134,
        MaxDepthTextureSamples = 37135,
        MaxIntegerSamples = 37136,
        MaxServerWaitTimeout = 37137,
        MaxVertexOutputComponents = 37154,
        MaxGeometryInputComponents = 37155,
        MaxGeometryOutputComponents = 37156,
        MaxFragmentInputComponents = 37157,
        ContextProfileMask = 37158,
        TextureBufferOffsetAlignment = 37279,
        MaxComputeUniformBlocks = 37307,
        MaxComputeTextureImageUnits = 37308,
        MaxComputeWorkGroupCount = 37310,
        MaxComputeWorkGroupSize = 37311,
        MaxVertexAtomicCounters = 37586,
        MaxTessControlAtomicCounters = 37587,
        MaxTessEvaluationAtomicCounters = 37588,
        MaxGeometryAtomicCounters = 37589,
        MaxFragmentAtomicCounters = 37590,
        MaxCombinedAtomicCounters = 37591,
        MaxFramebufferWidth = 37653,
        MaxFramebufferHeight = 37654,
        MaxFramebufferLayers = 37655,
        MaxFramebufferSamples = 37656,
        NumDeviceUuidsExt = 38294,
        DeviceUuidExt = 38295,
        DriverUuidExt = 38296,
        DeviceLuidExt = 38297,
        DeviceNodeMaskExt = 38298,
        ShadingRateImagePerPrimitiveNv = 38321,
        ShadingRateImagePaletteCountNv = 38322,
        MaxTimelineSemaphoreValueDifferenceNv = 38326
    }

    public enum VertexShaderTextureUnitParameter : uint
    {
        CurrentTextureCoords = 2819,
        TextureMatrix = 2984
    }

    public enum EnableCap : uint
    {
        PointSmooth = 2832,
        LineSmooth = 2848,
        LineStipple = 2852,
        PolygonSmooth = 2881,
        PolygonStipple = 2882,
        CullFace = 2884,
        Lighting = 2896,
        ColorMaterial = 2903,
        Fog = 2912,
        DepthTest = 2929,
        StencilTest = 2960,
        Normalize = 2977,
        AlphaTest = 3008,
        Dither = 3024,
        Blend = 3042,
        IndexLogicOp = 3057,
        ColorLogicOp = 3058,
        ScissorTest = 3089,
        TextureGenS = 3168,
        TextureGenT = 3169,
        TextureGenR = 3170,
        TextureGenQ = 3171,
        AutoNormal = 3456,
        Map1Color4 = 3472,
        Map1Index = 3473,
        Map1Normal = 3474,
        Map1TextureCoord1 = 3475,
        Map1TextureCoord2 = 3476,
        Map1TextureCoord3 = 3477,
        Map1TextureCoord4 = 3478,
        Map1Vertex3 = 3479,
        Map1Vertex4 = 3480,
        Map2Color4 = 3504,
        Map2Index = 3505,
        Map2Normal = 3506,
        Map2TextureCoord1 = 3507,
        Map2TextureCoord2 = 3508,
        Map2TextureCoord3 = 3509,
        Map2TextureCoord4 = 3510,
        Map2Vertex3 = 3511,
        Map2Vertex4 = 3512,
        Texture1d = 3552,
        Texture2d = 3553,
        PolygonOffsetPoint = 10753,
        PolygonOffsetLine = 10754,
        ClipPlane0 = 12288,
        ClipDistance0 = 12288,
        ClipPlane1 = 12289,
        ClipDistance1 = 12289,
        ClipPlane2 = 12290,
        ClipDistance2 = 12290,
        ClipPlane3 = 12291,
        ClipDistance3 = 12291,
        ClipPlane4 = 12292,
        ClipDistance4 = 12292,
        ClipPlane5 = 12293,
        ClipDistance5 = 12293,
        ClipDistance6 = 12294,
        ClipDistance7 = 12295,
        Light0 = 16384,
        Light1 = 16385,
        Light2 = 16386,
        Light3 = 16387,
        Light4 = 16388,
        Light5 = 16389,
        Light6 = 16390,
        Light7 = 16391,
        Convolution1dExt = 32784,
        Convolution2dExt = 32785,
        Separable2dExt = 32786,
        HistogramExt = 32804,
        MinmaxExt = 32814,
        PolygonOffsetFill = 32823,
        RescaleNormalExt = 32826,
        Texture3dExt = 32879,
        VertexArray = 32884,
        NormalArray = 32885,
        ColorArray = 32886,
        IndexArray = 32887,
        TextureCoordArray = 32888,
        EdgeFlagArray = 32889,
        InterlaceSgix = 32916,
        Multisample = 32925,
        MultisampleSgis = 32925,
        SampleAlphaToCoverage = 32926,
        SampleAlphaToMaskSgis = 32926,
        SampleAlphaToOne = 32927,
        SampleAlphaToOneSgis = 32927,
        SampleCoverage = 32928,
        SampleMaskSgis = 32928,
        TextureColorTableSgi = 32956,
        ColorTable = 32976,
        ColorTableSgi = 32976,
        PostConvolutionColorTable = 32977,
        PostConvolutionColorTableSgi = 32977,
        PostColorMatrixColorTable = 32978,
        PostColorMatrixColorTableSgi = 32978,
        Texture4dSgis = 33076,
        PixelTexGenSgix = 33081,
        SpriteSgix = 33096,
        ReferencePlaneSgix = 33149,
        IrInstrument1Sgix = 33151,
        CalligraphicFragmentSgix = 33155,
        FramezoomSgix = 33163,
        FogOffsetSgix = 33176,
        SharedTexturePaletteExt = 33275,
        DebugOutputSynchronous = 33346,
        AsyncHistogramSgix = 33580,
        PixelTextureSgis = 33619,
        AsyncTexImageSgix = 33628,
        AsyncDrawPixelsSgix = 33629,
        AsyncReadPixelsSgix = 33630,
        FragmentLightingSgix = 33792,
        FragmentColorMaterialSgix = 33793,
        FragmentLight0Sgix = 33804,
        FragmentLight1Sgix = 33805,
        FragmentLight2Sgix = 33806,
        FragmentLight3Sgix = 33807,
        FragmentLight4Sgix = 33808,
        FragmentLight5Sgix = 33809,
        FragmentLight6Sgix = 33810,
        FragmentLight7Sgix = 33811,
        ProgramPointSize = 34370,
        DepthClamp = 34383,
        TextureCubeMapSeamless = 34895,
        SampleShading = 35894,
        RasterizerDiscard = 35977,
        PrimitiveRestartFixedIndex = 36201,
        FramebufferSrgb = 36281,
        SampleMask = 36433,
        PrimitiveRestart = 36765,
        DebugOutput = 37600,
        ShadingRateImagePerPrimitiveNv = 38321
    }

    public enum LightModelParameter : uint
    {
        LightModelLocalViewer = 2897,
        LightModelTwoSide = 2898,
        LightModelAmbient = 2899,
        LightModelColorControl = 33272,
        LightModelColorControlExt = 33272
    }

    public enum FogPName : uint
    {
        FogIndex = 2913,
        FogDensity = 2914,
        FogStart = 2915,
        FogEnd = 2916,
        FogMode = 2917,
        FogCoordSrc = 33872
    }

    public enum FogParameter : uint
    {
        FogIndex = 2913,
        FogDensity = 2914,
        FogStart = 2915,
        FogEnd = 2916,
        FogMode = 2917,
        FogColor = 2918,
        FogOffsetValueSgix = 33177
    }

    public enum GetFramebufferParameter : uint
    {
        Doublebuffer = 3122,
        Stereo = 3123,
        SampleBuffers = 32936,
        Samples = 32937,
        ImplementationColorReadType = 35738,
        ImplementationColorReadFormat = 35739,
        FramebufferDefaultWidth = 37648,
        FramebufferDefaultHeight = 37649,
        FramebufferDefaultLayers = 37650,
        FramebufferDefaultSamples = 37651,
        FramebufferDefaultFixedSampleLocations = 37652
    }

    public enum HintTarget : uint
    {
        PerspectiveCorrectionHint = 3152,
        PointSmoothHint = 3153,
        LineSmoothHint = 3154,
        PolygonSmoothHint = 3155,
        FogHint = 3156,
        PackCmykHintExt = 32782,
        UnpackCmykHintExt = 32783,
        PhongHintWin = 33003,
        ClipVolumeClippingHintExt = 33008,
        TextureMultiBufferHintSgix = 33070,
        GenerateMipmapHint = 33170,
        GenerateMipmapHintSgis = 33170,
        ProgramBinaryRetrievableHint = 33367,
        ConvolutionHintSgix = 33558,
        ScalebiasHintSgix = 33570,
        VertexPreclipSgix = 33774,
        VertexPreclipHintSgix = 33775,
        TextureCompressionHint = 34031,
        TextureCompressionHintArb = 34031,
        VertexArrayStorageHintApple = 34079,
        MultisampleFilterHintNv = 34100,
        TransformHintApple = 34225,
        TextureStorageHintApple = 34236,
        FragmentShaderDerivativeHint = 35723,
        FragmentShaderDerivativeHintArb = 35723,
        PreferDoublebufferHintPgi = 107000,
        ConserveMemoryHintPgi = 107005,
        ReclaimMemoryHintPgi = 107006,
        NativeGraphicsBeginHintPgi = 107011,
        NativeGraphicsEndHintPgi = 107012,
        AlwaysFastHintPgi = 107020,
        AlwaysSoftHintPgi = 107021,
        AllowDrawObjHintPgi = 107022,
        AllowDrawWinHintPgi = 107023,
        AllowDrawFrgHintPgi = 107024,
        AllowDrawMemHintPgi = 107025,
        StrictDepthfuncHintPgi = 107030,
        StrictLightingHintPgi = 107031,
        StrictScissorHintPgi = 107032,
        FullStippleHintPgi = 107033,
        ClipNearHintPgi = 107040,
        ClipFarHintPgi = 107041,
        WideLineHintPgi = 107042,
        BackNormalsHintPgi = 107043,
        VertexDataHintPgi = 107050,
        VertexConsistentHintPgi = 107051,
        MaterialSideHintPgi = 107052,
        MaxVertexHintPgi = 107053
    }

    public enum PixelMap : uint
    {
        PixelMapIToI = 3184,
        PixelMapSToS = 3185,
        PixelMapIToR = 3186,
        PixelMapIToG = 3187,
        PixelMapIToB = 3188,
        PixelMapIToA = 3189,
        PixelMapRToR = 3190,
        PixelMapGToG = 3191,
        PixelMapBToB = 3192,
        PixelMapAToA = 3193
    }

    public enum GetPixelMap : uint
    {
        PixelMapIToI = 3184,
        PixelMapSToS = 3185,
        PixelMapIToR = 3186,
        PixelMapIToG = 3187,
        PixelMapIToB = 3188,
        PixelMapIToA = 3189,
        PixelMapRToR = 3190,
        PixelMapGToG = 3191,
        PixelMapBToB = 3192,
        PixelMapAToA = 3193
    }

    public enum PixelStoreParameter : uint
    {
        UnpackSwapBytes = 3312,
        UnpackLsbFirst = 3313,
        UnpackRowLength = 3314,
        UnpackSkipRows = 3315,
        UnpackSkipPixels = 3316,
        UnpackAlignment = 3317,
        PackSwapBytes = 3328,
        PackLsbFirst = 3329,
        PackRowLength = 3330,
        PackSkipRows = 3331,
        PackSkipPixels = 3332,
        PackAlignment = 3333,
        PackSkipImages = 32875,
        PackSkipImagesExt = 32875,
        PackImageHeight = 32876,
        PackImageHeightExt = 32876,
        UnpackSkipImages = 32877,
        UnpackSkipImagesExt = 32877,
        UnpackImageHeight = 32878,
        UnpackImageHeightExt = 32878,
        PackSkipVolumesSgis = 33072,
        PackImageDepthSgis = 33073,
        UnpackSkipVolumesSgis = 33074,
        UnpackImageDepthSgis = 33075,
        PixelTileWidthSgix = 33088,
        PixelTileHeightSgix = 33089,
        PixelTileGridWidthSgix = 33090,
        PixelTileGridHeightSgix = 33091,
        PixelTileGridDepthSgix = 33092,
        PixelTileCacheSizeSgix = 33093,
        PackResampleSgix = 33838,
        UnpackResampleSgix = 33839,
        PackSubsampleRateSgix = 34208,
        UnpackSubsampleRateSgix = 34209,
        PackResampleOml = 35204,
        UnpackResampleOml = 35205
    }

    public enum PixelTransferParameter : uint
    {
        MapColor = 3344,
        MapStencil = 3345,
        IndexShift = 3346,
        IndexOffset = 3347,
        RedScale = 3348,
        RedBias = 3349,
        GreenScale = 3352,
        GreenBias = 3353,
        BlueScale = 3354,
        BlueBias = 3355,
        AlphaScale = 3356,
        AlphaBias = 3357,
        DepthScale = 3358,
        DepthBias = 3359,
        PostConvolutionRedScale = 32796,
        PostConvolutionRedScaleExt = 32796,
        PostConvolutionGreenScale = 32797,
        PostConvolutionGreenScaleExt = 32797,
        PostConvolutionBlueScale = 32798,
        PostConvolutionBlueScaleExt = 32798,
        PostConvolutionAlphaScale = 32799,
        PostConvolutionAlphaScaleExt = 32799,
        PostConvolutionRedBias = 32800,
        PostConvolutionRedBiasExt = 32800,
        PostConvolutionGreenBias = 32801,
        PostConvolutionGreenBiasExt = 32801,
        PostConvolutionBlueBias = 32802,
        PostConvolutionBlueBiasExt = 32802,
        PostConvolutionAlphaBias = 32803,
        PostConvolutionAlphaBiasExt = 32803,
        PostColorMatrixRedScale = 32948,
        PostColorMatrixRedScaleSgi = 32948,
        PostColorMatrixGreenScale = 32949,
        PostColorMatrixGreenScaleSgi = 32949,
        PostColorMatrixBlueScale = 32950,
        PostColorMatrixBlueScaleSgi = 32950,
        PostColorMatrixAlphaScale = 32951,
        PostColorMatrixAlphaScaleSgi = 32951,
        PostColorMatrixRedBias = 32952,
        PostColorMatrixRedBiasSgi = 32952,
        PostColorMatrixGreenBias = 32953,
        PostColorMatrixGreenBiasSgi = 32953,
        PostColorMatrixBlueBias = 32954,
        PostColorMatrixBlueBiasSgi = 32954,
        PostColorMatrixAlphaBias = 32955,
        PostColorMatrixAlphaBiasSgi = 32955
    }

    public enum IndexMaterialParameterEXT : uint
    {
        IndexOffset = 3347
    }

    public enum MapTarget : uint
    {
        Map1Color4 = 3472,
        Map1Index = 3473,
        Map1Normal = 3474,
        Map1TextureCoord1 = 3475,
        Map1TextureCoord2 = 3476,
        Map1TextureCoord3 = 3477,
        Map1TextureCoord4 = 3478,
        Map1Vertex3 = 3479,
        Map1Vertex4 = 3480,
        Map2Color4 = 3504,
        Map2Index = 3505,
        Map2Normal = 3506,
        Map2TextureCoord1 = 3507,
        Map2TextureCoord2 = 3508,
        Map2TextureCoord3 = 3509,
        Map2TextureCoord4 = 3510,
        Map2Vertex3 = 3511,
        Map2Vertex4 = 3512,
        GeometryDeformationSgix = 33172,
        TextureDeformationSgix = 33173
    }

    public enum CopyImageSubDataTarget : uint
    {
        Texture1d = 3552,
        Texture2d = 3553,
        Texture3d = 32879,
        TextureRectangle = 34037,
        TextureCubeMap = 34067,
        Texture1dArray = 35864,
        Texture2dArray = 35866,
        Renderbuffer = 36161,
        TextureCubeMapArray = 36873,
        Texture2dMultisample = 37120,
        Texture2dMultisampleArray = 37122
    }

    public enum TextureTarget : uint
    {
        Texture1d = 3552,
        Texture2d = 3553,
        ProxyTexture1d = 32867,
        ProxyTexture1dExt = 32867,
        ProxyTexture2d = 32868,
        ProxyTexture2dExt = 32868,
        Texture3d = 32879,
        Texture3dExt = 32879,
        ProxyTexture3d = 32880,
        ProxyTexture3dExt = 32880,
        DetailTexture2dSgis = 32917,
        Texture4dSgis = 33076,
        ProxyTexture4dSgis = 33077,
        TextureRectangle = 34037,
        ProxyTextureRectangle = 34039,
        ProxyTextureRectangleArb = 34039,
        ProxyTextureRectangleNv = 34039,
        TextureCubeMap = 34067,
        TextureCubeMapPositiveX = 34069,
        TextureCubeMapNegativeX = 34070,
        TextureCubeMapPositiveY = 34071,
        TextureCubeMapNegativeY = 34072,
        TextureCubeMapPositiveZ = 34073,
        TextureCubeMapNegativeZ = 34074,
        ProxyTextureCubeMap = 34075,
        ProxyTextureCubeMapArb = 34075,
        ProxyTextureCubeMapExt = 34075,
        Texture1dArray = 35864,
        ProxyTexture1dArray = 35865,
        ProxyTexture1dArrayExt = 35865,
        Texture2dArray = 35866,
        ProxyTexture2dArray = 35867,
        ProxyTexture2dArrayExt = 35867,
        TextureBuffer = 35882,
        Renderbuffer = 36161,
        TextureCubeMapArray = 36873,
        TextureCubeMapArrayArb = 36873,
        ProxyTextureCubeMapArray = 36875,
        ProxyTextureCubeMapArrayArb = 36875,
        Texture2dMultisample = 37120,
        ProxyTexture2dMultisample = 37121,
        Texture2dMultisampleArray = 37122,
        ProxyTexture2dMultisampleArray = 37123
    }

    public enum GetPointervPName : uint
    {
        FeedbackBufferPointer = 3568,
        SelectionBufferPointer = 3571,
        VertexArrayPointer = 32910,
        VertexArrayPointerExt = 32910,
        NormalArrayPointer = 32911,
        NormalArrayPointerExt = 32911,
        ColorArrayPointer = 32912,
        ColorArrayPointerExt = 32912,
        IndexArrayPointer = 32913,
        IndexArrayPointerExt = 32913,
        TextureCoordArrayPointer = 32914,
        TextureCoordArrayPointerExt = 32914,
        EdgeFlagArrayPointer = 32915,
        EdgeFlagArrayPointerExt = 32915,
        InstrumentBufferPointerSgix = 33152,
        DebugCallbackFunction = 33348,
        DebugCallbackUserParam = 33349
    }

    public enum TextureParameterName : uint
    {
        TextureWidth = 4096,
        TextureHeight = 4097,
        TextureComponents = 4099,
        TextureInternalFormat = 4099,
        TextureBorderColor = 4100,
        TextureBorder = 4101,
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
        TextureRedSize = 32860,
        TextureGreenSize = 32861,
        TextureBlueSize = 32862,
        TextureAlphaSize = 32863,
        TextureLuminanceSize = 32864,
        TextureIntensitySize = 32865,
        TexturePriority = 32870,
        TexturePriorityExt = 32870,
        TextureResident = 32871,
        TextureDepthExt = 32881,
        TextureWrapR = 32882,
        TextureWrapRExt = 32882,
        DetailTextureLevelSgis = 32922,
        DetailTextureModeSgis = 32923,
        DetailTextureFuncPointsSgis = 32924,
        SharpenTextureFuncPointsSgis = 32944,
        ShadowAmbientSgix = 32959,
        DualTextureSelectSgis = 33060,
        QuadTextureSelectSgis = 33061,
        Texture4dsizeSgis = 33078,
        TextureWrapQSgis = 33079,
        TextureMinLod = 33082,
        TextureMinLodSgis = 33082,
        TextureMaxLod = 33083,
        TextureMaxLodSgis = 33083,
        TextureBaseLevel = 33084,
        TextureBaseLevelSgis = 33084,
        TextureMaxLevel = 33085,
        TextureMaxLevelSgis = 33085,
        TextureFilter4SizeSgis = 33095,
        TextureClipmapCenterSgix = 33137,
        TextureClipmapFrameSgix = 33138,
        TextureClipmapOffsetSgix = 33139,
        TextureClipmapVirtualDepthSgix = 33140,
        TextureClipmapLodOffsetSgix = 33141,
        TextureClipmapDepthSgix = 33142,
        PostTextureFilterBiasSgix = 33145,
        PostTextureFilterScaleSgix = 33146,
        TextureLodBiasSSgix = 33166,
        TextureLodBiasTSgix = 33167,
        TextureLodBiasRSgix = 33168,
        GenerateMipmap = 33169,
        GenerateMipmapSgis = 33169,
        TextureCompareSgix = 33178,
        TextureCompareOperatorSgix = 33179,
        TextureLequalRSgix = 33180,
        TextureGequalRSgix = 33181,
        TextureMaxClampSSgix = 33641,
        TextureMaxClampTSgix = 33642,
        TextureMaxClampRSgix = 33643,
        TextureLodBias = 34049,
        TextureCompareMode = 34892,
        TextureCompareFunc = 34893,
        TextureSwizzleR = 36418,
        TextureSwizzleG = 36419,
        TextureSwizzleB = 36420,
        TextureSwizzleA = 36421,
        TextureSwizzleRgba = 36422,
        DepthStencilTextureMode = 37098,
        TextureTilingExt = 38272
    }

    public enum GetTextureParameter : uint
    {
        TextureWidth = 4096,
        TextureHeight = 4097,
        TextureComponents = 4099,
        TextureInternalFormat = 4099,
        TextureBorderColor = 4100,
        TextureBorder = 4101,
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
        TextureRedSize = 32860,
        TextureGreenSize = 32861,
        TextureBlueSize = 32862,
        TextureAlphaSize = 32863,
        TextureLuminanceSize = 32864,
        TextureIntensitySize = 32865,
        TexturePriority = 32870,
        TextureResident = 32871,
        TextureDepthExt = 32881,
        TextureWrapRExt = 32882,
        DetailTextureLevelSgis = 32922,
        DetailTextureModeSgis = 32923,
        DetailTextureFuncPointsSgis = 32924,
        SharpenTextureFuncPointsSgis = 32944,
        ShadowAmbientSgix = 32959,
        DualTextureSelectSgis = 33060,
        QuadTextureSelectSgis = 33061,
        Texture4dsizeSgis = 33078,
        TextureWrapQSgis = 33079,
        TextureMinLodSgis = 33082,
        TextureMaxLodSgis = 33083,
        TextureBaseLevelSgis = 33084,
        TextureMaxLevelSgis = 33085,
        TextureFilter4SizeSgis = 33095,
        TextureClipmapCenterSgix = 33137,
        TextureClipmapFrameSgix = 33138,
        TextureClipmapOffsetSgix = 33139,
        TextureClipmapVirtualDepthSgix = 33140,
        TextureClipmapLodOffsetSgix = 33141,
        TextureClipmapDepthSgix = 33142,
        PostTextureFilterBiasSgix = 33145,
        PostTextureFilterScaleSgix = 33146,
        TextureLodBiasSSgix = 33166,
        TextureLodBiasTSgix = 33167,
        TextureLodBiasRSgix = 33168,
        GenerateMipmapSgis = 33169,
        TextureCompareSgix = 33178,
        TextureCompareOperatorSgix = 33179,
        TextureLequalRSgix = 33180,
        TextureGequalRSgix = 33181,
        TextureMaxClampSSgix = 33641,
        TextureMaxClampTSgix = 33642,
        TextureMaxClampRSgix = 33643
    }

    public enum SamplerParameterF : uint
    {
        TextureBorderColor = 4100,
        TextureMinLod = 33082,
        TextureMaxLod = 33083,
        TextureMaxAnisotropy = 34046,
        TextureLodBias = 34049
    }

    public enum DebugSeverity : uint
    {
        DontCare = 4352,
        DebugSeverityNotification = 33387,
        DebugSeverityHigh = 37190,
        DebugSeverityMedium = 37191,
        DebugSeverityLow = 37192
    }

    public enum HintMode : uint
    {
        DontCare = 4352,
        Fastest = 4353,
        Nicest = 4354
    }

    public enum DebugSource : uint
    {
        DontCare = 4352,
        DebugSourceApi = 33350,
        DebugSourceWindowSystem = 33351,
        DebugSourceShaderCompiler = 33352,
        DebugSourceThirdParty = 33353,
        DebugSourceApplication = 33354,
        DebugSourceOther = 33355
    }

    public enum DebugType : uint
    {
        DontCare = 4352,
        DebugTypeError = 33356,
        DebugTypeDeprecatedBehavior = 33357,
        DebugTypeUndefinedBehavior = 33358,
        DebugTypePortability = 33359,
        DebugTypePerformance = 33360,
        DebugTypeOther = 33361,
        DebugTypeMarker = 33384,
        DebugTypePushGroup = 33385,
        DebugTypePopGroup = 33386
    }

    public enum MaterialParameter : uint
    {
        Ambient = 4608,
        Diffuse = 4609,
        Specular = 4610,
        Emission = 5632,
        Shininess = 5633,
        AmbientAndDiffuse = 5634,
        ColorIndexes = 5635
    }

    public enum FragmentLightParameterSGIX : uint
    {
        Ambient = 4608,
        Diffuse = 4609,
        Specular = 4610,
        Position = 4611,
        SpotDirection = 4612,
        SpotExponent = 4613,
        SpotCutoff = 4614,
        ConstantAttenuation = 4615,
        LinearAttenuation = 4616,
        QuadraticAttenuation = 4617
    }

    public enum ColorMaterialParameter : uint
    {
        Ambient = 4608,
        Diffuse = 4609,
        Specular = 4610,
        Emission = 5632,
        AmbientAndDiffuse = 5634
    }

    public enum LightParameter : uint
    {
        Position = 4611,
        SpotDirection = 4612,
        SpotExponent = 4613,
        SpotCutoff = 4614,
        ConstantAttenuation = 4615,
        LinearAttenuation = 4616,
        QuadraticAttenuation = 4617
    }

    public enum ListMode : uint
    {
        Compile = 4864,
        CompileAndExecute = 4865
    }

    public enum VertexAttribIType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Int = 5124,
        UnsignedInt = 5125
    }

    public enum WeightPointerTypeARB : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Int = 5124,
        UnsignedInt = 5125,
        Float = 5126,
        Double = 5130
    }

    public enum TangentPointerTypeEXT : uint
    {
        Byte = 5120,
        Short = 5122,
        Int = 5124,
        Float = 5126,
        Double = 5130
    }

    public enum BinormalPointerTypeEXT : uint
    {
        Byte = 5120,
        Short = 5122,
        Int = 5124,
        Float = 5126,
        Double = 5130
    }

    public enum ColorPointerType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125
    }

    public enum ListNameType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Int = 5124,
        UnsignedInt = 5125,
        Float = 5126,
        _2Bytes = 5127,
        _3Bytes = 5128,
        _4Bytes = 5129
    }

    public enum NormalPointerType : uint
    {
        Byte = 5120,
        Short = 5122,
        Int = 5124,
        Float = 5126,
        Double = 5130
    }

    public enum PixelType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Int = 5124,
        UnsignedInt = 5125,
        Float = 5126,
        Bitmap = 6656,
        UnsignedByte332 = 32818,
        UnsignedByte332Ext = 32818,
        UnsignedShort4444 = 32819,
        UnsignedShort4444Ext = 32819,
        UnsignedShort5551 = 32820,
        UnsignedShort5551Ext = 32820,
        UnsignedInt8888 = 32821,
        UnsignedInt8888Ext = 32821,
        UnsignedInt1010102 = 32822,
        UnsignedInt1010102Ext = 32822
    }

    public enum VertexAttribType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Int = 5124,
        UnsignedInt = 5125,
        Float = 5126,
        Double = 5130,
        HalfFloat = 5131,
        Fixed = 5132,
        UnsignedInt2101010Rev = 33640,
        UnsignedInt10f11f11fRev = 35899,
        Int2101010Rev = 36255
    }

    public enum VertexAttribPointerType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Int = 5124,
        UnsignedInt = 5125,
        Float = 5126,
        Double = 5130,
        HalfFloat = 5131,
        Fixed = 5132,
        Int64Nv = 5134,
        Int64Arb = 5134,
        UnsignedInt64Nv = 5135,
        UnsignedInt64Arb = 5135,
        UnsignedInt2101010Rev = 33640,
        UnsignedInt10f11f11fRev = 35899,
        Int2101010Rev = 36255
    }

    public enum ScalarType : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125
    }

    public enum ReplacementCodeTypeSUN : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125
    }

    public enum ElementPointerTypeATI : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125
    }

    public enum MatrixIndexPointerTypeARB : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125
    }

    public enum DrawElementsType : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125
    }

    public enum SecondaryColorPointerTypeIBM : uint
    {
        Short = 5122,
        Int = 5124,
        Float = 5126,
        Double = 5130
    }

    public enum IndexPointerType : uint
    {
        Short = 5122,
        Int = 5124,
        Float = 5126,
        Double = 5130
    }

    public enum TexCoordPointerType : uint
    {
        Short = 5122,
        Int = 5124,
        Float = 5126,
        Double = 5130
    }

    public enum VertexPointerType : uint
    {
        Short = 5122,
        Int = 5124,
        Float = 5126,
        Double = 5130
    }

    public enum PixelFormat : uint
    {
        UnsignedShort = 5123,
        UnsignedInt = 5125,
        ColorIndex = 6400,
        StencilIndex = 6401,
        DepthComponent = 6402,
        Red = 6403,
        Green = 6404,
        Blue = 6405,
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410,
        AbgrExt = 32768,
        CmykExt = 32780,
        CmykaExt = 32781,
        Bgr = 32992,
        Bgra = 32993,
        Ycrcb422Sgix = 33211,
        Ycrcb444Sgix = 33212,
        Rg = 33319,
        RgInteger = 33320,
        DepthStencil = 34041,
        RedInteger = 36244,
        GreenInteger = 36245,
        BlueInteger = 36246,
        RgbInteger = 36248,
        RgbaInteger = 36249,
        BgrInteger = 36250,
        BgraInteger = 36251
    }

    public enum AttributeType : uint
    {
        Int = 5124,
        UnsignedInt = 5125,
        Float = 5126,
        Double = 5130,
        Int64Nv = 5134,
        Int64Arb = 5134,
        UnsignedInt64Nv = 5135,
        UnsignedInt64Arb = 5135,
        FloatVec2 = 35664,
        FloatVec2Arb = 35664,
        FloatVec3 = 35665,
        FloatVec3Arb = 35665,
        FloatVec4 = 35666,
        FloatVec4Arb = 35666,
        IntVec2 = 35667,
        IntVec2Arb = 35667,
        IntVec3 = 35668,
        IntVec3Arb = 35668,
        IntVec4 = 35669,
        IntVec4Arb = 35669,
        Bool = 35670,
        BoolArb = 35670,
        BoolVec2 = 35671,
        BoolVec2Arb = 35671,
        BoolVec3 = 35672,
        BoolVec3Arb = 35672,
        BoolVec4 = 35673,
        BoolVec4Arb = 35673,
        FloatMat2 = 35674,
        FloatMat2Arb = 35674,
        FloatMat3 = 35675,
        FloatMat3Arb = 35675,
        FloatMat4 = 35676,
        FloatMat4Arb = 35676,
        Sampler1d = 35677,
        Sampler1dArb = 35677,
        Sampler2d = 35678,
        Sampler2dArb = 35678,
        Sampler3d = 35679,
        Sampler3dArb = 35679,
        SamplerCube = 35680,
        SamplerCubeArb = 35680,
        Sampler1dShadow = 35681,
        Sampler1dShadowArb = 35681,
        Sampler2dShadow = 35682,
        Sampler2dShadowArb = 35682,
        Sampler2dRect = 35683,
        Sampler2dRectArb = 35683,
        Sampler2dRectShadow = 35684,
        Sampler2dRectShadowArb = 35684,
        FloatMat2x3 = 35685,
        FloatMat2x4 = 35686,
        FloatMat3x2 = 35687,
        FloatMat3x4 = 35688,
        FloatMat4x2 = 35689,
        FloatMat4x3 = 35690,
        SamplerBuffer = 36290,
        Sampler1dArrayShadow = 36291,
        Sampler2dArrayShadow = 36292,
        SamplerCubeShadow = 36293,
        UnsignedIntVec2 = 36294,
        UnsignedIntVec3 = 36295,
        UnsignedIntVec4 = 36296,
        IntSampler1d = 36297,
        IntSampler2d = 36298,
        IntSampler3d = 36299,
        IntSamplerCube = 36300,
        IntSampler2dRect = 36301,
        IntSampler1dArray = 36302,
        IntSampler2dArray = 36303,
        IntSamplerBuffer = 36304,
        UnsignedIntSampler1d = 36305,
        UnsignedIntSampler2d = 36306,
        UnsignedIntSampler3d = 36307,
        UnsignedIntSamplerCube = 36308,
        UnsignedIntSampler2dRect = 36309,
        UnsignedIntSampler1dArray = 36310,
        UnsignedIntSampler2dArray = 36311,
        UnsignedIntSamplerBuffer = 36312,
        DoubleMat2 = 36678,
        DoubleMat3 = 36679,
        DoubleMat4 = 36680,
        DoubleMat2x3 = 36681,
        DoubleMat2x4 = 36682,
        DoubleMat3x2 = 36683,
        DoubleMat3x4 = 36684,
        DoubleMat4x2 = 36685,
        DoubleMat4x3 = 36686,
        Int64Vec2Arb = 36841,
        Int64Vec3Arb = 36842,
        Int64Vec4Arb = 36843,
        UnsignedInt64Vec2Arb = 36853,
        UnsignedInt64Vec3Arb = 36854,
        UnsignedInt64Vec4Arb = 36855,
        DoubleVec2 = 36860,
        DoubleVec3 = 36861,
        DoubleVec4 = 36862,
        SamplerCubeMapArray = 36876,
        SamplerCubeMapArrayShadow = 36877,
        IntSamplerCubeMapArray = 36878,
        UnsignedIntSamplerCubeMapArray = 36879,
        Image1d = 36940,
        Image2d = 36941,
        Image3d = 36942,
        Image2dRect = 36943,
        ImageCube = 36944,
        ImageBuffer = 36945,
        Image1dArray = 36946,
        Image2dArray = 36947,
        ImageCubeMapArray = 36948,
        Image2dMultisample = 36949,
        Image2dMultisampleArray = 36950,
        IntImage1d = 36951,
        IntImage2d = 36952,
        IntImage3d = 36953,
        IntImage2dRect = 36954,
        IntImageCube = 36955,
        IntImageBuffer = 36956,
        IntImage1dArray = 36957,
        IntImage2dArray = 36958,
        IntImageCubeMapArray = 36959,
        IntImage2dMultisample = 36960,
        IntImage2dMultisampleArray = 36961,
        UnsignedIntImage1d = 36962,
        UnsignedIntImage2d = 36963,
        UnsignedIntImage3d = 36964,
        UnsignedIntImage2dRect = 36965,
        UnsignedIntImageCube = 36966,
        UnsignedIntImageBuffer = 36967,
        UnsignedIntImage1dArray = 36968,
        UnsignedIntImage2dArray = 36969,
        UnsignedIntImageCubeMapArray = 36970,
        UnsignedIntImage2dMultisample = 36971,
        UnsignedIntImage2dMultisampleArray = 36972,
        Sampler2dMultisample = 37128,
        IntSampler2dMultisample = 37129,
        UnsignedIntSampler2dMultisample = 37130,
        Sampler2dMultisampleArray = 37131,
        IntSampler2dMultisampleArray = 37132,
        UnsignedIntSampler2dMultisampleArray = 37133
    }

    public enum UniformType : uint
    {
        Int = 5124,
        UnsignedInt = 5125,
        Float = 5126,
        Double = 5130,
        FloatVec2 = 35664,
        FloatVec3 = 35665,
        FloatVec4 = 35666,
        IntVec2 = 35667,
        IntVec3 = 35668,
        IntVec4 = 35669,
        Bool = 35670,
        BoolVec2 = 35671,
        BoolVec3 = 35672,
        BoolVec4 = 35673,
        FloatMat2 = 35674,
        FloatMat3 = 35675,
        FloatMat4 = 35676,
        Sampler1d = 35677,
        Sampler2d = 35678,
        Sampler3d = 35679,
        SamplerCube = 35680,
        Sampler1dShadow = 35681,
        Sampler2dShadow = 35682,
        Sampler2dRect = 35683,
        Sampler2dRectShadow = 35684,
        FloatMat2x3 = 35685,
        FloatMat2x4 = 35686,
        FloatMat3x2 = 35687,
        FloatMat3x4 = 35688,
        FloatMat4x2 = 35689,
        FloatMat4x3 = 35690,
        Sampler1dArray = 36288,
        Sampler2dArray = 36289,
        SamplerBuffer = 36290,
        Sampler1dArrayShadow = 36291,
        Sampler2dArrayShadow = 36292,
        SamplerCubeShadow = 36293,
        UnsignedIntVec2 = 36294,
        UnsignedIntVec3 = 36295,
        UnsignedIntVec4 = 36296,
        IntSampler1d = 36297,
        IntSampler2d = 36298,
        IntSampler3d = 36299,
        IntSamplerCube = 36300,
        IntSampler2dRect = 36301,
        IntSampler1dArray = 36302,
        IntSampler2dArray = 36303,
        IntSamplerBuffer = 36304,
        UnsignedIntSampler1d = 36305,
        UnsignedIntSampler2d = 36306,
        UnsignedIntSampler3d = 36307,
        UnsignedIntSamplerCube = 36308,
        UnsignedIntSampler2dRect = 36309,
        UnsignedIntSampler1dArray = 36310,
        UnsignedIntSampler2dArray = 36311,
        UnsignedIntSamplerBuffer = 36312,
        DoubleMat2 = 36678,
        DoubleMat3 = 36679,
        DoubleMat4 = 36680,
        DoubleMat2x3 = 36681,
        DoubleMat2x4 = 36682,
        DoubleMat3x2 = 36683,
        DoubleMat3x4 = 36684,
        DoubleMat4x2 = 36685,
        DoubleMat4x3 = 36686,
        DoubleVec2 = 36860,
        DoubleVec3 = 36861,
        DoubleVec4 = 36862,
        SamplerCubeMapArray = 36876,
        SamplerCubeMapArrayShadow = 36877,
        IntSamplerCubeMapArray = 36878,
        UnsignedIntSamplerCubeMapArray = 36879,
        Sampler2dMultisample = 37128,
        IntSampler2dMultisample = 37129,
        UnsignedIntSampler2dMultisample = 37130,
        Sampler2dMultisampleArray = 37131,
        IntSampler2dMultisampleArray = 37132,
        UnsignedIntSampler2dMultisampleArray = 37133
    }

    public enum GlslTypeToken : uint
    {
        Int = 5124,
        UnsignedInt = 5125,
        Float = 5126,
        Double = 5130,
        FloatVec2 = 35664,
        FloatVec3 = 35665,
        FloatVec4 = 35666,
        IntVec2 = 35667,
        IntVec3 = 35668,
        IntVec4 = 35669,
        Bool = 35670,
        BoolVec2 = 35671,
        BoolVec3 = 35672,
        BoolVec4 = 35673,
        FloatMat2 = 35674,
        FloatMat3 = 35675,
        FloatMat4 = 35676,
        Sampler1d = 35677,
        Sampler2d = 35678,
        Sampler3d = 35679,
        SamplerCube = 35680,
        Sampler1dShadow = 35681,
        Sampler2dShadow = 35682,
        Sampler2dRect = 35683,
        Sampler2dRectShadow = 35684,
        FloatMat2x3 = 35685,
        FloatMat2x4 = 35686,
        FloatMat3x2 = 35687,
        FloatMat3x4 = 35688,
        FloatMat4x2 = 35689,
        FloatMat4x3 = 35690,
        Sampler1dArray = 36288,
        Sampler2dArray = 36289,
        SamplerBuffer = 36290,
        Sampler1dArrayShadow = 36291,
        Sampler2dArrayShadow = 36292,
        SamplerCubeShadow = 36293,
        UnsignedIntVec2 = 36294,
        UnsignedIntVec3 = 36295,
        UnsignedIntVec4 = 36296,
        IntSampler1d = 36297,
        IntSampler2d = 36298,
        IntSampler3d = 36299,
        IntSamplerCube = 36300,
        IntSampler2dRect = 36301,
        IntSampler1dArray = 36302,
        IntSampler2dArray = 36303,
        IntSamplerBuffer = 36304,
        UnsignedIntSampler1d = 36305,
        UnsignedIntSampler2d = 36306,
        UnsignedIntSampler3d = 36307,
        UnsignedIntSamplerCube = 36308,
        UnsignedIntSampler2dRect = 36309,
        UnsignedIntSampler1dArray = 36310,
        UnsignedIntSampler2dArray = 36311,
        UnsignedIntSamplerBuffer = 36312,
        DoubleMat2 = 36678,
        DoubleMat3 = 36679,
        DoubleMat4 = 36680,
        DoubleVec2 = 36860,
        DoubleVec3 = 36861,
        DoubleVec4 = 36862,
        SamplerCubeMapArray = 36876,
        SamplerCubeMapArrayShadow = 36877,
        IntSamplerCubeMapArray = 36878,
        UnsignedIntSamplerCubeMapArray = 36879,
        Image1d = 36940,
        Image2d = 36941,
        Image3d = 36942,
        Image2dRect = 36943,
        ImageCube = 36944,
        ImageBuffer = 36945,
        Image1dArray = 36946,
        Image2dArray = 36947,
        ImageCubeMapArray = 36948,
        Image2dMultisample = 36949,
        Image2dMultisampleArray = 36950,
        IntImage1d = 36951,
        IntImage2d = 36952,
        IntImage3d = 36953,
        IntImage2dRect = 36954,
        IntImageCube = 36955,
        IntImageBuffer = 36956,
        IntImage1dArray = 36957,
        IntImage2dArray = 36958,
        IntImageCubeMapArray = 36959,
        IntImage2dMultisample = 36960,
        IntImage2dMultisampleArray = 36961,
        UnsignedIntImage1d = 36962,
        UnsignedIntImage2d = 36963,
        UnsignedIntImage3d = 36964,
        UnsignedIntImage2dRect = 36965,
        UnsignedIntImageCube = 36966,
        UnsignedIntImageBuffer = 36967,
        UnsignedIntImage1dArray = 36968,
        UnsignedIntImage2dArray = 36969,
        UnsignedIntImageCubeMapArray = 36970,
        UnsignedIntImage2dMultisample = 36971,
        UnsignedIntImage2dMultisampleArray = 36972,
        Sampler2dMultisample = 37128,
        IntSampler2dMultisample = 37129,
        UnsignedIntSampler2dMultisample = 37130,
        Sampler2dMultisampleArray = 37131,
        IntSampler2dMultisampleArray = 37132,
        UnsignedIntSampler2dMultisampleArray = 37133,
        UnsignedIntAtomicCounter = 37595
    }

    public enum MapTypeNV : uint
    {
        Float = 5126,
        Double = 5130
    }

    public enum VertexWeightPointerTypeEXT : uint
    {
        Float = 5126
    }

    public enum FogCoordinatePointerType : uint
    {
        Float = 5126,
        Double = 5130
    }

    public enum FogPointerTypeEXT : uint
    {
        Float = 5126,
        Double = 5130
    }

    public enum FogPointerTypeIBM : uint
    {
        Float = 5126,
        Double = 5130
    }

    public enum VertexAttribLType : uint
    {
        Double = 5130
    }

    public enum LogicOp : uint
    {
        Clear = 5376,
        And = 5377,
        AndReverse = 5378,
        Copy = 5379,
        AndInverted = 5380,
        Noop = 5381,
        Xor = 5382,
        Or = 5383,
        Nor = 5384,
        Equiv = 5385,
        Invert = 5386,
        OrReverse = 5387,
        CopyInverted = 5388,
        OrInverted = 5389,
        Nand = 5390,
        Set = 5391
    }

    public enum PathFillMode : uint
    {
        Invert = 5386,
        PathFillModeNv = 36992,
        CountUpNv = 37000,
        CountDownNv = 37001
    }

    public enum MatrixMode : uint
    {
        Modelview = 5888,
        Modelview0Ext = 5888,
        Projection = 5889,
        Texture = 5890
    }

    public enum ObjectIdentifier : uint
    {
        Texture = 5890,
        VertexArray = 32884,
        Buffer = 33504,
        Shader = 33505,
        Program = 33506,
        Query = 33507,
        ProgramPipeline = 33508,
        Sampler = 33510,
        Framebuffer = 36160,
        Renderbuffer = 36161,
        TransformFeedback = 36386
    }

    public enum Buffer : uint
    {
        Color = 6144,
        Depth = 6145,
        Stencil = 6146
    }

    public enum PixelCopyType : uint
    {
        Color = 6144,
        Depth = 6145,
        Stencil = 6146
    }

    public enum InvalidateFramebufferAttachment : uint
    {
        Color = 6144,
        Depth = 6145,
        Stencil = 6146,
        DepthStencilAttachment = 33306,
        ColorAttachment0 = 36064,
        ColorAttachment0Ext = 36064,
        ColorAttachment1 = 36065,
        ColorAttachment1Ext = 36065,
        ColorAttachment2 = 36066,
        ColorAttachment2Ext = 36066,
        ColorAttachment3 = 36067,
        ColorAttachment3Ext = 36067,
        ColorAttachment4 = 36068,
        ColorAttachment4Ext = 36068,
        ColorAttachment5 = 36069,
        ColorAttachment5Ext = 36069,
        ColorAttachment6 = 36070,
        ColorAttachment6Ext = 36070,
        ColorAttachment7 = 36071,
        ColorAttachment7Ext = 36071,
        ColorAttachment8 = 36072,
        ColorAttachment8Ext = 36072,
        ColorAttachment9 = 36073,
        ColorAttachment9Ext = 36073,
        ColorAttachment10 = 36074,
        ColorAttachment10Ext = 36074,
        ColorAttachment11 = 36075,
        ColorAttachment11Ext = 36075,
        ColorAttachment12 = 36076,
        ColorAttachment12Ext = 36076,
        ColorAttachment13 = 36077,
        ColorAttachment13Ext = 36077,
        ColorAttachment14 = 36078,
        ColorAttachment14Ext = 36078,
        ColorAttachment15 = 36079,
        ColorAttachment15Ext = 36079,
        ColorAttachment16 = 36080,
        ColorAttachment17 = 36081,
        ColorAttachment18 = 36082,
        ColorAttachment19 = 36083,
        ColorAttachment20 = 36084,
        ColorAttachment21 = 36085,
        ColorAttachment22 = 36086,
        ColorAttachment23 = 36087,
        ColorAttachment24 = 36088,
        ColorAttachment25 = 36089,
        ColorAttachment26 = 36090,
        ColorAttachment27 = 36091,
        ColorAttachment28 = 36092,
        ColorAttachment29 = 36093,
        ColorAttachment30 = 36094,
        ColorAttachment31 = 36095,
        DepthAttachment = 36096,
        DepthAttachmentExt = 36096,
        StencilAttachmentExt = 36128
    }

    public enum InternalFormat : uint
    {
        StencilIndex = 6401,
        DepthComponent = 6402,
        Red = 6403,
        Rgb = 6407,
        Rgba = 6408,
        R3G3B2 = 10768,
        Alpha4 = 32827,
        Alpha4Ext = 32827,
        Alpha8 = 32828,
        Alpha8Ext = 32828,
        Alpha12 = 32829,
        Alpha12Ext = 32829,
        Alpha16 = 32830,
        Alpha16Ext = 32830,
        Luminance4 = 32831,
        Luminance4Ext = 32831,
        Luminance8 = 32832,
        Luminance8Ext = 32832,
        Luminance12 = 32833,
        Luminance12Ext = 32833,
        Luminance16 = 32834,
        Luminance16Ext = 32834,
        Luminance4Alpha4 = 32835,
        Luminance4Alpha4Ext = 32835,
        Luminance6Alpha2 = 32836,
        Luminance6Alpha2Ext = 32836,
        Luminance8Alpha8 = 32837,
        Luminance8Alpha8Ext = 32837,
        Luminance12Alpha4 = 32838,
        Luminance12Alpha4Ext = 32838,
        Luminance12Alpha12 = 32839,
        Luminance12Alpha12Ext = 32839,
        Luminance16Alpha16 = 32840,
        Luminance16Alpha16Ext = 32840,
        Intensity = 32841,
        Intensity4 = 32842,
        Intensity4Ext = 32842,
        Intensity8 = 32843,
        Intensity8Ext = 32843,
        Intensity12 = 32844,
        Intensity12Ext = 32844,
        Intensity16 = 32845,
        Intensity16Ext = 32845,
        Rgb2Ext = 32846,
        Rgb4 = 32847,
        Rgb4Ext = 32847,
        Rgb5 = 32848,
        Rgb5Ext = 32848,
        Rgb8 = 32849,
        Rgb8Ext = 32849,
        Rgb10 = 32850,
        Rgb10Ext = 32850,
        Rgb12 = 32851,
        Rgb12Ext = 32851,
        Rgb16 = 32852,
        Rgb16Ext = 32852,
        Rgba2 = 32853,
        Rgba2Ext = 32853,
        Rgba4 = 32854,
        Rgba4Ext = 32854,
        Rgb5A1 = 32855,
        Rgb5A1Ext = 32855,
        Rgba8 = 32856,
        Rgba8Ext = 32856,
        Rgb10A2 = 32857,
        Rgb10A2Ext = 32857,
        Rgba12 = 32858,
        Rgba12Ext = 32858,
        Rgba16 = 32859,
        Rgba16Ext = 32859,
        DualAlpha4Sgis = 33040,
        DualAlpha8Sgis = 33041,
        DualAlpha12Sgis = 33042,
        DualAlpha16Sgis = 33043,
        DualLuminance4Sgis = 33044,
        DualLuminance8Sgis = 33045,
        DualLuminance12Sgis = 33046,
        DualLuminance16Sgis = 33047,
        DualIntensity4Sgis = 33048,
        DualIntensity8Sgis = 33049,
        DualIntensity12Sgis = 33050,
        DualIntensity16Sgis = 33051,
        DualLuminanceAlpha4Sgis = 33052,
        DualLuminanceAlpha8Sgis = 33053,
        QuadAlpha4Sgis = 33054,
        QuadAlpha8Sgis = 33055,
        QuadLuminance4Sgis = 33056,
        QuadLuminance8Sgis = 33057,
        QuadIntensity4Sgis = 33058,
        QuadIntensity8Sgis = 33059,
        DepthComponent16 = 33189,
        DepthComponent16Arb = 33189,
        DepthComponent16Sgix = 33189,
        DepthComponent24 = 33190,
        DepthComponent24Arb = 33190,
        DepthComponent24Sgix = 33190,
        DepthComponent32 = 33191,
        DepthComponent32Arb = 33191,
        DepthComponent32Sgix = 33191,
        CompressedRed = 33317,
        CompressedRg = 33318,
        Rg = 33319,
        R8 = 33321,
        R16 = 33322,
        Rg8 = 33323,
        Rg16 = 33324,
        R16f = 33325,
        R32f = 33326,
        Rg16f = 33327,
        Rg32f = 33328,
        R8i = 33329,
        R8ui = 33330,
        R16i = 33331,
        R16ui = 33332,
        R32i = 33333,
        R32ui = 33334,
        Rg8i = 33335,
        Rg8ui = 33336,
        Rg16i = 33337,
        Rg16ui = 33338,
        Rg32i = 33339,
        Rg32ui = 33340,
        CompressedRgbS3tcDxt1Ext = 33776,
        CompressedRgbaS3tcDxt1Ext = 33777,
        CompressedRgbaS3tcDxt3Ext = 33778,
        CompressedRgbaS3tcDxt5Ext = 33779,
        CompressedRgb = 34029,
        CompressedRgba = 34030,
        DepthStencil = 34041,
        DepthStencilExt = 34041,
        DepthStencilNv = 34041,
        Rgba32f = 34836,
        Rgba32fArb = 34836,
        Rgb32f = 34837,
        Rgb32fArb = 34837,
        Rgba16f = 34842,
        Rgba16fArb = 34842,
        Rgb16f = 34843,
        Rgb16fArb = 34843,
        Depth24Stencil8 = 35056,
        Depth24Stencil8Ext = 35056,
        R11fG11fB10f = 35898,
        R11fG11fB10fExt = 35898,
        Rgb9E5 = 35901,
        Rgb9E5Ext = 35901,
        Srgb = 35904,
        SrgbExt = 35904,
        Srgb8 = 35905,
        Srgb8Ext = 35905,
        SrgbAlpha = 35906,
        SrgbAlphaExt = 35906,
        Srgb8Alpha8 = 35907,
        Srgb8Alpha8Ext = 35907,
        CompressedSrgb = 35912,
        CompressedSrgbAlpha = 35913,
        CompressedSrgbS3tcDxt1Ext = 35916,
        CompressedSrgbAlphaS3tcDxt1Ext = 35917,
        CompressedSrgbAlphaS3tcDxt3Ext = 35918,
        CompressedSrgbAlphaS3tcDxt5Ext = 35919,
        DepthComponent32f = 36012,
        Depth32fStencil8 = 36013,
        StencilIndex1 = 36166,
        StencilIndex1Ext = 36166,
        StencilIndex4 = 36167,
        StencilIndex4Ext = 36167,
        StencilIndex8 = 36168,
        StencilIndex8Ext = 36168,
        StencilIndex16 = 36169,
        StencilIndex16Ext = 36169,
        Rgb565 = 36194,
        Rgba32ui = 36208,
        Rgba32uiExt = 36208,
        Rgb32ui = 36209,
        Rgb32uiExt = 36209,
        Alpha32uiExt = 36210,
        Intensity32uiExt = 36211,
        Luminance32uiExt = 36212,
        LuminanceAlpha32uiExt = 36213,
        Rgba16ui = 36214,
        Rgba16uiExt = 36214,
        Rgb16ui = 36215,
        Rgb16uiExt = 36215,
        Alpha16uiExt = 36216,
        Intensity16uiExt = 36217,
        Luminance16uiExt = 36218,
        LuminanceAlpha16uiExt = 36219,
        Rgba8ui = 36220,
        Rgba8uiExt = 36220,
        Rgb8ui = 36221,
        Rgb8uiExt = 36221,
        Alpha8uiExt = 36222,
        Intensity8uiExt = 36223,
        Luminance8uiExt = 36224,
        LuminanceAlpha8uiExt = 36225,
        Rgba32i = 36226,
        Rgba32iExt = 36226,
        Rgb32i = 36227,
        Rgb32iExt = 36227,
        Alpha32iExt = 36228,
        Intensity32iExt = 36229,
        Luminance32iExt = 36230,
        LuminanceAlpha32iExt = 36231,
        Rgba16i = 36232,
        Rgba16iExt = 36232,
        Rgb16i = 36233,
        Rgb16iExt = 36233,
        Alpha16iExt = 36234,
        Intensity16iExt = 36235,
        Luminance16iExt = 36236,
        LuminanceAlpha16iExt = 36237,
        Rgba8i = 36238,
        Rgba8iExt = 36238,
        Rgb8i = 36239,
        Rgb8iExt = 36239,
        Alpha8iExt = 36240,
        Intensity8iExt = 36241,
        Luminance8iExt = 36242,
        LuminanceAlpha8iExt = 36243,
        DepthComponent32fNv = 36267,
        Depth32fStencil8Nv = 36268,
        CompressedRedRgtc1 = 36283,
        CompressedRedRgtc1Ext = 36283,
        CompressedSignedRedRgtc1 = 36284,
        CompressedSignedRedRgtc1Ext = 36284,
        CompressedRgRgtc2 = 36285,
        CompressedRedGreenRgtc2Ext = 36285,
        CompressedSignedRgRgtc2 = 36286,
        CompressedSignedRedGreenRgtc2Ext = 36286,
        CompressedRgbaBptcUnorm = 36492,
        CompressedRgbaBptcUnormArb = 36492,
        CompressedSrgbAlphaBptcUnorm = 36493,
        CompressedSrgbAlphaBptcUnormArb = 36493,
        CompressedRgbBptcSignedFloat = 36494,
        CompressedRgbBptcSignedFloatArb = 36494,
        CompressedRgbBptcUnsignedFloat = 36495,
        CompressedRgbBptcUnsignedFloatArb = 36495,
        R8Snorm = 36756,
        Rg8Snorm = 36757,
        Rgb8Snorm = 36758,
        Rgba8Snorm = 36759,
        R16Snorm = 36760,
        Rg16Snorm = 36761,
        Rgb16Snorm = 36762,
        Rgba16Snorm = 36763,
        Sr8Ext = 36797,
        Srg8Ext = 36798,
        Rgb10A2ui = 36975,
        CompressedR11Eac = 37488,
        CompressedSignedR11Eac = 37489,
        CompressedRg11Eac = 37490,
        CompressedSignedRg11Eac = 37491,
        CompressedRgb8Etc2 = 37492,
        CompressedSrgb8Etc2 = 37493,
        CompressedRgb8PunchthroughAlpha1Etc2 = 37494,
        CompressedSrgb8PunchthroughAlpha1Etc2 = 37495,
        CompressedRgba8Etc2Eac = 37496,
        CompressedSrgb8Alpha8Etc2Eac = 37497,
        CompressedRgbaAstc4x4Khr = 37808,
        CompressedRgbaAstc5x4Khr = 37809,
        CompressedRgbaAstc5x5Khr = 37810,
        CompressedRgbaAstc6x5Khr = 37811,
        CompressedRgbaAstc6x6Khr = 37812,
        CompressedRgbaAstc8x5Khr = 37813,
        CompressedRgbaAstc8x6Khr = 37814,
        CompressedRgbaAstc8x8Khr = 37815,
        CompressedRgbaAstc10x5Khr = 37816,
        CompressedRgbaAstc10x6Khr = 37817,
        CompressedRgbaAstc10x8Khr = 37818,
        CompressedRgbaAstc10x10Khr = 37819,
        CompressedRgbaAstc12x10Khr = 37820,
        CompressedRgbaAstc12x12Khr = 37821,
        CompressedSrgb8Alpha8Astc4x4Khr = 37840,
        CompressedSrgb8Alpha8Astc5x4Khr = 37841,
        CompressedSrgb8Alpha8Astc5x5Khr = 37842,
        CompressedSrgb8Alpha8Astc6x5Khr = 37843,
        CompressedSrgb8Alpha8Astc6x6Khr = 37844,
        CompressedSrgb8Alpha8Astc8x5Khr = 37845,
        CompressedSrgb8Alpha8Astc8x6Khr = 37846,
        CompressedSrgb8Alpha8Astc8x8Khr = 37847,
        CompressedSrgb8Alpha8Astc10x5Khr = 37848,
        CompressedSrgb8Alpha8Astc10x6Khr = 37849,
        CompressedSrgb8Alpha8Astc10x8Khr = 37850,
        CompressedSrgb8Alpha8Astc10x10Khr = 37851,
        CompressedSrgb8Alpha8Astc12x10Khr = 37852,
        CompressedSrgb8Alpha8Astc12x12Khr = 37853
    }

    public enum CombinerComponentUsageNV : uint
    {
        Blue = 6405,
        Alpha = 6406,
        Rgb = 6407
    }

    public enum CombinerPortionNV : uint
    {
        Alpha = 6406,
        Rgb = 6407
    }

    public enum PolygonMode : uint
    {
        Point = 6912,
        Line = 6913,
        Fill = 6914
    }

    public enum MeshMode1 : uint
    {
        Point = 6912,
        Line = 6913
    }

    public enum MeshMode2 : uint
    {
        Point = 6912,
        Line = 6913,
        Fill = 6914
    }

    public enum EvalMapsModeNV : uint
    {
    }

    public enum RenderingMode : uint
    {
        Render = 7168,
        Feedback = 7169,
        Select = 7170
    }

    public enum ShadingModel : uint
    {
        Flat = 7424,
        Smooth = 7425
    }

    public enum StringName : uint
    {
        Vendor = 7936,
        Renderer = 7937,
        Version = 7938,
        Extensions = 7939,
        ShadingLanguageVersion = 35724
    }

    public enum TextureCoordName : uint
    {
        S = 8192,
        T = 8193,
        R = 8194,
        Q = 8195
    }

    public enum TextureEnvParameter : uint
    {
        TextureEnvMode = 8704,
        TextureEnvColor = 8705
    }

    public enum TextureEnvTarget : uint
    {
        TextureEnv = 8960
    }

    public enum TextureGenMode : uint
    {
        EyeLinear = 9216,
        ObjectLinear = 9217,
        SphereMap = 9218,
        EyeDistanceToPointSgis = 33264,
        ObjectDistanceToPointSgis = 33265,
        EyeDistanceToLineSgis = 33266,
        ObjectDistanceToLineSgis = 33267
    }

    public enum TextureGenParameter : uint
    {
        TextureGenMode = 9472,
        ObjectPlane = 9473,
        EyePlane = 9474,
        EyePointSgis = 33268,
        ObjectPointSgis = 33269,
        EyeLineSgis = 33270,
        ObjectLineSgis = 33271
    }

    public enum BlitFramebufferFilter : uint
    {
        Nearest = 9728,
        Linear = 9729
    }

    public enum TextureMagFilter : uint
    {
        Nearest = 9728,
        Linear = 9729,
        LinearDetailSgis = 32919,
        LinearDetailAlphaSgis = 32920,
        LinearDetailColorSgis = 32921,
        LinearSharpenSgis = 32941,
        LinearSharpenAlphaSgis = 32942,
        LinearSharpenColorSgis = 32943,
        Filter4Sgis = 33094
    }

    public enum TextureMinFilter : uint
    {
        Nearest = 9728,
        Linear = 9729,
        NearestMipmapNearest = 9984,
        LinearMipmapNearest = 9985,
        NearestMipmapLinear = 9986,
        LinearMipmapLinear = 9987,
        Filter4Sgis = 33094,
        LinearClipmapLinearSgix = 33136,
        NearestClipmapNearestSgix = 33869,
        NearestClipmapLinearSgix = 33870,
        LinearClipmapNearestSgix = 33871
    }

    public enum TextureWrapMode : uint
    {
        LinearMipmapLinear = 9987,
        Clamp = 10496,
        Repeat = 10497,
        ClampToBorder = 33069,
        ClampToBorderArb = 33069,
        ClampToBorderSgis = 33069,
        ClampToEdge = 33071,
        ClampToEdgeSgis = 33071,
        MirroredRepeat = 33648
    }

    public enum SamplerParameterI : uint
    {
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
        TextureWrapR = 32882,
        TextureCompareMode = 34892,
        TextureCompareFunc = 34893
    }

    public enum SizedInternalFormat : uint
    {
        R3G3B2 = 10768,
        Alpha4 = 32827,
        Alpha4Ext = 32827,
        Alpha8 = 32828,
        Alpha8Ext = 32828,
        Alpha12 = 32829,
        Alpha12Ext = 32829,
        Alpha16 = 32830,
        Alpha16Ext = 32830,
        Luminance4 = 32831,
        Luminance4Ext = 32831,
        Luminance8 = 32832,
        Luminance8Ext = 32832,
        Luminance12 = 32833,
        Luminance12Ext = 32833,
        Luminance16 = 32834,
        Luminance16Ext = 32834,
        Luminance4Alpha4 = 32835,
        Luminance4Alpha4Ext = 32835,
        Luminance6Alpha2 = 32836,
        Luminance6Alpha2Ext = 32836,
        Luminance8Alpha8 = 32837,
        Luminance8Alpha8Ext = 32837,
        Luminance12Alpha4 = 32838,
        Luminance12Alpha4Ext = 32838,
        Luminance12Alpha12 = 32839,
        Luminance12Alpha12Ext = 32839,
        Luminance16Alpha16 = 32840,
        Luminance16Alpha16Ext = 32840,
        Intensity4 = 32842,
        Intensity4Ext = 32842,
        Intensity8 = 32843,
        Intensity8Ext = 32843,
        Intensity12 = 32844,
        Intensity12Ext = 32844,
        Intensity16 = 32845,
        Intensity16Ext = 32845,
        Rgb2Ext = 32846,
        Rgb4 = 32847,
        Rgb4Ext = 32847,
        Rgb5 = 32848,
        Rgb5Ext = 32848,
        Rgb8 = 32849,
        Rgb8Ext = 32849,
        Rgb10 = 32850,
        Rgb10Ext = 32850,
        Rgb12 = 32851,
        Rgb12Ext = 32851,
        Rgb16 = 32852,
        Rgb16Ext = 32852,
        Rgba2 = 32853,
        Rgba2Ext = 32853,
        Rgba4 = 32854,
        Rgba4Ext = 32854,
        Rgb5A1 = 32855,
        Rgb5A1Ext = 32855,
        Rgba8 = 32856,
        Rgba8Ext = 32856,
        Rgb10A2 = 32857,
        Rgb10A2Ext = 32857,
        Rgba12 = 32858,
        Rgba12Ext = 32858,
        Rgba16 = 32859,
        Rgba16Ext = 32859,
        DepthComponent16 = 33189,
        DepthComponent16Arb = 33189,
        DepthComponent16Sgix = 33189,
        DepthComponent24 = 33190,
        DepthComponent24Arb = 33190,
        DepthComponent24Sgix = 33190,
        DepthComponent32 = 33191,
        DepthComponent32Arb = 33191,
        DepthComponent32Sgix = 33191,
        R8 = 33321,
        R16 = 33322,
        Rg8 = 33323,
        Rg16 = 33324,
        R16f = 33325,
        R32f = 33326,
        Rg16f = 33327,
        Rg32f = 33328,
        R8i = 33329,
        R8ui = 33330,
        R16i = 33331,
        R16ui = 33332,
        R32i = 33333,
        R32ui = 33334,
        Rg8i = 33335,
        Rg8ui = 33336,
        Rg16i = 33337,
        Rg16ui = 33338,
        Rg32i = 33339,
        Rg32ui = 33340,
        CompressedRgbS3tcDxt1Ext = 33776,
        CompressedRgbaS3tcDxt1Ext = 33777,
        CompressedRgbaS3tcDxt3Ext = 33778,
        CompressedRgbaS3tcDxt5Ext = 33779,
        Rgba32f = 34836,
        Rgba32fArb = 34836,
        Rgb32f = 34837,
        Rgb32fArb = 34837,
        Rgba16f = 34842,
        Rgba16fArb = 34842,
        Rgb16f = 34843,
        Rgb16fArb = 34843,
        Depth24Stencil8 = 35056,
        Depth24Stencil8Ext = 35056,
        R11fG11fB10f = 35898,
        R11fG11fB10fExt = 35898,
        Rgb9E5 = 35901,
        Rgb9E5Ext = 35901,
        Srgb8 = 35905,
        Srgb8Ext = 35905,
        Srgb8Alpha8 = 35907,
        Srgb8Alpha8Ext = 35907,
        CompressedSrgbS3tcDxt1Ext = 35916,
        CompressedSrgbAlphaS3tcDxt1Ext = 35917,
        CompressedSrgbAlphaS3tcDxt3Ext = 35918,
        CompressedSrgbAlphaS3tcDxt5Ext = 35919,
        DepthComponent32f = 36012,
        Depth32fStencil8 = 36013,
        StencilIndex1 = 36166,
        StencilIndex1Ext = 36166,
        StencilIndex4 = 36167,
        StencilIndex4Ext = 36167,
        StencilIndex8 = 36168,
        StencilIndex8Ext = 36168,
        StencilIndex16 = 36169,
        StencilIndex16Ext = 36169,
        Rgb565 = 36194,
        Rgba32ui = 36208,
        Rgba32uiExt = 36208,
        Rgb32ui = 36209,
        Rgb32uiExt = 36209,
        Alpha32uiExt = 36210,
        Intensity32uiExt = 36211,
        Luminance32uiExt = 36212,
        LuminanceAlpha32uiExt = 36213,
        Rgba16ui = 36214,
        Rgba16uiExt = 36214,
        Rgb16ui = 36215,
        Rgb16uiExt = 36215,
        Alpha16uiExt = 36216,
        Intensity16uiExt = 36217,
        Luminance16uiExt = 36218,
        LuminanceAlpha16uiExt = 36219,
        Rgba8ui = 36220,
        Rgba8uiExt = 36220,
        Rgb8ui = 36221,
        Rgb8uiExt = 36221,
        Alpha8uiExt = 36222,
        Intensity8uiExt = 36223,
        Luminance8uiExt = 36224,
        LuminanceAlpha8uiExt = 36225,
        Rgba32i = 36226,
        Rgba32iExt = 36226,
        Rgb32i = 36227,
        Rgb32iExt = 36227,
        Alpha32iExt = 36228,
        Intensity32iExt = 36229,
        Luminance32iExt = 36230,
        LuminanceAlpha32iExt = 36231,
        Rgba16i = 36232,
        Rgba16iExt = 36232,
        Rgb16i = 36233,
        Rgb16iExt = 36233,
        Alpha16iExt = 36234,
        Intensity16iExt = 36235,
        Luminance16iExt = 36236,
        LuminanceAlpha16iExt = 36237,
        Rgba8i = 36238,
        Rgba8iExt = 36238,
        Rgb8i = 36239,
        Rgb8iExt = 36239,
        Alpha8iExt = 36240,
        Intensity8iExt = 36241,
        Luminance8iExt = 36242,
        LuminanceAlpha8iExt = 36243,
        DepthComponent32fNv = 36267,
        Depth32fStencil8Nv = 36268,
        CompressedRedRgtc1 = 36283,
        CompressedRedRgtc1Ext = 36283,
        CompressedSignedRedRgtc1 = 36284,
        CompressedSignedRedRgtc1Ext = 36284,
        CompressedRgRgtc2 = 36285,
        CompressedRedGreenRgtc2Ext = 36285,
        CompressedSignedRgRgtc2 = 36286,
        CompressedSignedRedGreenRgtc2Ext = 36286,
        CompressedRgbaBptcUnorm = 36492,
        CompressedRgbaBptcUnormArb = 36492,
        CompressedSrgbAlphaBptcUnorm = 36493,
        CompressedSrgbAlphaBptcUnormArb = 36493,
        CompressedRgbBptcSignedFloat = 36494,
        CompressedRgbBptcSignedFloatArb = 36494,
        CompressedRgbBptcUnsignedFloat = 36495,
        CompressedRgbBptcUnsignedFloatArb = 36495,
        R8Snorm = 36756,
        Rg8Snorm = 36757,
        Rgb8Snorm = 36758,
        Rgba8Snorm = 36759,
        R16Snorm = 36760,
        Rg16Snorm = 36761,
        Rgb16Snorm = 36762,
        Rgba16Snorm = 36763,
        Rgb10A2ui = 36975,
        CompressedR11Eac = 37488,
        CompressedSignedR11Eac = 37489,
        CompressedRg11Eac = 37490,
        CompressedSignedRg11Eac = 37491,
        CompressedRgb8Etc2 = 37492,
        CompressedSrgb8Etc2 = 37493,
        CompressedRgb8PunchthroughAlpha1Etc2 = 37494,
        CompressedSrgb8PunchthroughAlpha1Etc2 = 37495,
        CompressedRgba8Etc2Eac = 37496,
        CompressedSrgb8Alpha8Etc2Eac = 37497,
        CompressedRgbaAstc4x4Khr = 37808,
        CompressedRgbaAstc5x4Khr = 37809,
        CompressedRgbaAstc5x5Khr = 37810,
        CompressedRgbaAstc6x5Khr = 37811,
        CompressedRgbaAstc6x6Khr = 37812,
        CompressedRgbaAstc8x5Khr = 37813,
        CompressedRgbaAstc8x6Khr = 37814,
        CompressedRgbaAstc8x8Khr = 37815,
        CompressedRgbaAstc10x5Khr = 37816,
        CompressedRgbaAstc10x6Khr = 37817,
        CompressedRgbaAstc10x8Khr = 37818,
        CompressedRgbaAstc10x10Khr = 37819,
        CompressedRgbaAstc12x10Khr = 37820,
        CompressedRgbaAstc12x12Khr = 37821,
        CompressedSrgb8Alpha8Astc4x4Khr = 37840,
        CompressedSrgb8Alpha8Astc5x4Khr = 37841,
        CompressedSrgb8Alpha8Astc5x5Khr = 37842,
        CompressedSrgb8Alpha8Astc6x5Khr = 37843,
        CompressedSrgb8Alpha8Astc6x6Khr = 37844,
        CompressedSrgb8Alpha8Astc8x5Khr = 37845,
        CompressedSrgb8Alpha8Astc8x6Khr = 37846,
        CompressedSrgb8Alpha8Astc8x8Khr = 37847,
        CompressedSrgb8Alpha8Astc10x5Khr = 37848,
        CompressedSrgb8Alpha8Astc10x6Khr = 37849,
        CompressedSrgb8Alpha8Astc10x8Khr = 37850,
        CompressedSrgb8Alpha8Astc10x10Khr = 37851,
        CompressedSrgb8Alpha8Astc12x10Khr = 37852,
        CompressedSrgb8Alpha8Astc12x12Khr = 37853
    }

    public enum InterleavedArrayFormat : uint
    {
        V2f = 10784,
        V3f = 10785,
        C4ubV2f = 10786,
        C4ubV3f = 10787,
        C3fV3f = 10788,
        N3fV3f = 10789,
        C4fN3fV3f = 10790,
        T2fV3f = 10791,
        T4fV4f = 10792,
        T2fC4ubV3f = 10793,
        T2fC3fV3f = 10794,
        T2fN3fV3f = 10795,
        T2fC4fN3fV3f = 10796,
        T4fC4fN3fV4f = 10797
    }

    public enum ClipPlaneName : uint
    {
        ClipPlane0 = 12288,
        ClipDistance0 = 12288,
        ClipPlane1 = 12289,
        ClipDistance1 = 12289,
        ClipPlane2 = 12290,
        ClipDistance2 = 12290,
        ClipPlane3 = 12291,
        ClipDistance3 = 12291,
        ClipPlane4 = 12292,
        ClipDistance4 = 12292,
        ClipPlane5 = 12293,
        ClipDistance5 = 12293,
        ClipDistance6 = 12294,
        ClipDistance7 = 12295
    }

    public enum LightName : uint
    {
        Light0 = 16384,
        Light1 = 16385,
        Light2 = 16386,
        Light3 = 16387,
        Light4 = 16388,
        Light5 = 16389,
        Light6 = 16390,
        Light7 = 16391,
        FragmentLight0Sgix = 33804,
        FragmentLight1Sgix = 33805,
        FragmentLight2Sgix = 33806,
        FragmentLight3Sgix = 33807,
        FragmentLight4Sgix = 33808,
        FragmentLight5Sgix = 33809,
        FragmentLight6Sgix = 33810,
        FragmentLight7Sgix = 33811
    }

    public enum BlendEquationModeEXT : uint
    {
        FuncAdd = 32774,
        FuncAddExt = 32774,
        Min = 32775,
        MinExt = 32775,
        Max = 32776,
        MaxExt = 32776,
        FuncSubtract = 32778,
        FuncSubtractExt = 32778,
        FuncReverseSubtract = 32779,
        FuncReverseSubtractExt = 32779,
        AlphaMinSgix = 33568,
        AlphaMaxSgix = 33569
    }

    public enum ConvolutionTarget : uint
    {
        Convolution1d = 32784,
        Convolution2d = 32785
    }

    public enum ConvolutionTargetEXT : uint
    {
        Convolution1d = 32784,
        Convolution1dExt = 32784,
        Convolution2d = 32785,
        Convolution2dExt = 32785
    }

    public enum SeparableTarget : uint
    {
        Separable2d = 32786
    }

    public enum SeparableTargetEXT : uint
    {
        Separable2d = 32786,
        Separable2dExt = 32786
    }

    public enum GetConvolutionParameter : uint
    {
        ConvolutionBorderMode = 32787,
        ConvolutionBorderModeExt = 32787,
        ConvolutionFilterScale = 32788,
        ConvolutionFilterScaleExt = 32788,
        ConvolutionFilterBias = 32789,
        ConvolutionFilterBiasExt = 32789,
        ConvolutionFormat = 32791,
        ConvolutionFormatExt = 32791,
        ConvolutionWidth = 32792,
        ConvolutionWidthExt = 32792,
        ConvolutionHeight = 32793,
        ConvolutionHeightExt = 32793,
        MaxConvolutionWidth = 32794,
        MaxConvolutionWidthExt = 32794,
        MaxConvolutionHeight = 32795,
        MaxConvolutionHeightExt = 32795,
        ConvolutionBorderColor = 33108
    }

    public enum ConvolutionParameterEXT : uint
    {
        ConvolutionBorderMode = 32787,
        ConvolutionBorderModeExt = 32787,
        ConvolutionFilterScale = 32788,
        ConvolutionFilterScaleExt = 32788,
        ConvolutionFilterBias = 32789,
        ConvolutionFilterBiasExt = 32789
    }

    public enum ConvolutionBorderModeEXT : uint
    {
        Reduce = 32790,
        ReduceExt = 32790
    }

    public enum HistogramTarget : uint
    {
        Histogram = 32804,
        ProxyHistogram = 32805
    }

    public enum HistogramTargetEXT : uint
    {
        Histogram = 32804,
        HistogramExt = 32804,
        ProxyHistogram = 32805,
        ProxyHistogramExt = 32805
    }

    public enum GetHistogramParameterPNameEXT : uint
    {
        HistogramWidth = 32806,
        HistogramWidthExt = 32806,
        HistogramFormat = 32807,
        HistogramFormatExt = 32807,
        HistogramRedSize = 32808,
        HistogramRedSizeExt = 32808,
        HistogramGreenSize = 32809,
        HistogramGreenSizeExt = 32809,
        HistogramBlueSize = 32810,
        HistogramBlueSizeExt = 32810,
        HistogramAlphaSize = 32811,
        HistogramAlphaSizeExt = 32811,
        HistogramLuminanceSize = 32812,
        HistogramLuminanceSizeExt = 32812,
        HistogramSink = 32813,
        HistogramSinkExt = 32813
    }

    public enum MinmaxTarget : uint
    {
        Minmax = 32814
    }

    public enum MinmaxTargetEXT : uint
    {
        Minmax = 32814,
        MinmaxExt = 32814
    }

    public enum GetMinmaxParameterPNameEXT : uint
    {
        MinmaxFormat = 32815,
        MinmaxFormatExt = 32815,
        MinmaxSink = 32816,
        MinmaxSinkExt = 32816
    }

    public enum SamplePatternSGIS : uint
    {
        _1passExt = 32929,
        _1passSgis = 32929,
        _2pass0Ext = 32930,
        _2pass0Sgis = 32930,
        _2pass1Ext = 32931,
        _2pass1Sgis = 32931,
        _4pass0Ext = 32932,
        _4pass0Sgis = 32932,
        _4pass1Ext = 32933,
        _4pass1Sgis = 32933,
        _4pass2Ext = 32934,
        _4pass2Sgis = 32934,
        _4pass3Ext = 32935,
        _4pass3Sgis = 32935
    }

    public enum SamplePatternEXT : uint
    {
        _1passExt = 32929,
        _2pass0Ext = 32930,
        _2pass1Ext = 32931,
        _4pass0Ext = 32932,
        _4pass1Ext = 32933,
        _4pass2Ext = 32934,
        _4pass3Ext = 32935
    }

    public enum InternalFormatPName : uint
    {
        Samples = 32937,
        GenerateMipmap = 33169,
        InternalformatSupported = 33391,
        InternalformatPreferred = 33392,
        InternalformatRedSize = 33393,
        InternalformatGreenSize = 33394,
        InternalformatBlueSize = 33395,
        InternalformatAlphaSize = 33396,
        InternalformatDepthSize = 33397,
        InternalformatStencilSize = 33398,
        InternalformatSharedSize = 33399,
        InternalformatRedType = 33400,
        InternalformatGreenType = 33401,
        InternalformatBlueType = 33402,
        InternalformatAlphaType = 33403,
        InternalformatDepthType = 33404,
        InternalformatStencilType = 33405,
        MaxWidth = 33406,
        MaxHeight = 33407,
        MaxDepth = 33408,
        MaxLayers = 33409,
        ColorComponents = 33411,
        ColorRenderable = 33414,
        DepthRenderable = 33415,
        StencilRenderable = 33416,
        FramebufferRenderable = 33417,
        FramebufferRenderableLayered = 33418,
        FramebufferBlend = 33419,
        ReadPixels = 33420,
        ReadPixelsFormat = 33421,
        ReadPixelsType = 33422,
        TextureImageFormat = 33423,
        TextureImageType = 33424,
        GetTextureImageFormat = 33425,
        GetTextureImageType = 33426,
        Mipmap = 33427,
        AutoGenerateMipmap = 33429,
        ColorEncoding = 33430,
        SrgbRead = 33431,
        SrgbWrite = 33432,
        Filter = 33434,
        VertexTexture = 33435,
        TessControlTexture = 33436,
        TessEvaluationTexture = 33437,
        GeometryTexture = 33438,
        FragmentTexture = 33439,
        ComputeTexture = 33440,
        TextureShadow = 33441,
        TextureGather = 33442,
        TextureGatherShadow = 33443,
        ShaderImageLoad = 33444,
        ShaderImageStore = 33445,
        ShaderImageAtomic = 33446,
        ImageTexelSize = 33447,
        ImageCompatibilityClass = 33448,
        ImagePixelFormat = 33449,
        ImagePixelType = 33450,
        SimultaneousTextureAndDepthTest = 33452,
        SimultaneousTextureAndStencilTest = 33453,
        SimultaneousTextureAndDepthWrite = 33454,
        SimultaneousTextureAndStencilWrite = 33455,
        TextureCompressedBlockWidth = 33457,
        TextureCompressedBlockHeight = 33458,
        TextureCompressedBlockSize = 33459,
        ClearBuffer = 33460,
        TextureView = 33461,
        ViewCompatibilityClass = 33462,
        TextureCompressed = 34465,
        ImageFormatCompatibilityType = 37063,
        ClearTexture = 37733,
        NumSampleCounts = 37760
    }

    public enum ColorTableTargetSGI : uint
    {
        TextureColorTableSgi = 32956,
        ProxyTextureColorTableSgi = 32957,
        ColorTable = 32976,
        ColorTableSgi = 32976,
        PostConvolutionColorTable = 32977,
        PostConvolutionColorTableSgi = 32977,
        PostColorMatrixColorTable = 32978,
        PostColorMatrixColorTableSgi = 32978,
        ProxyColorTable = 32979,
        ProxyColorTableSgi = 32979,
        ProxyPostConvolutionColorTable = 32980,
        ProxyPostConvolutionColorTableSgi = 32980,
        ProxyPostColorMatrixColorTable = 32981,
        ProxyPostColorMatrixColorTableSgi = 32981
    }

    public enum ColorTableTarget : uint
    {
        ColorTable = 32976,
        PostConvolutionColorTable = 32977,
        PostColorMatrixColorTable = 32978,
        ProxyColorTable = 32979,
        ProxyPostConvolutionColorTable = 32980,
        ProxyPostColorMatrixColorTable = 32981
    }

    public enum GetColorTableParameterPNameSGI : uint
    {
        ColorTableScale = 32982,
        ColorTableScaleSgi = 32982,
        ColorTableBias = 32983,
        ColorTableBiasSgi = 32983,
        ColorTableFormat = 32984,
        ColorTableFormatSgi = 32984,
        ColorTableWidth = 32985,
        ColorTableWidthSgi = 32985,
        ColorTableRedSize = 32986,
        ColorTableRedSizeSgi = 32986,
        ColorTableGreenSize = 32987,
        ColorTableGreenSizeSgi = 32987,
        ColorTableBlueSize = 32988,
        ColorTableBlueSizeSgi = 32988,
        ColorTableAlphaSize = 32989,
        ColorTableAlphaSizeSgi = 32989,
        ColorTableLuminanceSize = 32990,
        ColorTableLuminanceSizeSgi = 32990,
        ColorTableIntensitySize = 32991,
        ColorTableIntensitySizeSgi = 32991
    }

    public enum ColorTableParameterPNameSGI : uint
    {
        ColorTableScale = 32982,
        ColorTableScaleSgi = 32982,
        ColorTableBias = 32983,
        ColorTableBiasSgi = 32983,
        ColorTableFormat = 32984,
        ColorTableFormatSgi = 32984,
        ColorTableWidth = 32985,
        ColorTableWidthSgi = 32985,
        ColorTableRedSize = 32986,
        ColorTableRedSizeSgi = 32986,
        ColorTableGreenSize = 32987,
        ColorTableGreenSizeSgi = 32987,
        ColorTableBlueSize = 32988,
        ColorTableBlueSizeSgi = 32988,
        ColorTableAlphaSize = 32989,
        ColorTableAlphaSizeSgi = 32989,
        ColorTableLuminanceSize = 32990,
        ColorTableLuminanceSizeSgi = 32990,
        ColorTableIntensitySize = 32991,
        ColorTableIntensitySizeSgi = 32991
    }

    public enum GetColorTableParameterPName : uint
    {
        ColorTableScale = 32982,
        ColorTableBias = 32983,
        ColorTableFormat = 32984,
        ColorTableWidth = 32985,
        ColorTableRedSize = 32986,
        ColorTableGreenSize = 32987,
        ColorTableBlueSize = 32988,
        ColorTableAlphaSize = 32989,
        ColorTableLuminanceSize = 32990,
        ColorTableIntensitySize = 32991
    }

    public enum ColorTableParameterPName : uint
    {
        ColorTableScale = 32982,
        ColorTableBias = 32983,
        ColorTableFormat = 32984,
        ColorTableWidth = 32985,
        ColorTableRedSize = 32986,
        ColorTableGreenSize = 32987,
        ColorTableBlueSize = 32988,
        ColorTableAlphaSize = 32989,
        ColorTableLuminanceSize = 32990,
        ColorTableIntensitySize = 32991
    }

    public enum BufferTargetARB : uint
    {
        ParameterBuffer = 33006,
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963,
        PixelPackBuffer = 35051,
        PixelUnpackBuffer = 35052,
        UniformBuffer = 35345,
        TextureBuffer = 35882,
        TransformFeedbackBuffer = 35982,
        CopyReadBuffer = 36662,
        CopyWriteBuffer = 36663,
        DrawIndirectBuffer = 36671,
        ShaderStorageBuffer = 37074,
        DispatchIndirectBuffer = 37102,
        QueryBuffer = 37266,
        AtomicCounterBuffer = 37568
    }

    public enum PointParameterNameSGIS : uint
    {
        PointSizeMin = 33062,
        PointSizeMinArb = 33062,
        PointSizeMinExt = 33062,
        PointSizeMinSgis = 33062,
        PointSizeMax = 33063,
        PointSizeMaxArb = 33063,
        PointSizeMaxExt = 33063,
        PointSizeMaxSgis = 33063,
        PointFadeThresholdSize = 33064,
        PointFadeThresholdSizeArb = 33064,
        PointFadeThresholdSizeExt = 33064,
        PointFadeThresholdSizeSgis = 33064,
        PointDistanceAttenuation = 33065,
        PointDistanceAttenuationArb = 33065,
        DistanceAttenuationExt = 33065,
        DistanceAttenuationSgis = 33065
    }

    public enum PointParameterNameARB : uint
    {
        PointSizeMinExt = 33062,
        PointSizeMaxExt = 33063,
        PointFadeThresholdSize = 33064,
        PointFadeThresholdSizeExt = 33064
    }

    public enum TextureFilterSGIS : uint
    {
        Filter4Sgis = 33094
    }

    public enum TextureFilterFuncSGIS : uint
    {
        Filter4Sgis = 33094
    }

    public enum SpriteParameterNameSGIX : uint
    {
        SpriteModeSgix = 33097
    }

    public enum ImageTransformPNameHP : uint
    {
        ImageScaleXHp = 33109,
        ImageScaleYHp = 33110,
        ImageTranslateXHp = 33111,
        ImageTranslateYHp = 33112,
        ImageRotateAngleHp = 33113,
        ImageRotateOriginXHp = 33114,
        ImageRotateOriginYHp = 33115,
        ImageMagFilterHp = 33116,
        ImageMinFilterHp = 33117,
        ImageCubicWeightHp = 33118
    }

    public enum ImageTransformTargetHP : uint
    {
        ImageTransform2dHp = 33121
    }

    public enum ListParameterName : uint
    {
        ListPrioritySgix = 33154
    }

    public enum PixelTexGenModeSGIX : uint
    {
    }

    public enum FfdTargetSGIX : uint
    {
        GeometryDeformationSgix = 33172,
        TextureDeformationSgix = 33173
    }

    public enum CullParameterEXT : uint
    {
        CullVertexEyePositionExt = 33195,
        CullVertexObjectPositionExt = 33196
    }

    public enum LightModelColorControl : uint
    {
        SingleColor = 33273,
        SingleColorExt = 33273,
        SeparateSpecularColor = 33274,
        SeparateSpecularColorExt = 33274
    }

    public enum ProgramTarget : uint
    {
        TextFragmentShaderAti = 33280,
        VertexProgramArb = 34336,
        FragmentProgramArb = 34820,
        TessControlProgramNv = 35102,
        TessEvaluationProgramNv = 35103,
        GeometryProgramNv = 35878,
        ComputeProgramNv = 37115
    }

    public enum FramebufferAttachmentParameterName : uint
    {
        FramebufferAttachmentColorEncoding = 33296,
        FramebufferAttachmentComponentType = 33297,
        FramebufferAttachmentRedSize = 33298,
        FramebufferAttachmentGreenSize = 33299,
        FramebufferAttachmentBlueSize = 33300,
        FramebufferAttachmentAlphaSize = 33301,
        FramebufferAttachmentDepthSize = 33302,
        FramebufferAttachmentStencilSize = 33303,
        FramebufferAttachmentObjectType = 36048,
        FramebufferAttachmentObjectTypeExt = 36048,
        FramebufferAttachmentObjectName = 36049,
        FramebufferAttachmentObjectNameExt = 36049,
        FramebufferAttachmentTextureLevel = 36050,
        FramebufferAttachmentTextureLevelExt = 36050,
        FramebufferAttachmentTextureCubeMapFace = 36051,
        FramebufferAttachmentTextureCubeMapFaceExt = 36051,
        FramebufferAttachmentTextureLayer = 36052,
        FramebufferAttachmentTexture3dZoffsetExt = 36052,
        FramebufferAttachmentTextureLayerExt = 36052,
        FramebufferAttachmentLayered = 36263,
        FramebufferAttachmentLayeredArb = 36263,
        FramebufferAttachmentLayeredExt = 36263,
        FramebufferAttachmentTextureNumViewsOvr = 38448,
        FramebufferAttachmentTextureBaseViewIndexOvr = 38450
    }

    public enum FramebufferStatus : uint
    {
        FramebufferUndefined = 33305,
        FramebufferComplete = 36053,
        FramebufferIncompleteAttachment = 36054,
        FramebufferIncompleteMissingAttachment = 36055,
        FramebufferIncompleteDrawBuffer = 36059,
        FramebufferIncompleteReadBuffer = 36060,
        FramebufferUnsupported = 36061,
        FramebufferIncompleteMultisample = 36182,
        FramebufferIncompleteLayerTargets = 36264
    }

    public enum VertexBufferObjectParameter : uint
    {
        BufferImmutableStorage = 33311,
        BufferStorageFlags = 33312,
        BufferSize = 34660,
        BufferUsage = 34661,
        BufferAccess = 35003,
        BufferMapped = 35004,
        BufferAccessFlags = 37151,
        BufferMapLength = 37152,
        BufferMapOffset = 37153
    }

    public enum BufferPNameARB : uint
    {
        BufferImmutableStorage = 33311,
        BufferStorageFlags = 33312,
        BufferSize = 34660,
        BufferSizeArb = 34660,
        BufferUsage = 34661,
        BufferUsageArb = 34661,
        BufferAccess = 35003,
        BufferAccessArb = 35003,
        BufferMapped = 35004,
        BufferMappedArb = 35004,
        BufferAccessFlags = 37151,
        BufferMapLength = 37152,
        BufferMapOffset = 37153
    }

    public enum ProgramParameterPName : uint
    {
        ProgramBinaryRetrievableHint = 33367,
        ProgramSeparable = 33368
    }

    public enum PipelineParameterName : uint
    {
        ActiveProgram = 33369,
        FragmentShader = 35632,
        VertexShader = 35633,
        InfoLogLength = 35716,
        GeometryShader = 36313,
        TessEvaluationShader = 36487,
        TessControlShader = 36488
    }

    public enum ProgramPropertyARB : uint
    {
        ComputeWorkGroupSize = 33383,
        ProgramBinaryLength = 34625,
        GeometryVerticesOut = 35094,
        GeometryInputType = 35095,
        GeometryOutputType = 35096,
        ActiveUniformBlockMaxNameLength = 35381,
        ActiveUniformBlocks = 35382,
        DeleteStatus = 35712,
        LinkStatus = 35714,
        ValidateStatus = 35715,
        InfoLogLength = 35716,
        AttachedShaders = 35717,
        ActiveUniforms = 35718,
        ActiveUniformMaxLength = 35719,
        ActiveAttributes = 35721,
        ActiveAttributeMaxLength = 35722,
        TransformFeedbackVaryingMaxLength = 35958,
        TransformFeedbackBufferMode = 35967,
        TransformFeedbackVaryings = 35971,
        ActiveAtomicCounterBuffers = 37593
    }

    public enum VertexAttribPropertyARB : uint
    {
        VertexAttribBinding = 33492,
        VertexAttribRelativeOffset = 33493,
        VertexAttribArrayEnabled = 34338,
        VertexAttribArraySize = 34339,
        VertexAttribArrayStride = 34340,
        VertexAttribArrayType = 34341,
        CurrentVertexAttrib = 34342,
        VertexAttribArrayLong = 34638,
        VertexAttribArrayNormalized = 34922,
        VertexAttribArrayBufferBinding = 34975,
        VertexAttribArrayInteger = 35069,
        VertexAttribArrayIntegerExt = 35069,
        VertexAttribArrayDivisor = 35070
    }

    public enum VertexArrayPName : uint
    {
        VertexAttribRelativeOffset = 33493,
        VertexAttribArrayEnabled = 34338,
        VertexAttribArraySize = 34339,
        VertexAttribArrayStride = 34340,
        VertexAttribArrayType = 34341,
        VertexAttribArrayLong = 34638,
        VertexAttribArrayNormalized = 34922,
        VertexAttribArrayInteger = 35069,
        VertexAttribArrayDivisor = 35070
    }

    public enum QueryObjectParameterName : uint
    {
        QueryTarget = 33514,
        QueryResult = 34918,
        QueryResultAvailable = 34919,
        QueryResultNoWait = 37268
    }

    public enum QueryTarget : uint
    {
        TransformFeedbackOverflow = 33516,
        VerticesSubmitted = 33518,
        PrimitivesSubmitted = 33519,
        VertexShaderInvocations = 33520,
        TimeElapsed = 35007,
        SamplesPassed = 35092,
        AnySamplesPassed = 35887,
        PrimitivesGenerated = 35975,
        TransformFeedbackPrimitivesWritten = 35976,
        AnySamplesPassedConservative = 36202
    }

    public enum PixelTransformTargetEXT : uint
    {
        PixelTransform2dExt = 33584
    }

    public enum PixelTransformPNameEXT : uint
    {
        PixelMagFilterExt = 33585,
        PixelMinFilterExt = 33586,
        PixelCubicWeightExt = 33587
    }

    public enum LightTextureModeEXT : uint
    {
        FragmentMaterialExt = 33609,
        FragmentNormalExt = 33610,
        FragmentColorExt = 33612,
        FragmentDepthExt = 33874
    }

    public enum LightTexturePNameEXT : uint
    {
        AttenuationExt = 33613,
        ShadowAttenuationExt = 33614
    }

    public enum PixelTexGenParameterNameSGIS : uint
    {
        PixelFragmentRgbSourceSgis = 33620,
        PixelFragmentAlphaSourceSgis = 33621
    }

    public enum LightEnvParameterSGIX : uint
    {
        LightEnvModeSgix = 33799
    }

    public enum FragmentLightModelParameterSGIX : uint
    {
        FragmentLightModelLocalViewerSgix = 33800,
        FragmentLightModelTwoSideSgix = 33801,
        FragmentLightModelAmbientSgix = 33802,
        FragmentLightModelNormalInterpolationSgix = 33803
    }

    public enum FragmentLightNameSGIX : uint
    {
        FragmentLight0Sgix = 33804,
        FragmentLight1Sgix = 33805,
        FragmentLight2Sgix = 33806,
        FragmentLight3Sgix = 33807,
        FragmentLight4Sgix = 33808,
        FragmentLight5Sgix = 33809,
        FragmentLight6Sgix = 33810,
        FragmentLight7Sgix = 33811
    }

    public enum PixelStoreResampleMode : uint
    {
        ResampleDecimateSgix = 33840,
        ResampleReplicateSgix = 33843,
        ResampleZeroFillSgix = 33844
    }

    public enum TextureUnit : uint
    {
        Texture0 = 33984,
        Texture1 = 33985,
        Texture2 = 33986,
        Texture3 = 33987,
        Texture4 = 33988,
        Texture5 = 33989,
        Texture6 = 33990,
        Texture7 = 33991,
        Texture8 = 33992,
        Texture9 = 33993,
        Texture10 = 33994,
        Texture11 = 33995,
        Texture12 = 33996,
        Texture13 = 33997,
        Texture14 = 33998,
        Texture15 = 33999,
        Texture16 = 34000,
        Texture17 = 34001,
        Texture18 = 34002,
        Texture19 = 34003,
        Texture20 = 34004,
        Texture21 = 34005,
        Texture22 = 34006,
        Texture23 = 34007,
        Texture24 = 34008,
        Texture25 = 34009,
        Texture26 = 34010,
        Texture27 = 34011,
        Texture28 = 34012,
        Texture29 = 34013,
        Texture30 = 34014,
        Texture31 = 34015
    }

    public enum CombinerRegisterNV : uint
    {
        Texture0Arb = 33984,
        Texture1Arb = 33985,
        PrimaryColorNv = 34092,
        SecondaryColorNv = 34093,
        Spare0Nv = 34094,
        Spare1Nv = 34095,
        DiscardNv = 34096
    }

    public enum UniformBlockPName : uint
    {
        UniformBlockReferencedByTessControlShader = 34032,
        UniformBlockReferencedByTessEvaluationShader = 34033,
        UniformBlockBinding = 35391,
        UniformBlockDataSize = 35392,
        UniformBlockNameLength = 35393,
        UniformBlockActiveUniforms = 35394,
        UniformBlockActiveUniformIndices = 35395,
        UniformBlockReferencedByVertexShader = 35396,
        UniformBlockReferencedByGeometryShader = 35397,
        UniformBlockReferencedByFragmentShader = 35398,
        UniformBlockReferencedByComputeShader = 37100
    }

    public enum FenceConditionNV : uint
    {
        AllCompletedNv = 34034
    }

    public enum FenceParameterNameNV : uint
    {
        FenceStatusNv = 34035,
        FenceConditionNv = 34036
    }

    public enum CombinerVariableNV : uint
    {
        VariableANv = 34083,
        VariableBNv = 34084,
        VariableCNv = 34085,
        VariableDNv = 34086,
        VariableENv = 34087,
        VariableFNv = 34088,
        VariableGNv = 34089
    }

    public enum PathColor : uint
    {
        PrimaryColorNv = 34092,
        SecondaryColorNv = 34093,
        PrimaryColor = 34167
    }

    public enum CombinerMappingNV : uint
    {
        UnsignedIdentityNv = 34102,
        UnsignedInvertNv = 34103,
        ExpandNormalNv = 34104,
        ExpandNegateNv = 34105,
        HalfBiasNormalNv = 34106,
        HalfBiasNegateNv = 34107,
        SignedIdentityNv = 34108,
        SignedNegateNv = 34109
    }

    public enum CombinerParameterNV : uint
    {
        CombinerInputNv = 34114,
        CombinerMappingNv = 34115,
        CombinerComponentUsageNv = 34116
    }

    public enum CombinerStageNV : uint
    {
        Combiner0Nv = 34128,
        Combiner1Nv = 34129,
        Combiner2Nv = 34130,
        Combiner3Nv = 34131,
        Combiner4Nv = 34132,
        Combiner5Nv = 34133,
        Combiner6Nv = 34134,
        Combiner7Nv = 34135
    }

    public enum RegisterCombinerPname : uint
    {
        Combine = 34160,
        CombineArb = 34160,
        CombineExt = 34160,
        CombineRgb = 34161,
        CombineRgbArb = 34161,
        CombineRgbExt = 34161,
        CombineAlpha = 34162,
        CombineAlphaArb = 34162,
        CombineAlphaExt = 34162,
        RgbScale = 34163,
        RgbScaleArb = 34163,
        RgbScaleExt = 34163,
        AddSigned = 34164,
        AddSignedArb = 34164,
        AddSignedExt = 34164,
        Interpolate = 34165,
        InterpolateArb = 34165,
        InterpolateExt = 34165,
        Constant = 34166,
        ConstantArb = 34166,
        ConstantExt = 34166,
        ConstantNv = 34166,
        PrimaryColor = 34167,
        PrimaryColorArb = 34167,
        PrimaryColorExt = 34167,
        Previous = 34168,
        PreviousArb = 34168,
        PreviousExt = 34168,
        Source0Rgb = 34176,
        Src0Rgb = 34176,
        Source0RgbArb = 34176,
        Source0RgbExt = 34176,
        Source1Rgb = 34177,
        Src1Rgb = 34177,
        Source1RgbArb = 34177,
        Source1RgbExt = 34177,
        Source2Rgb = 34178,
        Src2Rgb = 34178,
        Source2RgbArb = 34178,
        Source2RgbExt = 34178,
        Source3RgbNv = 34179,
        Source0Alpha = 34184,
        Src0Alpha = 34184,
        Source0AlphaArb = 34184,
        Source0AlphaExt = 34184,
        Source1Alpha = 34185,
        Src1Alpha = 34185,
        Source1AlphaArb = 34185,
        Source1AlphaExt = 34185,
        Source2Alpha = 34186,
        Src2Alpha = 34186,
        Source2AlphaArb = 34186,
        Source2AlphaExt = 34186,
        Source3AlphaNv = 34187,
        Operand0Rgb = 34192,
        Operand0RgbArb = 34192,
        Operand0RgbExt = 34192,
        Operand1Rgb = 34193,
        Operand1RgbArb = 34193,
        Operand1RgbExt = 34193,
        Operand2Rgb = 34194,
        Operand2RgbArb = 34194,
        Operand2RgbExt = 34194,
        Operand3RgbNv = 34195,
        Operand0Alpha = 34200,
        Operand0AlphaArb = 34200,
        Operand0AlphaExt = 34200,
        Operand1Alpha = 34201,
        Operand1AlphaArb = 34201,
        Operand1AlphaExt = 34201,
        Operand2Alpha = 34202,
        Operand2AlphaArb = 34202,
        Operand2AlphaExt = 34202,
        Operand3AlphaNv = 34203
    }

    public enum PixelStoreSubsampleRate : uint
    {
        PixelSubsample4444Sgix = 34210,
        PixelSubsample2424Sgix = 34211,
        PixelSubsample4242Sgix = 34212
    }

    public enum TextureNormalModeEXT : uint
    {
        PerturbExt = 34222
    }

    public enum VertexArrayPNameAPPLE : uint
    {
        StorageClientApple = 34228,
        StorageCachedApple = 34238,
        StorageSharedApple = 34239
    }

    public enum VertexAttribEnum : uint
    {
        VertexAttribArrayEnabled = 34338,
        VertexAttribArraySize = 34339,
        VertexAttribArrayStride = 34340,
        VertexAttribArrayType = 34341,
        CurrentVertexAttrib = 34342,
        VertexAttribArrayNormalized = 34922,
        VertexAttribArrayBufferBinding = 34975,
        VertexAttribArrayInteger = 35069,
        VertexAttribArrayDivisor = 35070
    }

    public enum ProgramStringProperty : uint
    {
        ProgramStringArb = 34344
    }

    public enum VertexAttribEnumNV : uint
    {
        ProgramParameterNv = 34372
    }

    public enum VertexAttribPointerPropertyARB : uint
    {
        VertexAttribArrayPointer = 34373,
        VertexAttribArrayPointerArb = 34373
    }

    public enum EvalTargetNV : uint
    {
        Eval2dNv = 34496,
        EvalTriangular2dNv = 34497
    }

    public enum MapParameterNV : uint
    {
        MapTessellationNv = 34498
    }

    public enum MapAttribParameterNV : uint
    {
        MapAttribUOrderNv = 34499,
        MapAttribVOrderNv = 34500
    }

    public enum ArrayObjectUsageATI : uint
    {
        StaticAti = 34656,
        DynamicAti = 34657
    }

    public enum PreserveModeATI : uint
    {
        PreserveAti = 34658,
        DiscardAti = 34659
    }

    public enum ArrayObjectPNameATI : uint
    {
        ObjectBufferSizeAti = 34660,
        ObjectBufferUsageAti = 34661
    }

    public enum VertexStreamATI : uint
    {
        VertexStream0Ati = 34668,
        VertexStream1Ati = 34669,
        VertexStream2Ati = 34670,
        VertexStream3Ati = 34671,
        VertexStream4Ati = 34672,
        VertexStream5Ati = 34673,
        VertexStream6Ati = 34674,
        VertexStream7Ati = 34675
    }

    public enum GetTexBumpParameterATI : uint
    {
        BumpRotMatrixAti = 34677,
        BumpRotMatrixSizeAti = 34678,
        BumpNumTexUnitsAti = 34679,
        BumpTexUnitsAti = 34680
    }

    public enum TexBumpParameterATI : uint
    {
        BumpRotMatrixAti = 34677
    }

    public enum VertexShaderOpEXT : uint
    {
        OpIndexExt = 34690,
        OpNegateExt = 34691,
        OpDot3Ext = 34692,
        OpDot4Ext = 34693,
        OpMulExt = 34694,
        OpAddExt = 34695,
        OpMaddExt = 34696,
        OpFracExt = 34697,
        OpMaxExt = 34698,
        OpMinExt = 34699,
        OpSetGeExt = 34700,
        OpSetLtExt = 34701,
        OpClampExt = 34702,
        OpFloorExt = 34703,
        OpRoundExt = 34704,
        OpExpBase2Ext = 34705,
        OpLogBase2Ext = 34706,
        OpPowerExt = 34707,
        OpRecipExt = 34708,
        OpRecipSqrtExt = 34709,
        OpSubExt = 34710,
        OpCrossProductExt = 34711,
        OpMultiplyMatrixExt = 34712,
        OpMovExt = 34713
    }

    public enum DataTypeEXT : uint
    {
        ScalarExt = 34750,
        VectorExt = 34751,
        MatrixExt = 34752
    }

    public enum VertexShaderStorageTypeEXT : uint
    {
        VariantExt = 34753,
        InvariantExt = 34754,
        LocalConstantExt = 34755,
        LocalExt = 34756
    }

    public enum VertexShaderCoordOutEXT : uint
    {
        XExt = 34773,
        YExt = 34774,
        ZExt = 34775,
        WExt = 34776,
        NegativeXExt = 34777,
        NegativeYExt = 34778,
        NegativeZExt = 34779,
        NegativeWExt = 34780,
        ZeroExt = 34781,
        OneExt = 34782,
        NegativeOneExt = 34783
    }

    public enum ParameterRangeEXT : uint
    {
        NormalizedRangeExt = 34784,
        FullRangeExt = 34785
    }

    public enum VertexShaderParameterEXT : uint
    {
        CurrentVertexExt = 34786,
        MvpMatrixExt = 34787
    }

    public enum GetVariantValueEXT : uint
    {
        VariantValueExt = 34788,
        VariantDatatypeExt = 34789,
        VariantArrayStrideExt = 34790,
        VariantArrayTypeExt = 34791
    }

    public enum VariantCapEXT : uint
    {
        VariantArrayExt = 34792
    }

    public enum PNTrianglesPNameATI : uint
    {
        PnTrianglesPointModeAti = 34802,
        PnTrianglesNormalModeAti = 34803,
        PnTrianglesTesselationLevelAti = 34804
    }

    public enum QueryParameterName : uint
    {
        QueryCounterBits = 34916,
        CurrentQuery = 34917
    }

    public enum OcclusionQueryParameterNameNV : uint
    {
        PixelCountNv = 34918,
        PixelCountAvailableNv = 34919
    }

    public enum ProgramFormat : uint
    {
        ProgramFormatAsciiArb = 34933
    }

    public enum PixelDataRangeTargetNV : uint
    {
        WritePixelDataRangeNv = 34936,
        ReadPixelDataRangeNv = 34937
    }

    public enum CopyBufferSubDataTarget : uint
    {
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963,
        PixelPackBuffer = 35051,
        PixelUnpackBuffer = 35052,
        UniformBuffer = 35345,
        TextureBuffer = 35882,
        TransformFeedbackBuffer = 35982,
        CopyReadBuffer = 36662,
        CopyWriteBuffer = 36663,
        DrawIndirectBuffer = 36671,
        ShaderStorageBuffer = 37074,
        DispatchIndirectBuffer = 37102,
        QueryBuffer = 37266,
        AtomicCounterBuffer = 37568
    }

    public enum BufferStorageTarget : uint
    {
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963,
        PixelPackBuffer = 35051,
        PixelUnpackBuffer = 35052,
        UniformBuffer = 35345,
        TextureBuffer = 35882,
        TransformFeedbackBuffer = 35982,
        CopyReadBuffer = 36662,
        CopyWriteBuffer = 36663,
        DrawIndirectBuffer = 36671,
        ShaderStorageBuffer = 37074,
        DispatchIndirectBuffer = 37102,
        QueryBuffer = 37266,
        AtomicCounterBuffer = 37568
    }

    public enum BufferAccessARB : uint
    {
        ReadOnly = 35000,
        WriteOnly = 35001,
        ReadWrite = 35002
    }

    public enum BufferPointerNameARB : uint
    {
        BufferMapPointer = 35005,
        BufferMapPointerArb = 35005
    }

    public enum VertexBufferObjectUsage : uint
    {
        StreamDraw = 35040,
        StreamRead = 35041,
        StreamCopy = 35042,
        StaticDraw = 35044,
        StaticRead = 35045,
        StaticCopy = 35046,
        DynamicDraw = 35048,
        DynamicRead = 35049,
        DynamicCopy = 35050
    }

    public enum BufferUsageARB : uint
    {
        StreamDraw = 35040,
        StreamRead = 35041,
        StreamCopy = 35042,
        StaticDraw = 35044,
        StaticRead = 35045,
        StaticCopy = 35046,
        DynamicDraw = 35048,
        DynamicRead = 35049,
        DynamicCopy = 35050
    }

    public enum ClampColorTargetARB : uint
    {
        ClampVertexColorArb = 35098,
        ClampFragmentColorArb = 35099,
        ClampReadColor = 35100,
        ClampReadColorArb = 35100
    }

    public enum FragmentOpATI : uint
    {
        MovAti = 35169,
        AddAti = 35171,
        MulAti = 35172,
        SubAti = 35173,
        Dot3Ati = 35174,
        Dot4Ati = 35175,
        MadAti = 35176,
        LerpAti = 35177,
        CndAti = 35178,
        Cnd0Ati = 35179,
        Dot2AddAti = 35180
    }

    public enum SwizzleOpATI : uint
    {
        SwizzleStrAti = 35190,
        SwizzleStqAti = 35191,
        SwizzleStrDrAti = 35192,
        SwizzleStqDqAti = 35193
    }

    public enum ObjectTypeAPPLE : uint
    {
        DrawPixelsApple = 35338,
        FenceApple = 35339
    }

    public enum UniformPName : uint
    {
        UniformType = 35383,
        UniformSize = 35384,
        UniformNameLength = 35385,
        UniformBlockIndex = 35386,
        UniformOffset = 35387,
        UniformArrayStride = 35388,
        UniformMatrixStride = 35389,
        UniformIsRowMajor = 35390,
        UniformAtomicCounterBufferIndex = 37594
    }

    public enum SubroutineParameterName : uint
    {
        UniformSize = 35384,
        UniformNameLength = 35385,
        NumCompatibleSubroutines = 36426,
        CompatibleSubroutines = 36427
    }

    public enum ShaderType : uint
    {
        FragmentShader = 35632,
        FragmentShaderArb = 35632,
        VertexShader = 35633,
        VertexShaderArb = 35633,
        GeometryShader = 36313,
        TessEvaluationShader = 36487,
        TessControlShader = 36488,
        ComputeShader = 37305
    }

    public enum ContainerType : uint
    {
        ProgramObjectArb = 35648,
        ProgramObjectExt = 35648
    }

    public enum ShaderParameterName : uint
    {
        ShaderType = 35663,
        DeleteStatus = 35712,
        CompileStatus = 35713,
        InfoLogLength = 35716,
        ShaderSourceLength = 35720
    }

    public enum ShaderBinaryFormat : uint
    {
        ShaderBinaryFormatSpirV = 38225
    }

    public enum TransformFeedbackPName : uint
    {
        TransformFeedbackBufferStart = 35972,
        TransformFeedbackBufferSize = 35973,
        TransformFeedbackBufferBinding = 35983,
        TransformFeedbackPaused = 36387,
        TransformFeedbackActive = 36388
    }

    public enum TransformFeedbackBufferMode : uint
    {
        InterleavedAttribs = 35980,
        SeparateAttribs = 35981
    }

    public enum ProgramInterface : uint
    {
        TransformFeedbackBuffer = 35982,
        Uniform = 37601,
        UniformBlock = 37602,
        ProgramInput = 37603,
        ProgramOutput = 37604,
        BufferVariable = 37605,
        ShaderStorageBlock = 37606,
        VertexSubroutine = 37608,
        TessControlSubroutine = 37609,
        TessEvaluationSubroutine = 37610,
        GeometrySubroutine = 37611,
        FragmentSubroutine = 37612,
        ComputeSubroutine = 37613,
        VertexSubroutineUniform = 37614,
        TessControlSubroutineUniform = 37615,
        TessEvaluationSubroutineUniform = 37616,
        GeometrySubroutineUniform = 37617,
        FragmentSubroutineUniform = 37618,
        ComputeSubroutineUniform = 37619,
        TransformFeedbackVarying = 37620
    }

    public enum ClipControlOrigin : uint
    {
        LowerLeft = 36001,
        UpperLeft = 36002
    }

    public enum CheckFramebufferStatusTarget : uint
    {
        ReadFramebuffer = 36008,
        DrawFramebuffer = 36009,
        Framebuffer = 36160
    }

    public enum FramebufferTarget : uint
    {
        ReadFramebuffer = 36008,
        DrawFramebuffer = 36009,
        Framebuffer = 36160
    }

    public enum RenderbufferParameterName : uint
    {
        RenderbufferSamples = 36011,
        RenderbufferSamplesExt = 36011,
        RenderbufferCoverageSamplesNv = 36011,
        RenderbufferWidth = 36162,
        RenderbufferWidthExt = 36162,
        RenderbufferHeight = 36163,
        RenderbufferHeightExt = 36163,
        RenderbufferInternalFormat = 36164,
        RenderbufferInternalFormatExt = 36164,
        RenderbufferRedSize = 36176,
        RenderbufferRedSizeExt = 36176,
        RenderbufferGreenSize = 36177,
        RenderbufferGreenSizeExt = 36177,
        RenderbufferBlueSize = 36178,
        RenderbufferBlueSizeExt = 36178,
        RenderbufferAlphaSize = 36179,
        RenderbufferAlphaSizeExt = 36179,
        RenderbufferDepthSize = 36180,
        RenderbufferDepthSizeExt = 36180,
        RenderbufferStencilSize = 36181,
        RenderbufferStencilSizeExt = 36181,
        RenderbufferColorSamplesNv = 36368,
        RenderbufferStorageSamplesAmd = 37298
    }

    public enum FramebufferAttachment : uint
    {
        ColorAttachment0 = 36064,
        ColorAttachment1 = 36065,
        ColorAttachment2 = 36066,
        ColorAttachment3 = 36067,
        ColorAttachment4 = 36068,
        ColorAttachment5 = 36069,
        ColorAttachment6 = 36070,
        ColorAttachment7 = 36071,
        ColorAttachment8 = 36072,
        ColorAttachment9 = 36073,
        ColorAttachment10 = 36074,
        ColorAttachment11 = 36075,
        ColorAttachment12 = 36076,
        ColorAttachment13 = 36077,
        ColorAttachment14 = 36078,
        ColorAttachment15 = 36079,
        ColorAttachment16 = 36080,
        ColorAttachment17 = 36081,
        ColorAttachment18 = 36082,
        ColorAttachment19 = 36083,
        ColorAttachment20 = 36084,
        ColorAttachment21 = 36085,
        ColorAttachment22 = 36086,
        ColorAttachment23 = 36087,
        ColorAttachment24 = 36088,
        ColorAttachment25 = 36089,
        ColorAttachment26 = 36090,
        ColorAttachment27 = 36091,
        ColorAttachment28 = 36092,
        ColorAttachment29 = 36093,
        ColorAttachment30 = 36094,
        ColorAttachment31 = 36095,
        DepthAttachment = 36096,
        StencilAttachment = 36128
    }

    public enum RenderbufferTarget : uint
    {
        Renderbuffer = 36161
    }

    public enum ProgramStagePName : uint
    {
        ActiveSubroutines = 36325,
        ActiveSubroutineUniforms = 36326,
        ActiveSubroutineUniformLocations = 36423,
        ActiveSubroutineMaxLength = 36424,
        ActiveSubroutineUniformMaxLength = 36425
    }

    public enum PrecisionType : uint
    {
        LowFloat = 36336,
        MediumFloat = 36337,
        HighFloat = 36338,
        LowInt = 36339,
        MediumInt = 36340,
        HighInt = 36341
    }

    public enum ConditionalRenderMode : uint
    {
        QueryWait = 36371,
        QueryNoWait = 36372,
        QueryByRegionWait = 36373,
        QueryByRegionNoWait = 36374,
        QueryWaitInverted = 36375,
        QueryNoWaitInverted = 36376,
        QueryByRegionWaitInverted = 36377,
        QueryByRegionNoWaitInverted = 36378
    }

    public enum BindTransformFeedbackTarget : uint
    {
        TransformFeedback = 36386
    }

    public enum QueryCounterTarget : uint
    {
        Timestamp = 36392
    }

    public enum ProgramResourceProperty : uint
    {
        NumCompatibleSubroutines = 36426,
        CompatibleSubroutines = 36427,
        Uniform = 37601,
        IsPerPatch = 37607,
        NameLength = 37625,
        Type = 37626,
        ArraySize = 37627,
        Offset = 37628,
        BlockIndex = 37629,
        ArrayStride = 37630,
        MatrixStride = 37631,
        IsRowMajor = 37632,
        AtomicCounterBufferIndex = 37633,
        BufferBinding = 37634,
        BufferDataSize = 37635,
        NumActiveVariables = 37636,
        ActiveVariables = 37637,
        ReferencedByVertexShader = 37638,
        ReferencedByTessControlShader = 37639,
        ReferencedByTessEvaluationShader = 37640,
        ReferencedByGeometryShader = 37641,
        ReferencedByFragmentShader = 37642,
        ReferencedByComputeShader = 37643,
        TopLevelArraySize = 37644,
        TopLevelArrayStride = 37645,
        Location = 37646,
        LocationIndex = 37647,
        LocationComponent = 37706,
        TransformFeedbackBufferIndex = 37707,
        TransformFeedbackBufferStride = 37708
    }

    public enum VertexProvokingMode : uint
    {
        FirstVertexConvention = 36429,
        LastVertexConvention = 36430
    }

    public enum GetMultisamplePNameNV : uint
    {
        SamplePosition = 36432,
        SampleLocationArb = 36432,
        ProgrammableSampleLocationArb = 37697
    }

    public enum PatchParameterName : uint
    {
        PatchVertices = 36466,
        PatchDefaultInnerLevel = 36467,
        PatchDefaultOuterLevel = 36468
    }

    public enum PathStringFormat : uint
    {
        PathFormatSvgNv = 36976,
        PathFormatPsNv = 36977
    }

    public enum PathFontTarget : uint
    {
        StandardFontNameNv = 36978,
        SystemFontNameNv = 36979,
        FileNameNv = 36980
    }

    public enum PathParameter : uint
    {
        PathStrokeWidthNv = 36981,
        PathEndCapsNv = 36982,
        PathInitialEndCapNv = 36983,
        PathTerminalEndCapNv = 36984,
        PathJoinStyleNv = 36985,
        PathMiterLimitNv = 36986,
        PathDashCapsNv = 36987,
        PathInitialDashCapNv = 36988,
        PathTerminalDashCapNv = 36989,
        PathDashOffsetNv = 36990,
        PathClientLengthNv = 36991,
        PathFillModeNv = 36992,
        PathFillMaskNv = 36993,
        PathFillCoverModeNv = 36994,
        PathStrokeCoverModeNv = 36995,
        PathStrokeMaskNv = 36996,
        PathObjectBoundingBoxNv = 37002,
        PathCommandCountNv = 37021,
        PathCoordCountNv = 37022,
        PathDashArrayCountNv = 37023,
        PathComputedLengthNv = 37024,
        PathFillBoundingBoxNv = 37025,
        PathStrokeBoundingBoxNv = 37026,
        PathDashOffsetResetNv = 37044
    }

    public enum PathCoverMode : uint
    {
        PathFillCoverModeNv = 36994,
        ConvexHullNv = 37003,
        BoundingBoxNv = 37005,
        BoundingBoxOfBoundingBoxesNv = 37020
    }

    public enum PathElementType : uint
    {
        Utf8Nv = 37018,
        Utf16Nv = 37019
    }

    public enum PathHandleMissingGlyphs : uint
    {
        SkipMissingGlyphNv = 37033,
        UseMissingGlyphNv = 37034
    }

    public enum PathListMode : uint
    {
        AccumAdjacentPairsNv = 37037,
        AdjacentPairsNv = 37038,
        FirstToRestNv = 37039
    }

    public enum AtomicCounterBufferPName : uint
    {
        AtomicCounterBufferReferencedByComputeShader = 37101,
        AtomicCounterBufferBinding = 37569,
        AtomicCounterBufferDataSize = 37572,
        AtomicCounterBufferActiveAtomicCounters = 37573,
        AtomicCounterBufferActiveAtomicCounterIndices = 37574,
        AtomicCounterBufferReferencedByVertexShader = 37575,
        AtomicCounterBufferReferencedByTessControlShader = 37576,
        AtomicCounterBufferReferencedByTessEvaluationShader = 37577,
        AtomicCounterBufferReferencedByGeometryShader = 37578,
        AtomicCounterBufferReferencedByFragmentShader = 37579
    }

    public enum SyncParameterName : uint
    {
        ObjectType = 37138,
        SyncCondition = 37139,
        SyncStatus = 37140,
        SyncFlags = 37141
    }

    public enum SyncCondition : uint
    {
        SyncGpuCommandsComplete = 37143
    }

    public enum SyncStatus : uint
    {
        AlreadySignaled = 37146,
        TimeoutExpired = 37147,
        ConditionSatisfied = 37148,
        WaitFailed = 37149
    }

    public enum ProgramInterfacePName : uint
    {
        ActiveResources = 37621,
        MaxNameLength = 37622,
        MaxNumActiveVariables = 37623,
        MaxNumCompatibleSubroutines = 37624
    }

    public enum FramebufferParameterName : uint
    {
        FramebufferDefaultWidth = 37648,
        FramebufferDefaultHeight = 37649,
        FramebufferDefaultLayers = 37650,
        FramebufferDefaultSamples = 37651,
        FramebufferDefaultFixedSampleLocations = 37652
    }

    public enum ClipControlDepth : uint
    {
        NegativeOneToOne = 37726,
        ZeroToOne = 37727
    }

    public enum TextureLayout : uint
    {
        LayoutDepthReadOnlyStencilAttachmentExt = 38192,
        LayoutDepthAttachmentStencilReadOnlyExt = 38193,
        LayoutGeneralExt = 38285,
        LayoutColorAttachmentExt = 38286,
        LayoutDepthStencilAttachmentExt = 38287,
        LayoutDepthStencilReadOnlyExt = 38288,
        LayoutShaderReadOnlyExt = 38289,
        LayoutTransferSrcExt = 38290,
        LayoutTransferDstExt = 38291
    }

    public enum MemoryObjectParameterName : uint
    {
        DedicatedMemoryObjectExt = 38273,
        ProtectedMemoryObjectExt = 38299
    }

    public enum ExternalHandleType : uint
    {
        HandleTypeOpaqueFdExt = 38278,
        HandleTypeOpaqueWin32Ext = 38279,
        HandleTypeOpaqueWin32KmtExt = 38280,
        HandleTypeD3d12TilepoolExt = 38281,
        HandleTypeD3d12ResourceExt = 38282,
        HandleTypeD3d11ImageExt = 38283,
        HandleTypeD3d11ImageKmtExt = 38284,
        HandleTypeD3d12FenceExt = 38292
    }

    public enum SemaphoreParameterName : uint
    {
        D3d12FenceValueExt = 38293,
        TimelineSemaphoreValueNv = 38293,
        SemaphoreTypeNv = 38323,
        SemaphoreTypeBinaryNv = 38324,
        SemaphoreTypeTimelineNv = 38325
    }

    public enum HintTargetPGI : uint
    {
        VertexDataHintPgi = 107050,
        VertexConsistentHintPgi = 107051,
        MaterialSideHintPgi = 107052,
        MaxVertexHintPgi = 107053
    }

#pragma warning restore CA1069 // Enums should not have duplicate values
}
