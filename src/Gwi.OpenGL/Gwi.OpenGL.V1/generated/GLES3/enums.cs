// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES3
{
#pragma warning disable CA1069 // Enums should not have duplicate values

    // TODO: Temporary fake definition needed to satisfy NV extension
    public enum SampleMaskNV : uint { }

    [Flags]
    public enum AttribMask : uint
    {
        DepthBufferBit = 256,
        StencilBufferBit = 1024,
        ColorBufferBit = 16384
    }

    [Flags]
    public enum ClearBufferMask : uint
    {
        DepthBufferBit = 256,
        StencilBufferBit = 1024,
        ColorBufferBit = 16384,
        CoverageBufferBitNv = 32768
    }

    [Flags]
    public enum BufferStorageMask : uint
    {
        MapReadBit = 1,
        MapReadBitExt = 1,
        MapWriteBit = 2,
        MapWriteBitExt = 2,
        MapPersistentBitExt = 64,
        MapCoherentBitExt = 128,
        DynamicStorageBitExt = 256,
        ClientStorageBitExt = 512
    }

    [Flags]
    public enum ContextFlagMask : uint
    {
        ContextFlagDebugBit = 2,
        ContextFlagDebugBitKhr = 2,
        ContextFlagRobustAccessBit = 4,
        ContextFlagNoErrorBitKhr = 8,
        ContextFlagProtectedContentBitExt = 16
    }

    [Flags]
    public enum MapBufferAccessMask : uint
    {
        MapReadBit = 1,
        MapReadBitExt = 1,
        MapWriteBit = 2,
        MapWriteBitExt = 2,
        MapInvalidateRangeBit = 4,
        MapInvalidateRangeBitExt = 4,
        MapInvalidateBufferBit = 8,
        MapInvalidateBufferBitExt = 8,
        MapFlushExplicitBit = 16,
        MapFlushExplicitBitExt = 16,
        MapUnsynchronizedBit = 32,
        MapUnsynchronizedBitExt = 32,
        MapPersistentBitExt = 64,
        MapCoherentBitExt = 128
    }

    [Flags]
    public enum MemoryBarrierMask : uint
    {
        VertexAttribArrayBarrierBit = 1,
        ElementArrayBarrierBit = 2,
        UniformBarrierBit = 4,
        TextureFetchBarrierBit = 8,
        ShaderImageAccessBarrierBit = 32,
        CommandBarrierBit = 64,
        PixelBufferBarrierBit = 128,
        TextureUpdateBarrierBit = 256,
        BufferUpdateBarrierBit = 512,
        FramebufferBarrierBit = 1024,
        TransformFeedbackBarrierBit = 2048,
        AtomicCounterBarrierBit = 4096,
        ShaderStorageBarrierBit = 8192,
        ClientMappedBufferBarrierBitExt = 16384,
        AllBarrierBits = 4294967295
    }

    [Flags]
    public enum SyncObjectMask : uint
    {
        SyncFlushCommandsBit = 1,
        SyncFlushCommandsBitApple = 1
    }

    [Flags]
    public enum UseProgramStageMask : uint
    {
        VertexShaderBit = 1,
        VertexShaderBitExt = 1,
        FragmentShaderBit = 2,
        FragmentShaderBitExt = 2,
        GeometryShaderBit = 4,
        GeometryShaderBitExt = 4,
        GeometryShaderBitOes = 4,
        TessControlShaderBit = 8,
        TessControlShaderBitExt = 8,
        TessControlShaderBitOes = 8,
        TessEvaluationShaderBit = 16,
        TessEvaluationShaderBitExt = 16,
        TessEvaluationShaderBitOes = 16,
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
    public enum BufferBitQCOM : uint
    {
        ColorBufferBit0Qcom = 1,
        ColorBufferBit1Qcom = 2,
        ColorBufferBit2Qcom = 4,
        ColorBufferBit3Qcom = 8,
        ColorBufferBit4Qcom = 16,
        ColorBufferBit5Qcom = 32,
        ColorBufferBit6Qcom = 64,
        ColorBufferBit7Qcom = 128,
        DepthBufferBit0Qcom = 256,
        DepthBufferBit1Qcom = 512,
        DepthBufferBit2Qcom = 1024,
        DepthBufferBit3Qcom = 2048,
        DepthBufferBit4Qcom = 4096,
        DepthBufferBit5Qcom = 8192,
        DepthBufferBit6Qcom = 16384,
        DepthBufferBit7Qcom = 32768,
        StencilBufferBit0Qcom = 65536,
        StencilBufferBit1Qcom = 131072,
        StencilBufferBit2Qcom = 262144,
        StencilBufferBit3Qcom = 524288,
        StencilBufferBit4Qcom = 1048576,
        StencilBufferBit5Qcom = 2097152,
        StencilBufferBit6Qcom = 4194304,
        StencilBufferBit7Qcom = 8388608,
        MultisampleBufferBit0Qcom = 16777216,
        MultisampleBufferBit1Qcom = 33554432,
        MultisampleBufferBit2Qcom = 67108864,
        MultisampleBufferBit3Qcom = 134217728,
        MultisampleBufferBit4Qcom = 268435456,
        MultisampleBufferBit5Qcom = 536870912,
        MultisampleBufferBit6Qcom = 1073741824,
        MultisampleBufferBit7Qcom = 2147483648
    }

    [Flags]
    public enum FoveationConfigBitQCOM : uint
    {
        FoveationEnableBitQcom = 1,
        FoveationScaledBinMethodBitQcom = 2,
        FoveationSubsampledLayoutMethodBitQcom = 4
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
        True = 1
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
        InvalidFramebufferOperation = 1286
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
        OneMinusConstantAlpha = 32772
    }

    public enum SyncBehaviorFlags : uint
    {
        None = 0
    }

    public enum TextureCompareMode : uint
    {
        None = 0,
        CompareRefToTexture = 34894
    }

    public enum PathColorFormat : uint
    {
        None = 0,
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410
    }

    public enum CombinerBiasNV : uint
    {
        None = 0
    }

    public enum CombinerScaleNV : uint
    {
        None = 0
    }

    public enum DrawBufferMode : uint
    {
        None = 0,
        Front = 1028,
        Back = 1029,
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
        Front = 1028,
        Back = 1029,
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
        Front = 1028,
        Back = 1029,
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
        QuadsExt = 7,
        LinesAdjacency = 10,
        LinesAdjacencyExt = 10,
        LineStripAdjacency = 11,
        LineStripAdjacencyExt = 11,
        TrianglesAdjacency = 12,
        TrianglesAdjacencyExt = 12,
        TriangleStripAdjacency = 13,
        TriangleStripAdjacencyExt = 13,
        Patches = 14,
        PatchesExt = 14
    }

    public enum TextureEnvMode : uint
    {
        Blend = 3042
    }

    public enum LightEnvModeSGIX : uint
    {
        Replace = 7681
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

    public enum FogMode : uint
    {
        Linear = 9729
    }

    public enum FrontFaceDirection : uint
    {
        Cw = 2304,
        Ccw = 2305
    }

    public enum GetPName : uint
    {
        LineWidth = 2849,
        CullFace = 2884,
        CullFaceMode = 2885,
        FrontFace = 2886,
        DepthRange = 2928,
        DepthTest = 2929,
        DepthWritemask = 2930,
        DepthClearValue = 2931,
        DepthFunc = 2932,
        StencilTest = 2960,
        StencilClearValue = 2961,
        StencilFunc = 2962,
        StencilValueMask = 2963,
        StencilFail = 2964,
        StencilPassDepthFail = 2965,
        StencilPassDepthPass = 2966,
        StencilRef = 2967,
        StencilWritemask = 2968,
        Viewport = 2978,
        AlphaTestQcom = 3008,
        AlphaTestFuncQcom = 3009,
        AlphaTestRefQcom = 3010,
        Dither = 3024,
        Blend = 3042,
        DrawBufferExt = 3073,
        ReadBuffer = 3074,
        ReadBufferExt = 3074,
        ReadBufferNv = 3074,
        ScissorBox = 3088,
        ScissorTest = 3089,
        ColorClearValue = 3106,
        ColorWritemask = 3107,
        UnpackRowLength = 3314,
        UnpackSkipRows = 3315,
        UnpackSkipPixels = 3316,
        UnpackAlignment = 3317,
        PackRowLength = 3330,
        PackSkipRows = 3331,
        PackSkipPixels = 3332,
        PackAlignment = 3333,
        MaxTextureSize = 3379,
        MaxViewportDims = 3386,
        SubpixelBits = 3408,
        RedBits = 3410,
        GreenBits = 3411,
        BlueBits = 3412,
        AlphaBits = 3413,
        DepthBits = 3414,
        StencilBits = 3415,
        Texture2d = 3553,
        PolygonOffsetUnits = 10752,
        BlendColor = 32773,
        BlendEquationRgb = 32777,
        BlendEquationExt = 32777,
        PolygonOffsetFill = 32823,
        PolygonOffsetFactor = 32824,
        TextureBinding2d = 32873,
        TextureBinding3d = 32874,
        UnpackSkipImages = 32877,
        UnpackImageHeight = 32878,
        Max3dTextureSize = 32883,
        VertexArray = 32884,
        SampleBuffers = 32936,
        Samples = 32937,
        SampleCoverageValue = 32938,
        SampleCoverageInvert = 32939,
        BlendDstRgb = 32968,
        BlendSrcRgb = 32969,
        BlendDstAlpha = 32970,
        BlendSrcAlpha = 32971,
        MaxElementsVertices = 33000,
        MaxElementsIndices = 33001,
        MajorVersion = 33307,
        MinorVersion = 33308,
        NumExtensions = 33309,
        ContextFlags = 33310,
        ProgramPipelineBinding = 33370,
        LayerProvokingVertex = 33374,
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
        AliasedPointSizeRange = 33901,
        AliasedLineWidthRange = 33902,
        ActiveTexture = 34016,
        MaxRenderbufferSize = 34024,
        MaxTextureLodBias = 34045,
        TextureBindingCubeMap = 34068,
        MaxCubeMapTextureSize = 34076,
        VertexArrayBinding = 34229,
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
        MaxVaryingComponents = 35659,
        MaxVertexTextureImageUnits = 35660,
        MaxCombinedTextureImageUnits = 35661,
        FragmentShaderDerivativeHint = 35723,
        CurrentProgram = 35725,
        ImplementationColorReadType = 35738,
        ImplementationColorReadFormat = 35739,
        TextureBinding2dArray = 35869,
        MaxGeometryTextureImageUnits = 35881,
        MaxTextureBufferSize = 35883,
        TextureBindingBuffer = 35884,
        TransformFeedbackBufferStart = 35972,
        TransformFeedbackBufferSize = 35973,
        TransformFeedbackBufferBinding = 35983,
        MotionEstimationSearchBlockXQcom = 35984,
        MotionEstimationSearchBlockYQcom = 35985,
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
        MaxSampleMaskWords = 36441,
        MaxTessControlUniformBlocks = 36489,
        MaxTessEvaluationUniformBlocks = 36490,
        FetchPerSampleArm = 36709,
        FragmentShaderFramebufferFetchMrtArm = 36710,
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
        MaxTimelineSemaphoreValueDifferenceNv = 38326,
        ShadingRateQcom = 38564
    }

    public enum EnableCap : uint
    {
        CullFace = 2884,
        DepthTest = 2929,
        StencilTest = 2960,
        Dither = 3024,
        Blend = 3042,
        ScissorTest = 3089,
        Texture2d = 3553,
        PolygonOffsetFill = 32823,
        VertexArray = 32884,
        SampleAlphaToCoverage = 32926,
        SampleCoverage = 32928,
        DebugOutputSynchronous = 33346,
        SampleShading = 35894,
        RasterizerDiscard = 35977,
        PrimitiveRestartFixedIndex = 36201,
        SampleMask = 36433,
        FetchPerSampleArm = 36709,
        DebugOutput = 37600,
        ShadingRateImagePerPrimitiveNv = 38321,
        ShadingRatePreserveAspectRatioQcom = 38565
    }

    public enum GetFramebufferParameter : uint
    {
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
        GenerateMipmapHint = 33170,
        ProgramBinaryRetrievableHint = 33367,
        FragmentShaderDerivativeHint = 35723,
        FragmentShaderDerivativeHintOes = 35723,
        BinningControlHintQcom = 36784
    }

    public enum PixelStoreParameter : uint
    {
        UnpackRowLength = 3314,
        UnpackRowLengthExt = 3314,
        UnpackSkipRows = 3315,
        UnpackSkipRowsExt = 3315,
        UnpackSkipPixels = 3316,
        UnpackSkipPixelsExt = 3316,
        UnpackAlignment = 3317,
        PackRowLength = 3330,
        PackSkipRows = 3331,
        PackSkipPixels = 3332,
        PackAlignment = 3333,
        UnpackSkipImages = 32877,
        UnpackImageHeight = 32878
    }

    public enum CopyImageSubDataTarget : uint
    {
        Texture2d = 3553,
        Texture3d = 32879,
        TextureCubeMap = 34067,
        Texture2dArray = 35866,
        Renderbuffer = 36161,
        TextureCubeMapArray = 36873,
        Texture2dMultisample = 37120,
        Texture2dMultisampleArray = 37122
    }

    public enum TextureTarget : uint
    {
        Texture2d = 3553,
        Texture3d = 32879,
        Texture3dOes = 32879,
        TextureCubeMap = 34067,
        TextureCubeMapPositiveX = 34069,
        TextureCubeMapNegativeX = 34070,
        TextureCubeMapPositiveY = 34071,
        TextureCubeMapNegativeY = 34072,
        TextureCubeMapPositiveZ = 34073,
        TextureCubeMapNegativeZ = 34074,
        Texture2dArray = 35866,
        TextureBuffer = 35882,
        Renderbuffer = 36161,
        TextureCubeMapArray = 36873,
        TextureCubeMapArrayOes = 36873,
        TextureCubeMapArrayExt = 36873,
        Texture2dMultisample = 37120,
        Texture2dMultisampleArray = 37122
    }

    public enum GetPointervPName : uint
    {
        DebugCallbackFunction = 33348,
        DebugCallbackUserParam = 33349
    }

    public enum TextureParameterName : uint
    {
        TextureWidth = 4096,
        TextureHeight = 4097,
        TextureInternalFormat = 4099,
        TextureBorderColor = 4100,
        TextureBorderColorNv = 4100,
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
        TextureRedSize = 32860,
        TextureGreenSize = 32861,
        TextureBlueSize = 32862,
        TextureAlphaSize = 32863,
        TextureWrapR = 32882,
        TextureWrapROes = 32882,
        TextureMinLod = 33082,
        TextureMaxLod = 33083,
        TextureBaseLevel = 33084,
        TextureMaxLevel = 33085,
        TextureCompareMode = 34892,
        TextureCompareFunc = 34893,
        TextureSwizzleR = 36418,
        TextureSwizzleG = 36419,
        TextureSwizzleB = 36420,
        TextureSwizzleA = 36421,
        TextureUnnormalizedCoordinatesArm = 36714,
        DepthStencilTextureMode = 37098,
        TextureTilingExt = 38272,
        TextureFoveatedCutoffDensityQcom = 38560
    }

    public enum GetTextureParameter : uint
    {
        TextureWidth = 4096,
        TextureHeight = 4097,
        TextureInternalFormat = 4099,
        TextureBorderColor = 4100,
        TextureBorderColorNv = 4100,
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
        TextureRedSize = 32860,
        TextureGreenSize = 32861,
        TextureBlueSize = 32862,
        TextureAlphaSize = 32863,
        TextureUnnormalizedCoordinatesArm = 36714
    }

    public enum SamplerParameterF : uint
    {
        TextureBorderColor = 4100,
        TextureMinLod = 33082,
        TextureMaxLod = 33083,
        TextureUnnormalizedCoordinatesArm = 36714
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
        Float = 5126
    }

    public enum TangentPointerTypeEXT : uint
    {
        Byte = 5120,
        Short = 5122,
        Int = 5124,
        Float = 5126
    }

    public enum BinormalPointerTypeEXT : uint
    {
        Byte = 5120,
        Short = 5122,
        Int = 5124,
        Float = 5126
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
        Float = 5126
    }

    public enum NormalPointerType : uint
    {
        Byte = 5120,
        Short = 5122,
        Int = 5124,
        Float = 5126
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
        UnsignedShort4444 = 32819,
        UnsignedShort5551 = 32820
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
        HalfFloat = 5131,
        Fixed = 5132,
        Int64Nv = 5134,
        UnsignedInt64Nv = 5135,
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
        Float = 5126
    }

    public enum IndexPointerType : uint
    {
        Short = 5122,
        Int = 5124,
        Float = 5126
    }

    public enum TexCoordPointerType : uint
    {
        Short = 5122,
        Int = 5124,
        Float = 5126
    }

    public enum VertexPointerType : uint
    {
        Short = 5122,
        Int = 5124,
        Float = 5126
    }

    public enum PixelFormat : uint
    {
        UnsignedShort = 5123,
        UnsignedInt = 5125,
        StencilIndex = 6401,
        DepthComponent = 6402,
        Red = 6403,
        RedExt = 6403,
        Green = 6404,
        Blue = 6405,
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410,
        Rg = 33319,
        RgInteger = 33320,
        DepthStencil = 34041,
        RedInteger = 36244,
        RgbInteger = 36248,
        RgbaInteger = 36249
    }

    public enum AttributeType : uint
    {
        Int = 5124,
        UnsignedInt = 5125,
        Float = 5126,
        Int64Nv = 5134,
        UnsignedInt64Nv = 5135,
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
        Sampler2d = 35678,
        Sampler3d = 35679,
        Sampler3dOes = 35679,
        SamplerCube = 35680,
        Sampler2dShadow = 35682,
        Sampler2dShadowExt = 35682,
        FloatMat2x3 = 35685,
        FloatMat2x3Nv = 35685,
        FloatMat2x4 = 35686,
        FloatMat2x4Nv = 35686,
        FloatMat3x2 = 35687,
        FloatMat3x2Nv = 35687,
        FloatMat3x4 = 35688,
        FloatMat3x4Nv = 35688,
        FloatMat4x2 = 35689,
        FloatMat4x2Nv = 35689,
        FloatMat4x3 = 35690,
        FloatMat4x3Nv = 35690,
        SamplerBuffer = 36290,
        Sampler2dArrayShadow = 36292,
        SamplerCubeShadow = 36293,
        UnsignedIntVec2 = 36294,
        UnsignedIntVec3 = 36295,
        UnsignedIntVec4 = 36296,
        IntSampler2d = 36298,
        IntSampler3d = 36299,
        IntSamplerCube = 36300,
        IntSampler2dArray = 36303,
        IntSamplerBuffer = 36304,
        UnsignedIntSampler2d = 36306,
        UnsignedIntSampler3d = 36307,
        UnsignedIntSamplerCube = 36308,
        UnsignedIntSampler2dArray = 36311,
        UnsignedIntSamplerBuffer = 36312,
        SamplerCubeMapArray = 36876,
        SamplerCubeMapArrayShadow = 36877,
        IntSamplerCubeMapArray = 36878,
        UnsignedIntSamplerCubeMapArray = 36879,
        Image2d = 36941,
        Image3d = 36942,
        ImageCube = 36944,
        ImageBuffer = 36945,
        Image2dArray = 36947,
        ImageCubeMapArray = 36948,
        IntImage2d = 36952,
        IntImage3d = 36953,
        IntImageCube = 36955,
        IntImageBuffer = 36956,
        IntImage2dArray = 36958,
        IntImageCubeMapArray = 36959,
        UnsignedIntImage2d = 36963,
        UnsignedIntImage3d = 36964,
        UnsignedIntImageCube = 36966,
        UnsignedIntImageBuffer = 36967,
        UnsignedIntImage2dArray = 36969,
        UnsignedIntImageCubeMapArray = 36970,
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
        Sampler2d = 35678,
        Sampler3d = 35679,
        SamplerCube = 35680,
        Sampler2dShadow = 35682,
        FloatMat2x3 = 35685,
        FloatMat2x4 = 35686,
        FloatMat3x2 = 35687,
        FloatMat3x4 = 35688,
        FloatMat4x2 = 35689,
        FloatMat4x3 = 35690,
        Sampler2dArray = 36289,
        SamplerBuffer = 36290,
        Sampler2dArrayShadow = 36292,
        SamplerCubeShadow = 36293,
        UnsignedIntVec2 = 36294,
        UnsignedIntVec3 = 36295,
        UnsignedIntVec4 = 36296,
        IntSampler2d = 36298,
        IntSampler3d = 36299,
        IntSamplerCube = 36300,
        IntSampler2dArray = 36303,
        IntSamplerBuffer = 36304,
        UnsignedIntSampler2d = 36306,
        UnsignedIntSampler3d = 36307,
        UnsignedIntSamplerCube = 36308,
        UnsignedIntSampler2dArray = 36311,
        UnsignedIntSamplerBuffer = 36312,
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
        Sampler2d = 35678,
        Sampler3d = 35679,
        SamplerCube = 35680,
        Sampler2dShadow = 35682,
        FloatMat2x3 = 35685,
        FloatMat2x4 = 35686,
        FloatMat3x2 = 35687,
        FloatMat3x4 = 35688,
        FloatMat4x2 = 35689,
        FloatMat4x3 = 35690,
        Sampler2dArray = 36289,
        SamplerBuffer = 36290,
        Sampler2dArrayShadow = 36292,
        SamplerCubeShadow = 36293,
        UnsignedIntVec2 = 36294,
        UnsignedIntVec3 = 36295,
        UnsignedIntVec4 = 36296,
        IntSampler2d = 36298,
        IntSampler3d = 36299,
        IntSamplerCube = 36300,
        IntSampler2dArray = 36303,
        IntSamplerBuffer = 36304,
        UnsignedIntSampler2d = 36306,
        UnsignedIntSampler3d = 36307,
        UnsignedIntSamplerCube = 36308,
        UnsignedIntSampler2dArray = 36311,
        UnsignedIntSamplerBuffer = 36312,
        SamplerCubeMapArray = 36876,
        SamplerCubeMapArrayShadow = 36877,
        IntSamplerCubeMapArray = 36878,
        UnsignedIntSamplerCubeMapArray = 36879,
        Image2d = 36941,
        Image3d = 36942,
        ImageCube = 36944,
        ImageBuffer = 36945,
        Image2dArray = 36947,
        ImageCubeMapArray = 36948,
        IntImage2d = 36952,
        IntImage3d = 36953,
        IntImageCube = 36955,
        IntImageBuffer = 36956,
        IntImage2dArray = 36958,
        IntImageCubeMapArray = 36959,
        UnsignedIntImage2d = 36963,
        UnsignedIntImage3d = 36964,
        UnsignedIntImageCube = 36966,
        UnsignedIntImageBuffer = 36967,
        UnsignedIntImage2dArray = 36969,
        UnsignedIntImageCubeMapArray = 36970,
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
        Float = 5126
    }

    public enum VertexWeightPointerTypeEXT : uint
    {
        Float = 5126
    }

    public enum FogCoordinatePointerType : uint
    {
        Float = 5126
    }

    public enum FogPointerTypeEXT : uint
    {
        Float = 5126
    }

    public enum FogPointerTypeIBM : uint
    {
        Float = 5126
    }

    public enum LogicOp : uint
    {
        Invert = 5386
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
        ColorExt = 6144,
        Depth = 6145,
        DepthExt = 6145,
        Stencil = 6146,
        StencilExt = 6146
    }

    public enum InvalidateFramebufferAttachment : uint
    {
        Color = 6144,
        Depth = 6145,
        Stencil = 6146,
        DepthStencilAttachment = 33306,
        ColorAttachment0 = 36064,
        ColorAttachment0Ext = 36064,
        ColorAttachment0Nv = 36064,
        ColorAttachment1 = 36065,
        ColorAttachment1Ext = 36065,
        ColorAttachment1Nv = 36065,
        ColorAttachment2 = 36066,
        ColorAttachment2Ext = 36066,
        ColorAttachment2Nv = 36066,
        ColorAttachment3 = 36067,
        ColorAttachment3Ext = 36067,
        ColorAttachment3Nv = 36067,
        ColorAttachment4 = 36068,
        ColorAttachment4Ext = 36068,
        ColorAttachment4Nv = 36068,
        ColorAttachment5 = 36069,
        ColorAttachment5Ext = 36069,
        ColorAttachment5Nv = 36069,
        ColorAttachment6 = 36070,
        ColorAttachment6Ext = 36070,
        ColorAttachment6Nv = 36070,
        ColorAttachment7 = 36071,
        ColorAttachment7Ext = 36071,
        ColorAttachment7Nv = 36071,
        ColorAttachment8 = 36072,
        ColorAttachment8Ext = 36072,
        ColorAttachment8Nv = 36072,
        ColorAttachment9 = 36073,
        ColorAttachment9Ext = 36073,
        ColorAttachment9Nv = 36073,
        ColorAttachment10 = 36074,
        ColorAttachment10Ext = 36074,
        ColorAttachment10Nv = 36074,
        ColorAttachment11 = 36075,
        ColorAttachment11Ext = 36075,
        ColorAttachment11Nv = 36075,
        ColorAttachment12 = 36076,
        ColorAttachment12Ext = 36076,
        ColorAttachment12Nv = 36076,
        ColorAttachment13 = 36077,
        ColorAttachment13Ext = 36077,
        ColorAttachment13Nv = 36077,
        ColorAttachment14 = 36078,
        ColorAttachment14Ext = 36078,
        ColorAttachment14Nv = 36078,
        ColorAttachment15 = 36079,
        ColorAttachment15Ext = 36079,
        ColorAttachment15Nv = 36079,
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
        DepthAttachment = 36096
    }

    public enum InternalFormat : uint
    {
        StencilIndex = 6401,
        StencilIndexOes = 6401,
        DepthComponent = 6402,
        Red = 6403,
        RedExt = 6403,
        Rgb = 6407,
        Rgba = 6408,
        Alpha8Ext = 32828,
        Alpha8Oes = 32828,
        Luminance8Ext = 32832,
        Luminance8Oes = 32832,
        Luminance4Alpha4Oes = 32835,
        Luminance8Alpha8Ext = 32837,
        Luminance8Alpha8Oes = 32837,
        Rgb8 = 32849,
        Rgb8Oes = 32849,
        Rgb10Ext = 32850,
        Rgb16Ext = 32852,
        Rgba4 = 32854,
        Rgba4Oes = 32854,
        Rgb5A1 = 32855,
        Rgb5A1Oes = 32855,
        Rgba8 = 32856,
        Rgba8Oes = 32856,
        Rgb10A2 = 32857,
        Rgb10A2Ext = 32857,
        Rgba16Ext = 32859,
        DepthComponent16 = 33189,
        DepthComponent16Oes = 33189,
        DepthComponent24 = 33190,
        DepthComponent24Oes = 33190,
        DepthComponent32Oes = 33191,
        Rg = 33319,
        R8 = 33321,
        R8Ext = 33321,
        R16Ext = 33322,
        Rg8 = 33323,
        Rg8Ext = 33323,
        Rg16Ext = 33324,
        R16f = 33325,
        R16fExt = 33325,
        R32f = 33326,
        R32fExt = 33326,
        Rg16f = 33327,
        Rg16fExt = 33327,
        Rg32f = 33328,
        Rg32fExt = 33328,
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
        CompressedRgbaS3tcDxt3Angle = 33778,
        CompressedRgbaS3tcDxt3Ext = 33778,
        CompressedRgbaS3tcDxt5Angle = 33779,
        CompressedRgbaS3tcDxt5Ext = 33779,
        DepthStencil = 34041,
        DepthStencilOes = 34041,
        Rgba32f = 34836,
        Rgba32fExt = 34836,
        Rgb32f = 34837,
        Rgb32fExt = 34837,
        Rgba16f = 34842,
        Rgba16fExt = 34842,
        Rgb16f = 34843,
        Rgb16fExt = 34843,
        Depth24Stencil8 = 35056,
        Depth24Stencil8Oes = 35056,
        R11fG11fB10f = 35898,
        R11fG11fB10fApple = 35898,
        Rgb9E5 = 35901,
        Rgb9E5Apple = 35901,
        Srgb = 35904,
        SrgbExt = 35904,
        Srgb8 = 35905,
        Srgb8Nv = 35905,
        SrgbAlphaExt = 35906,
        Srgb8Alpha8 = 35907,
        Srgb8Alpha8Ext = 35907,
        CompressedSrgbS3tcDxt1Ext = 35916,
        CompressedSrgbS3tcDxt1Nv = 35916,
        CompressedSrgbAlphaS3tcDxt1Ext = 35917,
        CompressedSrgbAlphaS3tcDxt1Nv = 35917,
        CompressedSrgbAlphaS3tcDxt3Ext = 35918,
        CompressedSrgbAlphaS3tcDxt3Nv = 35918,
        CompressedSrgbAlphaS3tcDxt5Ext = 35919,
        CompressedSrgbAlphaS3tcDxt5Nv = 35919,
        DepthComponent32f = 36012,
        Depth32fStencil8 = 36013,
        StencilIndex1Oes = 36166,
        StencilIndex4Oes = 36167,
        StencilIndex8 = 36168,
        StencilIndex8Oes = 36168,
        Rgb565 = 36194,
        Rgb565Oes = 36194,
        Etc1Rgb8Oes = 36196,
        Rgba32ui = 36208,
        Rgb32ui = 36209,
        Rgba16ui = 36214,
        Rgb16ui = 36215,
        Rgba8ui = 36220,
        Rgb8ui = 36221,
        Rgba32i = 36226,
        Rgb32i = 36227,
        Rgba16i = 36232,
        Rgb16i = 36233,
        Rgba8i = 36238,
        Rgb8i = 36239,
        CompressedRedRgtc1Ext = 36283,
        CompressedSignedRedRgtc1Ext = 36284,
        CompressedRedGreenRgtc2Ext = 36285,
        CompressedSignedRedGreenRgtc2Ext = 36286,
        CompressedRgbaBptcUnormExt = 36492,
        CompressedSrgbAlphaBptcUnormExt = 36493,
        CompressedRgbBptcSignedFloatExt = 36494,
        CompressedRgbBptcUnsignedFloatExt = 36495,
        R8Snorm = 36756,
        Rg8Snorm = 36757,
        Rgb8Snorm = 36758,
        Rgba8Snorm = 36759,
        R16SnormExt = 36760,
        Rg16SnormExt = 36761,
        Rgb16SnormExt = 36762,
        Rgba16SnormExt = 36763,
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
        CompressedRgbaAstc4x4 = 37808,
        CompressedRgbaAstc4x4Khr = 37808,
        CompressedRgbaAstc5x4 = 37809,
        CompressedRgbaAstc5x4Khr = 37809,
        CompressedRgbaAstc5x5 = 37810,
        CompressedRgbaAstc5x5Khr = 37810,
        CompressedRgbaAstc6x5 = 37811,
        CompressedRgbaAstc6x5Khr = 37811,
        CompressedRgbaAstc6x6 = 37812,
        CompressedRgbaAstc6x6Khr = 37812,
        CompressedRgbaAstc8x5 = 37813,
        CompressedRgbaAstc8x5Khr = 37813,
        CompressedRgbaAstc8x6 = 37814,
        CompressedRgbaAstc8x6Khr = 37814,
        CompressedRgbaAstc8x8 = 37815,
        CompressedRgbaAstc8x8Khr = 37815,
        CompressedRgbaAstc10x5 = 37816,
        CompressedRgbaAstc10x5Khr = 37816,
        CompressedRgbaAstc10x6 = 37817,
        CompressedRgbaAstc10x6Khr = 37817,
        CompressedRgbaAstc10x8 = 37818,
        CompressedRgbaAstc10x8Khr = 37818,
        CompressedRgbaAstc10x10 = 37819,
        CompressedRgbaAstc10x10Khr = 37819,
        CompressedRgbaAstc12x10 = 37820,
        CompressedRgbaAstc12x10Khr = 37820,
        CompressedRgbaAstc12x12 = 37821,
        CompressedRgbaAstc12x12Khr = 37821,
        CompressedRgbaAstc3x3x3Oes = 37824,
        CompressedRgbaAstc4x3x3Oes = 37825,
        CompressedRgbaAstc4x4x3Oes = 37826,
        CompressedRgbaAstc4x4x4Oes = 37827,
        CompressedRgbaAstc5x4x4Oes = 37828,
        CompressedRgbaAstc5x5x4Oes = 37829,
        CompressedRgbaAstc5x5x5Oes = 37830,
        CompressedRgbaAstc6x5x5Oes = 37831,
        CompressedRgbaAstc6x6x5Oes = 37832,
        CompressedRgbaAstc6x6x6Oes = 37833,
        CompressedSrgb8Alpha8Astc4x4 = 37840,
        CompressedSrgb8Alpha8Astc4x4Khr = 37840,
        CompressedSrgb8Alpha8Astc5x4 = 37841,
        CompressedSrgb8Alpha8Astc5x4Khr = 37841,
        CompressedSrgb8Alpha8Astc5x5 = 37842,
        CompressedSrgb8Alpha8Astc5x5Khr = 37842,
        CompressedSrgb8Alpha8Astc6x5 = 37843,
        CompressedSrgb8Alpha8Astc6x5Khr = 37843,
        CompressedSrgb8Alpha8Astc6x6 = 37844,
        CompressedSrgb8Alpha8Astc6x6Khr = 37844,
        CompressedSrgb8Alpha8Astc8x5 = 37845,
        CompressedSrgb8Alpha8Astc8x5Khr = 37845,
        CompressedSrgb8Alpha8Astc8x6 = 37846,
        CompressedSrgb8Alpha8Astc8x6Khr = 37846,
        CompressedSrgb8Alpha8Astc8x8 = 37847,
        CompressedSrgb8Alpha8Astc8x8Khr = 37847,
        CompressedSrgb8Alpha8Astc10x5 = 37848,
        CompressedSrgb8Alpha8Astc10x5Khr = 37848,
        CompressedSrgb8Alpha8Astc10x6 = 37849,
        CompressedSrgb8Alpha8Astc10x6Khr = 37849,
        CompressedSrgb8Alpha8Astc10x8 = 37850,
        CompressedSrgb8Alpha8Astc10x8Khr = 37850,
        CompressedSrgb8Alpha8Astc10x10 = 37851,
        CompressedSrgb8Alpha8Astc10x10Khr = 37851,
        CompressedSrgb8Alpha8Astc12x10 = 37852,
        CompressedSrgb8Alpha8Astc12x10Khr = 37852,
        CompressedSrgb8Alpha8Astc12x12 = 37853,
        CompressedSrgb8Alpha8Astc12x12Khr = 37853,
        CompressedSrgb8Alpha8Astc3x3x3Oes = 37856,
        CompressedSrgb8Alpha8Astc4x3x3Oes = 37857,
        CompressedSrgb8Alpha8Astc4x4x3Oes = 37858,
        CompressedSrgb8Alpha8Astc4x4x4Oes = 37859,
        CompressedSrgb8Alpha8Astc5x4x4Oes = 37860,
        CompressedSrgb8Alpha8Astc5x5x4Oes = 37861,
        CompressedSrgb8Alpha8Astc5x5x5Oes = 37862,
        CompressedSrgb8Alpha8Astc6x5x5Oes = 37863,
        CompressedSrgb8Alpha8Astc6x6x5Oes = 37864,
        CompressedSrgb8Alpha8Astc6x6x6Oes = 37865
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
    }

    public enum EvalMapsModeNV : uint
    {
        FillNv = 6914
    }

    public enum StringName : uint
    {
        Vendor = 7936,
        Renderer = 7937,
        Version = 7938,
        Extensions = 7939,
        ShadingLanguageVersion = 35724
    }

    public enum BlitFramebufferFilter : uint
    {
        Nearest = 9728,
        Linear = 9729
    }

    public enum TextureMagFilter : uint
    {
        Nearest = 9728,
        Linear = 9729
    }

    public enum TextureMinFilter : uint
    {
        Nearest = 9728,
        Linear = 9729,
        NearestMipmapNearest = 9984,
        LinearMipmapNearest = 9985,
        NearestMipmapLinear = 9986,
        LinearMipmapLinear = 9987
    }

    public enum TextureWrapMode : uint
    {
        LinearMipmapLinear = 9987,
        Repeat = 10497,
        ClampToBorder = 33069,
        ClampToBorderNv = 33069,
        ClampToEdge = 33071,
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
        TextureCompareFunc = 34893,
        TextureUnnormalizedCoordinatesArm = 36714
    }

    public enum SizedInternalFormat : uint
    {
        Alpha8Ext = 32828,
        Alpha8Oes = 32828,
        Luminance8Ext = 32832,
        Luminance8Oes = 32832,
        Luminance4Alpha4Oes = 32835,
        Luminance8Alpha8Ext = 32837,
        Luminance8Alpha8Oes = 32837,
        Rgb8 = 32849,
        Rgb8Oes = 32849,
        Rgb10Ext = 32850,
        Rgb16Ext = 32852,
        Rgba4 = 32854,
        Rgba4Oes = 32854,
        Rgb5A1 = 32855,
        Rgb5A1Oes = 32855,
        Rgba8 = 32856,
        Rgba8Oes = 32856,
        Rgb10A2 = 32857,
        Rgb10A2Ext = 32857,
        Rgba16Ext = 32859,
        DepthComponent16 = 33189,
        DepthComponent16Oes = 33189,
        DepthComponent24 = 33190,
        DepthComponent24Oes = 33190,
        DepthComponent32Oes = 33191,
        R8 = 33321,
        R8Ext = 33321,
        R16Ext = 33322,
        Rg8 = 33323,
        Rg8Ext = 33323,
        Rg16Ext = 33324,
        R16f = 33325,
        R16fExt = 33325,
        R32f = 33326,
        R32fExt = 33326,
        Rg16f = 33327,
        Rg16fExt = 33327,
        Rg32f = 33328,
        Rg32fExt = 33328,
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
        CompressedRgbaS3tcDxt3Angle = 33778,
        CompressedRgbaS3tcDxt3Ext = 33778,
        CompressedRgbaS3tcDxt5Angle = 33779,
        CompressedRgbaS3tcDxt5Ext = 33779,
        Rgba32f = 34836,
        Rgba32fExt = 34836,
        Rgb32f = 34837,
        Rgb32fExt = 34837,
        Rgba16f = 34842,
        Rgba16fExt = 34842,
        Rgb16f = 34843,
        Rgb16fExt = 34843,
        Depth24Stencil8 = 35056,
        Depth24Stencil8Oes = 35056,
        R11fG11fB10f = 35898,
        R11fG11fB10fApple = 35898,
        Rgb9E5 = 35901,
        Rgb9E5Apple = 35901,
        Srgb8 = 35905,
        Srgb8Nv = 35905,
        Srgb8Alpha8 = 35907,
        Srgb8Alpha8Ext = 35907,
        CompressedSrgbS3tcDxt1Ext = 35916,
        CompressedSrgbS3tcDxt1Nv = 35916,
        CompressedSrgbAlphaS3tcDxt1Ext = 35917,
        CompressedSrgbAlphaS3tcDxt1Nv = 35917,
        CompressedSrgbAlphaS3tcDxt3Ext = 35918,
        CompressedSrgbAlphaS3tcDxt3Nv = 35918,
        CompressedSrgbAlphaS3tcDxt5Ext = 35919,
        CompressedSrgbAlphaS3tcDxt5Nv = 35919,
        DepthComponent32f = 36012,
        Depth32fStencil8 = 36013,
        StencilIndex1Oes = 36166,
        StencilIndex4Oes = 36167,
        StencilIndex8 = 36168,
        StencilIndex8Oes = 36168,
        Rgb565 = 36194,
        Rgb565Oes = 36194,
        Etc1Rgb8Oes = 36196,
        Rgba32ui = 36208,
        Rgb32ui = 36209,
        Rgba16ui = 36214,
        Rgb16ui = 36215,
        Rgba8ui = 36220,
        Rgb8ui = 36221,
        Rgba32i = 36226,
        Rgb32i = 36227,
        Rgba16i = 36232,
        Rgb16i = 36233,
        Rgba8i = 36238,
        Rgb8i = 36239,
        CompressedRedRgtc1Ext = 36283,
        CompressedSignedRedRgtc1Ext = 36284,
        CompressedRedGreenRgtc2Ext = 36285,
        CompressedSignedRedGreenRgtc2Ext = 36286,
        CompressedRgbaBptcUnormExt = 36492,
        CompressedSrgbAlphaBptcUnormExt = 36493,
        CompressedRgbBptcSignedFloatExt = 36494,
        CompressedRgbBptcUnsignedFloatExt = 36495,
        R8Snorm = 36756,
        Rg8Snorm = 36757,
        Rgb8Snorm = 36758,
        Rgba8Snorm = 36759,
        R16SnormExt = 36760,
        Rg16SnormExt = 36761,
        Rgb16SnormExt = 36762,
        Rgba16SnormExt = 36763,
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
        CompressedRgbaAstc4x4 = 37808,
        CompressedRgbaAstc4x4Khr = 37808,
        CompressedRgbaAstc5x4 = 37809,
        CompressedRgbaAstc5x4Khr = 37809,
        CompressedRgbaAstc5x5 = 37810,
        CompressedRgbaAstc5x5Khr = 37810,
        CompressedRgbaAstc6x5 = 37811,
        CompressedRgbaAstc6x5Khr = 37811,
        CompressedRgbaAstc6x6 = 37812,
        CompressedRgbaAstc6x6Khr = 37812,
        CompressedRgbaAstc8x5 = 37813,
        CompressedRgbaAstc8x5Khr = 37813,
        CompressedRgbaAstc8x6 = 37814,
        CompressedRgbaAstc8x6Khr = 37814,
        CompressedRgbaAstc8x8 = 37815,
        CompressedRgbaAstc8x8Khr = 37815,
        CompressedRgbaAstc10x5 = 37816,
        CompressedRgbaAstc10x5Khr = 37816,
        CompressedRgbaAstc10x6 = 37817,
        CompressedRgbaAstc10x6Khr = 37817,
        CompressedRgbaAstc10x8 = 37818,
        CompressedRgbaAstc10x8Khr = 37818,
        CompressedRgbaAstc10x10 = 37819,
        CompressedRgbaAstc10x10Khr = 37819,
        CompressedRgbaAstc12x10 = 37820,
        CompressedRgbaAstc12x10Khr = 37820,
        CompressedRgbaAstc12x12 = 37821,
        CompressedRgbaAstc12x12Khr = 37821,
        CompressedRgbaAstc3x3x3Oes = 37824,
        CompressedRgbaAstc4x3x3Oes = 37825,
        CompressedRgbaAstc4x4x3Oes = 37826,
        CompressedRgbaAstc4x4x4Oes = 37827,
        CompressedRgbaAstc5x4x4Oes = 37828,
        CompressedRgbaAstc5x5x4Oes = 37829,
        CompressedRgbaAstc5x5x5Oes = 37830,
        CompressedRgbaAstc6x5x5Oes = 37831,
        CompressedRgbaAstc6x6x5Oes = 37832,
        CompressedRgbaAstc6x6x6Oes = 37833,
        CompressedSrgb8Alpha8Astc4x4 = 37840,
        CompressedSrgb8Alpha8Astc4x4Khr = 37840,
        CompressedSrgb8Alpha8Astc5x4 = 37841,
        CompressedSrgb8Alpha8Astc5x4Khr = 37841,
        CompressedSrgb8Alpha8Astc5x5 = 37842,
        CompressedSrgb8Alpha8Astc5x5Khr = 37842,
        CompressedSrgb8Alpha8Astc6x5 = 37843,
        CompressedSrgb8Alpha8Astc6x5Khr = 37843,
        CompressedSrgb8Alpha8Astc6x6 = 37844,
        CompressedSrgb8Alpha8Astc6x6Khr = 37844,
        CompressedSrgb8Alpha8Astc8x5 = 37845,
        CompressedSrgb8Alpha8Astc8x5Khr = 37845,
        CompressedSrgb8Alpha8Astc8x6 = 37846,
        CompressedSrgb8Alpha8Astc8x6Khr = 37846,
        CompressedSrgb8Alpha8Astc8x8 = 37847,
        CompressedSrgb8Alpha8Astc8x8Khr = 37847,
        CompressedSrgb8Alpha8Astc10x5 = 37848,
        CompressedSrgb8Alpha8Astc10x5Khr = 37848,
        CompressedSrgb8Alpha8Astc10x6 = 37849,
        CompressedSrgb8Alpha8Astc10x6Khr = 37849,
        CompressedSrgb8Alpha8Astc10x8 = 37850,
        CompressedSrgb8Alpha8Astc10x8Khr = 37850,
        CompressedSrgb8Alpha8Astc10x10 = 37851,
        CompressedSrgb8Alpha8Astc10x10Khr = 37851,
        CompressedSrgb8Alpha8Astc12x10 = 37852,
        CompressedSrgb8Alpha8Astc12x10Khr = 37852,
        CompressedSrgb8Alpha8Astc12x12 = 37853,
        CompressedSrgb8Alpha8Astc12x12Khr = 37853,
        CompressedSrgb8Alpha8Astc3x3x3Oes = 37856,
        CompressedSrgb8Alpha8Astc4x3x3Oes = 37857,
        CompressedSrgb8Alpha8Astc4x4x3Oes = 37858,
        CompressedSrgb8Alpha8Astc4x4x4Oes = 37859,
        CompressedSrgb8Alpha8Astc5x4x4Oes = 37860,
        CompressedSrgb8Alpha8Astc5x5x4Oes = 37861,
        CompressedSrgb8Alpha8Astc5x5x5Oes = 37862,
        CompressedSrgb8Alpha8Astc6x5x5Oes = 37863,
        CompressedSrgb8Alpha8Astc6x6x5Oes = 37864,
        CompressedSrgb8Alpha8Astc6x6x6Oes = 37865
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
        FuncReverseSubtract = 32779
    }

    public enum InternalFormatPName : uint
    {
        Samples = 32937,
        TextureCompressed = 34465,
        ImageFormatCompatibilityType = 37063,
        NumSampleCounts = 37760
    }

    public enum BufferTargetARB : uint
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
        AtomicCounterBuffer = 37568
    }

    public enum FramebufferAttachmentParameterName : uint
    {
        FramebufferAttachmentColorEncoding = 33296,
        FramebufferAttachmentColorEncodingExt = 33296,
        FramebufferAttachmentComponentType = 33297,
        FramebufferAttachmentComponentTypeExt = 33297,
        FramebufferAttachmentRedSize = 33298,
        FramebufferAttachmentGreenSize = 33299,
        FramebufferAttachmentBlueSize = 33300,
        FramebufferAttachmentAlphaSize = 33301,
        FramebufferAttachmentDepthSize = 33302,
        FramebufferAttachmentStencilSize = 33303,
        FramebufferAttachmentObjectType = 36048,
        FramebufferAttachmentObjectName = 36049,
        FramebufferAttachmentTextureLevel = 36050,
        FramebufferAttachmentTextureCubeMapFace = 36051,
        FramebufferAttachmentTextureLayer = 36052,
        FramebufferAttachmentTexture3dZoffsetOes = 36052,
        FramebufferAttachmentTextureSamplesExt = 36204,
        FramebufferAttachmentLayered = 36263,
        FramebufferAttachmentLayeredExt = 36263,
        FramebufferAttachmentLayeredOes = 36263,
        FramebufferAttachmentTextureScaleImg = 37183,
        FramebufferAttachmentTextureNumViewsOvr = 38448,
        FramebufferAttachmentTextureBaseViewIndexOvr = 38450
    }

    public enum FramebufferStatus : uint
    {
        FramebufferUndefined = 33305,
        FramebufferComplete = 36053,
        FramebufferIncompleteAttachment = 36054,
        FramebufferIncompleteMissingAttachment = 36055,
        FramebufferUnsupported = 36061,
        FramebufferIncompleteMultisample = 36182,
        FramebufferIncompleteLayerTargets = 36264
    }

    public enum VertexBufferObjectParameter : uint
    {
        BufferSize = 34660,
        BufferUsage = 34661,
        BufferMapped = 35004,
        BufferAccessFlags = 37151,
        BufferMapLength = 37152,
        BufferMapOffset = 37153
    }

    public enum BufferPNameARB : uint
    {
        BufferSize = 34660,
        BufferUsage = 34661,
        BufferMapped = 35004,
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
        VertexAttribArrayNormalized = 34922,
        VertexAttribArrayBufferBinding = 34975,
        VertexAttribArrayInteger = 35069,
        VertexAttribArrayDivisor = 35070
    }

    public enum VertexArrayPName : uint
    {
        VertexAttribRelativeOffset = 33493,
        VertexAttribArrayEnabled = 34338,
        VertexAttribArraySize = 34339,
        VertexAttribArrayStride = 34340,
        VertexAttribArrayType = 34341,
        VertexAttribArrayNormalized = 34922,
        VertexAttribArrayInteger = 35069,
        VertexAttribArrayDivisor = 35070
    }

    public enum QueryObjectParameterName : uint
    {
        QueryResult = 34918,
        QueryResultAvailable = 34919
    }

    public enum QueryTarget : uint
    {
        AnySamplesPassed = 35887,
        PrimitivesGenerated = 35975,
        TransformFeedbackPrimitivesWritten = 35976,
        AnySamplesPassedConservative = 36202
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
        PrimaryColorNv = 34092,
        SecondaryColorNv = 34093
    }

    public enum UniformBlockPName : uint
    {
        UniformBlockBinding = 35391,
        UniformBlockDataSize = 35392,
        UniformBlockNameLength = 35393,
        UniformBlockActiveUniforms = 35394,
        UniformBlockActiveUniformIndices = 35395,
        UniformBlockReferencedByVertexShader = 35396,
        UniformBlockReferencedByFragmentShader = 35398
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

    public enum PathColor : uint
    {
        PrimaryColorNv = 34092,
        SecondaryColorNv = 34093,
        PrimaryColor = 34167
    }

    public enum RegisterCombinerPname : uint
    {
        ConstantNv = 34166,
        PrimaryColor = 34167,
        Src1AlphaExt = 34185
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

    public enum VertexAttribPointerPropertyARB : uint
    {
        VertexAttribArrayPointer = 34373
    }

    public enum QueryParameterName : uint
    {
        CurrentQuery = 34917
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
        BufferMapPointer = 35005
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

    public enum UniformPName : uint
    {
        UniformType = 35383,
        UniformSize = 35384,
        UniformNameLength = 35385,
        UniformBlockIndex = 35386,
        UniformOffset = 35387,
        UniformArrayStride = 35388,
        UniformMatrixStride = 35389,
        UniformIsRowMajor = 35390
    }

    public enum SubroutineParameterName : uint
    {
        UniformSize = 35384,
        UniformNameLength = 35385
    }

    public enum ShaderType : uint
    {
        FragmentShader = 35632,
        VertexShader = 35633,
        GeometryShader = 36313,
        TessEvaluationShader = 36487,
        TessControlShader = 36488,
        ComputeShader = 37305
    }

    public enum ContainerType : uint
    {
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
        SgxBinaryImg = 35850,
        MaliShaderBinaryArm = 36704,
        ShaderBinaryViv = 36804,
        ShaderBinaryDmp = 37456,
        GccsoShaderBinaryFj = 37472
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
        TransformFeedbackVarying = 37620
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
        RenderbufferSamplesAngle = 36011,
        RenderbufferSamplesApple = 36011,
        RenderbufferSamplesExt = 36011,
        RenderbufferSamplesNv = 36011,
        RenderbufferWidth = 36162,
        RenderbufferHeight = 36163,
        RenderbufferInternalFormat = 36164,
        RenderbufferRedSize = 36176,
        RenderbufferGreenSize = 36177,
        RenderbufferBlueSize = 36178,
        RenderbufferAlphaSize = 36179,
        RenderbufferDepthSize = 36180,
        RenderbufferStencilSize = 36181,
        RenderbufferSamplesImg = 37171,
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

    public enum DrawBufferModeATI : uint
    {
        ColorAttachment0Nv = 36064,
        ColorAttachment1Nv = 36065,
        ColorAttachment2Nv = 36066,
        ColorAttachment3Nv = 36067,
        ColorAttachment4Nv = 36068,
        ColorAttachment5Nv = 36069,
        ColorAttachment6Nv = 36070,
        ColorAttachment7Nv = 36071,
        ColorAttachment8Nv = 36072,
        ColorAttachment9Nv = 36073,
        ColorAttachment10Nv = 36074,
        ColorAttachment11Nv = 36075,
        ColorAttachment12Nv = 36076,
        ColorAttachment13Nv = 36077,
        ColorAttachment14Nv = 36078,
        ColorAttachment15Nv = 36079
    }

    public enum RenderbufferTarget : uint
    {
        Renderbuffer = 36161
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
    }

    public enum BindTransformFeedbackTarget : uint
    {
        TransformFeedback = 36386
    }

    public enum QueryCounterTarget : uint
    {
    }

    public enum ProgramResourceProperty : uint
    {
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
        Location = 37646
    }

    public enum VertexProvokingMode : uint
    {
        FirstVertexConvention = 36429,
        LastVertexConvention = 36430
    }

    public enum GetMultisamplePNameNV : uint
    {
        SamplePosition = 36432
    }

    public enum PatchParameterName : uint
    {
        PatchVertices = 36466
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
        AtomicCounterBufferBinding = 37569
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
        MaxNumActiveVariables = 37623
    }

    public enum FramebufferParameterName : uint
    {
        FramebufferDefaultWidth = 37648,
        FramebufferDefaultHeight = 37649,
        FramebufferDefaultLayers = 37650,
        FramebufferDefaultSamples = 37651,
        FramebufferDefaultFixedSampleLocations = 37652
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

    public enum FramebufferFetchNoncoherent : uint
    {
        FramebufferFetchNoncoherentQcom = 38562
    }

    public enum ShadingRateQCOM : uint
    {
        ShadingRate1x1PixelsQcom = 38566,
        ShadingRate1x2PixelsQcom = 38567,
        ShadingRate2x1PixelsQcom = 38568,
        ShadingRate2x2PixelsQcom = 38569,
        ShadingRate4x2PixelsQcom = 38572,
        ShadingRate4x4PixelsQcom = 38574
    }

#pragma warning restore CA1069 // Enums should not have duplicate values
}
