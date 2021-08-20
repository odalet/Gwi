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

    public record GLParameter(PType Type, string Name, Expr? Length);
    public record PType(GLType Type, HandleType? Handle, string? Group);
    public abstract record GLType();
    public record GLBaseType(string OriginalString, PrimitiveType Type, bool Constant) : GLType;
    public record GLPointerType(GLType BaseType, bool Constant) : GLType;
}
