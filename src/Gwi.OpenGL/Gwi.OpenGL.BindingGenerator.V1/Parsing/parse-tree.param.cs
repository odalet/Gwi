namespace Gwi.OpenGL.BindingGenerator.Parsing
{
    public enum HandleType
    {
        ProgramHandle,
        ProgramPipelineHandle,
        TextureHandle,
        BufferHandle,
        ShaderHandle,
        QueryHandle,
        FramebufferHandle,
        RenderbufferHandle,
        SamplerHandle,
        TransformFeedbackHandle,
        VertexArrayHandle,
        DisplayListHandle,
    }

    public enum PrimitiveType
    {
        Invalid,
        Void,
        Byte,
        Sbyte,
        Short,
        Ushort,
        Int,
        Uint,
        Long,
        Ulong,
        Half,
        Float,
        Double,
        IntPtr,
        Nint,
        Enum,
        Bool8,
        Char8,
        VoidPtr,
        GLHandleARB,
        GLSync,
        CLContext,
        CLEvent,
        GLDebugProc,
        GLDebugProcARB,
        GLDebugProcKHR,
        GLDebugProcAMD,
        GLDebugProcNV,
        GLVulkanProcNV
    }

    public sealed record GLParameter(PType Type, string Name, Expr? Length);
    public sealed record PType(GLType Type, HandleType? Handle, string? Group);
    public abstract record GLType();
    public sealed record GLBaseType(string OriginalString, PrimitiveType Type, bool Constant) : GLType;
    public sealed record GLPointerType(GLType BaseType, bool Constant) : GLType;
}
