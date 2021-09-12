using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct BufferHandle : IEquatable<BufferHandle>
    {
        public static readonly BufferHandle Zero = new(0);

        public BufferHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is BufferHandle device && Equals(device);

        public bool Equals([AllowNull] BufferHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(BufferHandle left, BufferHandle right) => left.Equals(right);

        public static bool operator !=(BufferHandle left, BufferHandle right) => !(left == right);

        public static explicit operator BufferHandle(int Buffer) => new(Buffer);
        public static explicit operator int(BufferHandle handle) => handle.Handle;
    }
}
