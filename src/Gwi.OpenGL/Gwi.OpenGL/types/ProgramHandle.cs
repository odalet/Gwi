using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct ProgramHandle : IEquatable<ProgramHandle>
    {
        public static readonly ProgramHandle Zero = new(0);

        public ProgramHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is ProgramHandle device && Equals(device);

        public bool Equals([AllowNull] ProgramHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(ProgramHandle left, ProgramHandle right) => left.Equals(right);

        public static bool operator !=(ProgramHandle left, ProgramHandle right) => !(left == right);

        public static explicit operator ProgramHandle(int Program) => new(Program);
        public static explicit operator int(ProgramHandle handle) => handle.Handle;
    }
}
