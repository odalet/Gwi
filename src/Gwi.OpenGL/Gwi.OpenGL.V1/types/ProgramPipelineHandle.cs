using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct ProgramPipelineHandle : IEquatable<ProgramPipelineHandle>
    {
        public static readonly ProgramPipelineHandle Zero = new(0);

        public ProgramPipelineHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is ProgramPipelineHandle device && Equals(device);

        public bool Equals([AllowNull] ProgramPipelineHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(ProgramPipelineHandle left, ProgramPipelineHandle right) => left.Equals(right);

        public static bool operator !=(ProgramPipelineHandle left, ProgramPipelineHandle right) => !(left == right);

        public static explicit operator ProgramPipelineHandle(int ProgramPipeline) => new(ProgramPipeline);
        public static explicit operator int(ProgramPipelineHandle handle) => handle.Handle;
    }
}
