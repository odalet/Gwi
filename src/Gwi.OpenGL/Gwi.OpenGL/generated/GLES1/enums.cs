// This file is auto generated, do not edit.
using System;

namespace Gwi.OpenGL.GLES1
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
        ColorBufferBit = 16384
    }

    [Flags]
    public enum BufferStorageMask : uint
    {
        MapReadBitExt = 1,
        MapWriteBitExt = 2
    }

    [Flags]
    public enum ContextFlagMask : uint
    {
        ContextFlagDebugBit = 2,
        ContextFlagDebugBitKhr = 2
    }

    [Flags]
    public enum MapBufferAccessMask : uint
    {
        MapReadBitExt = 1,
        MapWriteBitExt = 2,
        MapInvalidateRangeBitExt = 4,
        MapInvalidateBufferBitExt = 8,
        MapFlushExplicitBitExt = 16,
        MapUnsynchronizedBitExt = 32
    }

    [Flags]
    public enum SyncObjectMask : uint
    {
        SyncFlushCommandsBitApple = 1
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
        NoError = 0
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
        InvalidFramebufferOperationOes = 1286
    }

    public enum TextureSwizzle : uint
    {
        Zero = 0,
        One = 1,
        Alpha = 6406
    }

    public enum StencilOp : uint
    {
        Zero = 0,
        Invert = 5386,
        Keep = 7680,
        Replace = 7681,
        Incr = 7682,
        Decr = 7683
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
        Src1Alpha = 34185
    }

    public enum SyncBehaviorFlags : uint
    {
    }

    public enum PathColorFormat : uint
    {
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410
    }

    public enum DrawBufferMode : uint
    {
        NoneOes = 0,
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032
    }

    public enum PixelTexGenMode : uint
    {
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410
    }

    public enum ReadBufferMode : uint
    {
        NoneOes = 0,
        Front = 1028,
        Back = 1029
    }

    public enum ColorBuffer : uint
    {
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032
    }

    public enum PathGenMode : uint
    {
        Constant = 34166
    }

    public enum PrimitiveType : uint
    {
        Points = 0,
        Lines = 1,
        LineLoop = 2,
        LineStrip = 3,
        Triangles = 4,
        TriangleStrip = 5,
        TriangleFan = 6
    }

    public enum AccumOp : uint
    {
        Add = 260
    }

    public enum TextureEnvMode : uint
    {
        Add = 260,
        Blend = 3042,
        Modulate = 8448,
        Decal = 8449
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

    public enum FogMode : uint
    {
        Exp = 2048,
        Exp2 = 2049,
        Linear = 9729
    }

    public enum FrontFaceDirection : uint
    {
        Cw = 2304,
        Ccw = 2305
    }

    public enum GetMapQuery : uint
    {
    }

    public enum GetPName : uint
    {
        CurrentColor = 2816,
        CurrentNormal = 2818,
        CurrentTextureCoords = 2819,
        PointSmooth = 2832,
        PointSize = 2833,
        SmoothPointSizeRange = 2834,
        LineSmooth = 2848,
        LineWidth = 2849,
        SmoothLineWidthRange = 2850,
        CullFace = 2884,
        CullFaceMode = 2885,
        FrontFace = 2886,
        Lighting = 2896,
        LightModelTwoSide = 2898,
        LightModelAmbient = 2899,
        ShadeModel = 2900,
        ColorMaterial = 2903,
        Fog = 2912,
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
        ProjectionStackDepth = 2980,
        TextureStackDepth = 2981,
        ModelviewMatrix = 2982,
        ProjectionMatrix = 2983,
        TextureMatrix = 2984,
        AlphaTest = 3008,
        AlphaTestFunc = 3009,
        AlphaTestRef = 3010,
        Dither = 3024,
        BlendDst = 3040,
        BlendSrc = 3041,
        Blend = 3042,
        LogicOpMode = 3056,
        ColorLogicOp = 3058,
        ScissorBox = 3088,
        ScissorTest = 3089,
        ColorClearValue = 3106,
        ColorWritemask = 3107,
        PerspectiveCorrectionHint = 3152,
        PointSmoothHint = 3153,
        LineSmoothHint = 3154,
        FogHint = 3156,
        UnpackAlignment = 3317,
        PackAlignment = 3333,
        AlphaScale = 3356,
        MaxLights = 3377,
        MaxClipPlanes = 3378,
        MaxTextureSize = 3379,
        MaxModelviewStackDepth = 3382,
        MaxProjectionStackDepth = 3384,
        MaxTextureStackDepth = 3385,
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
        BlendEquationExt = 32777,
        PolygonOffsetFill = 32823,
        PolygonOffsetFactor = 32824,
        TextureBinding2d = 32873,
        VertexArray = 32884,
        NormalArray = 32885,
        ColorArray = 32886,
        TextureCoordArray = 32888,
        VertexArraySize = 32890,
        VertexArrayType = 32891,
        VertexArrayStride = 32892,
        NormalArrayType = 32894,
        NormalArrayStride = 32895,
        ColorArraySize = 32897,
        ColorArrayType = 32898,
        ColorArrayStride = 32899,
        TextureCoordArraySize = 32904,
        TextureCoordArrayType = 32905,
        TextureCoordArrayStride = 32906,
        SampleBuffers = 32936,
        Samples = 32937,
        SampleCoverageValue = 32938,
        SampleCoverageInvert = 32939,
        PointFadeThresholdSize = 33064,
        MaxDebugGroupStackDepth = 33388,
        DebugGroupStackDepth = 33389,
        MaxLabelLength = 33512,
        AliasedPointSizeRange = 33901,
        AliasedLineWidthRange = 33902,
        ActiveTexture = 34016,
        NumCompressedTextureFormats = 34466,
        CompressedTextureFormats = 34467,
        ArrayBufferBinding = 34964,
        ElementArrayBufferBinding = 34965
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
        ColorLogicOp = 3058,
        ScissorTest = 3089,
        Texture2d = 3553,
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
        PolygonOffsetFill = 32823,
        VertexArray = 32884,
        NormalArray = 32885,
        ColorArray = 32886,
        TextureCoordArray = 32888,
        Multisample = 32925,
        SampleAlphaToCoverage = 32926,
        SampleAlphaToOne = 32927,
        SampleCoverage = 32928,
        DebugOutputSynchronous = 33346,
        DebugOutput = 37600
    }

    public enum LightModelParameter : uint
    {
        LightModelTwoSide = 2898,
        LightModelAmbient = 2899
    }

    public enum FogPName : uint
    {
        FogDensity = 2914,
        FogStart = 2915,
        FogEnd = 2916,
        FogMode = 2917
    }

    public enum FogParameter : uint
    {
        FogDensity = 2914,
        FogStart = 2915,
        FogEnd = 2916,
        FogMode = 2917,
        FogColor = 2918
    }

    public enum GetFramebufferParameter : uint
    {
        SampleBuffers = 32936,
        Samples = 32937
    }

    public enum HintTarget : uint
    {
        PerspectiveCorrectionHint = 3152,
        PointSmoothHint = 3153,
        LineSmoothHint = 3154,
        FogHint = 3156,
        GenerateMipmapHint = 33170
    }

    public enum PixelMap : uint
    {
    }

    public enum PixelStoreParameter : uint
    {
        UnpackAlignment = 3317,
        PackAlignment = 3333
    }

    public enum PixelTransferParameter : uint
    {
        AlphaScale = 3356
    }

    public enum MapTarget : uint
    {
    }

    public enum CopyImageSubDataTarget : uint
    {
        Texture2d = 3553
    }

    public enum TextureTarget : uint
    {
        Texture2d = 3553
    }

    public enum GetPointervPName : uint
    {
        VertexArrayPointer = 32910,
        NormalArrayPointer = 32911,
        ColorArrayPointer = 32912,
        TextureCoordArrayPointer = 32914,
        DebugCallbackFunction = 33348,
        DebugCallbackUserParam = 33349
    }

    public enum TextureParameterName : uint
    {
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
        GenerateMipmap = 33169
    }

    public enum GetTextureParameter : uint
    {
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243
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
        AmbientAndDiffuse = 5634
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

    public enum VertexAttribIType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        UnsignedInt = 5125
    }

    public enum WeightPointerTypeARB : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        UnsignedInt = 5125,
        Float = 5126
    }

    public enum TangentPointerTypeEXT : uint
    {
        Byte = 5120,
        Short = 5122,
        Float = 5126
    }

    public enum BinormalPointerTypeEXT : uint
    {
        Byte = 5120,
        Short = 5122,
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
        UnsignedInt = 5125,
        Float = 5126
    }

    public enum NormalPointerType : uint
    {
        Byte = 5120,
        Short = 5122,
        Float = 5126
    }

    public enum PixelType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
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
        UnsignedInt = 5125,
        Float = 5126,
        Fixed = 5132
    }

    public enum VertexAttribPointerType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        UnsignedInt = 5125,
        Float = 5126,
        Fixed = 5132
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
        Float = 5126
    }

    public enum IndexPointerType : uint
    {
        Short = 5122,
        Float = 5126
    }

    public enum TexCoordPointerType : uint
    {
        Short = 5122,
        Float = 5126
    }

    public enum VertexPointerType : uint
    {
        Short = 5122,
        Float = 5126
    }

    public enum PixelFormat : uint
    {
        UnsignedShort = 5123,
        UnsignedInt = 5125,
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410
    }

    public enum AttributeType : uint
    {
        UnsignedInt = 5125,
        Float = 5126
    }

    public enum UniformType : uint
    {
        UnsignedInt = 5125,
        Float = 5126
    }

    public enum GlslTypeToken : uint
    {
        UnsignedInt = 5125,
        Float = 5126
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
        Invert = 5386
    }

    public enum MatrixMode : uint
    {
        Modelview = 5888,
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
        Sampler = 33510
    }

    public enum PixelCopyType : uint
    {
        ColorExt = 6144,
        DepthExt = 6145,
        StencilExt = 6146
    }

    public enum InvalidateFramebufferAttachment : uint
    {
        ColorAttachment0Oes = 36064,
        DepthAttachmentOes = 36096,
        StencilAttachmentOes = 36128
    }

    public enum InternalFormat : uint
    {
        Rgb = 6407,
        Rgba = 6408,
        Alpha8Ext = 32828,
        Alpha8Oes = 32828,
        Luminance8Ext = 32832,
        Luminance8Oes = 32832,
        Luminance4Alpha4Oes = 32835,
        Luminance8Alpha8Ext = 32837,
        Luminance8Alpha8Oes = 32837,
        Rgb8Oes = 32849,
        Rgb10Ext = 32850,
        Rgba4Oes = 32854,
        Rgb5A1Oes = 32855,
        Rgba8Oes = 32856,
        Rgb10A2Ext = 32857,
        DepthComponent16Oes = 33189,
        DepthComponent24Oes = 33190,
        DepthComponent32Oes = 33191,
        R8Ext = 33321,
        Rg8Ext = 33323,
        R16fExt = 33325,
        R32fExt = 33326,
        Rg16fExt = 33327,
        Rg32fExt = 33328,
        CompressedRgbS3tcDxt1Ext = 33776,
        CompressedRgbaS3tcDxt1Ext = 33777,
        DepthStencilOes = 34041,
        Rgba32fExt = 34836,
        Rgb32fExt = 34837,
        Rgba16fExt = 34842,
        Rgb16fExt = 34843,
        Depth24Stencil8Oes = 35056,
        SrgbExt = 35904,
        SrgbAlphaExt = 35906,
        Srgb8Alpha8Ext = 35907,
        StencilIndex1Oes = 36166,
        StencilIndex4Oes = 36167,
        StencilIndex8Oes = 36168,
        Rgb565Oes = 36194,
        Etc1Rgb8Oes = 36196
    }

    public enum CombinerComponentUsageNV : uint
    {
        Alpha = 6406,
        Rgb = 6407
    }

    public enum CombinerPortionNV : uint
    {
        Alpha = 6406,
        Rgb = 6407
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
        Extensions = 7939
    }

    public enum TextureCoordName : uint
    {
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

    public enum TextureGenParameter : uint
    {
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
        ClampToEdge = 33071
    }

    public enum SamplerParameterI : uint
    {
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243
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
        Rgb8Oes = 32849,
        Rgb10Ext = 32850,
        Rgba4Oes = 32854,
        Rgb5A1Oes = 32855,
        Rgba8Oes = 32856,
        Rgb10A2Ext = 32857,
        DepthComponent16Oes = 33189,
        DepthComponent24Oes = 33190,
        DepthComponent32Oes = 33191,
        R8Ext = 33321,
        Rg8Ext = 33323,
        R16fExt = 33325,
        R32fExt = 33326,
        Rg16fExt = 33327,
        Rg32fExt = 33328,
        CompressedRgbS3tcDxt1Ext = 33776,
        CompressedRgbaS3tcDxt1Ext = 33777,
        Rgba32fExt = 34836,
        Rgb32fExt = 34837,
        Rgba16fExt = 34842,
        Rgb16fExt = 34843,
        Depth24Stencil8Oes = 35056,
        Srgb8Alpha8Ext = 35907,
        StencilIndex1Oes = 36166,
        StencilIndex4Oes = 36167,
        StencilIndex8Oes = 36168,
        Rgb565Oes = 36194,
        Etc1Rgb8Oes = 36196
    }

    public enum ClipPlaneName : uint
    {
        ClipPlane0 = 12288,
        ClipPlane1 = 12289,
        ClipPlane2 = 12290,
        ClipPlane3 = 12291,
        ClipPlane4 = 12292,
        ClipPlane5 = 12293
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
        Light7 = 16391
    }

    public enum BlendEquationModeEXT : uint
    {
        FuncAddExt = 32774,
        MinExt = 32775,
        MaxExt = 32776
    }

    public enum ConvolutionTargetEXT : uint
    {
    }

    public enum ConvolutionParameterEXT : uint
    {
    }

    public enum HistogramTargetEXT : uint
    {
    }

    public enum GetHistogramParameterPNameEXT : uint
    {
    }

    public enum InternalFormatPName : uint
    {
        Samples = 32937,
        GenerateMipmap = 33169
    }

    public enum BufferTargetARB : uint
    {
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963
    }

    public enum PointParameterNameSGIS : uint
    {
        PointSizeMin = 33062,
        PointSizeMax = 33063,
        PointFadeThresholdSize = 33064,
        PointDistanceAttenuation = 33065
    }

    public enum PointParameterNameARB : uint
    {
        PointFadeThresholdSize = 33064
    }

    public enum FramebufferAttachmentParameterName : uint
    {
        FramebufferAttachmentColorEncodingExt = 33296,
        FramebufferAttachmentObjectTypeOes = 36048,
        FramebufferAttachmentObjectNameOes = 36049,
        FramebufferAttachmentTextureLevelOes = 36050,
        FramebufferAttachmentTextureCubeMapFaceOes = 36051,
        FramebufferAttachmentTextureSamplesExt = 36204
    }

    public enum FramebufferStatus : uint
    {
    }

    public enum VertexBufferObjectParameter : uint
    {
        BufferSize = 34660,
        BufferUsage = 34661
    }

    public enum BufferPNameARB : uint
    {
        BufferSize = 34660,
        BufferUsage = 34661
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
        PrimaryColor = 34167
    }

    public enum RegisterCombinerPname : uint
    {
        Combine = 34160,
        CombineRgb = 34161,
        CombineAlpha = 34162,
        RgbScale = 34163,
        AddSigned = 34164,
        Interpolate = 34165,
        Constant = 34166,
        PrimaryColor = 34167,
        Previous = 34168,
        Src0Rgb = 34176,
        Src1Rgb = 34177,
        Src2Rgb = 34178,
        Src0Alpha = 34184,
        Src1Alpha = 34185,
        Src2Alpha = 34186,
        Operand0Rgb = 34192,
        Operand1Rgb = 34193,
        Operand2Rgb = 34194,
        Operand0Alpha = 34200,
        Operand1Alpha = 34201,
        Operand2Alpha = 34202
    }

    public enum CopyBufferSubDataTarget : uint
    {
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963
    }

    public enum BufferStorageTarget : uint
    {
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963
    }

    public enum BufferAccessARB : uint
    {
    }

    public enum BufferPointerNameARB : uint
    {
    }

    public enum VertexBufferObjectUsage : uint
    {
        StaticDraw = 35044,
        DynamicDraw = 35048
    }

    public enum BufferUsageARB : uint
    {
        StaticDraw = 35044,
        DynamicDraw = 35048
    }

    public enum ShaderType : uint
    {
    }

    public enum FramebufferTarget : uint
    {
        FramebufferOes = 36160
    }

    public enum RenderbufferParameterName : uint
    {
        RenderbufferSamplesApple = 36011,
        RenderbufferSamplesExt = 36011,
        RenderbufferWidthOes = 36162,
        RenderbufferHeightOes = 36163,
        RenderbufferInternalFormatOes = 36164,
        RenderbufferRedSizeOes = 36176,
        RenderbufferGreenSizeOes = 36177,
        RenderbufferBlueSizeOes = 36178,
        RenderbufferAlphaSizeOes = 36179,
        RenderbufferDepthSizeOes = 36180,
        RenderbufferStencilSizeOes = 36181,
        RenderbufferSamplesImg = 37171
    }

    public enum FramebufferAttachment : uint
    {
    }

    public enum RenderbufferTarget : uint
    {
        RenderbufferOes = 36161
    }

    public enum SyncParameterName : uint
    {
    }

    public enum SyncCondition : uint
    {
    }

    public enum SyncStatus : uint
    {
    }

#pragma warning restore CA1069 // Enums should not have duplicate values
}
