using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct VertexArrayHandle : IEquatable<VertexArrayHandle>
    {
        public static readonly VertexArrayHandle Zero = new(0);

        public VertexArrayHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is VertexArrayHandle device && Equals(device);

        public bool Equals([AllowNull] VertexArrayHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(VertexArrayHandle left, VertexArrayHandle right) => left.Equals(right);

        public static bool operator !=(VertexArrayHandle left, VertexArrayHandle right) => !(left == right);

        public static explicit operator VertexArrayHandle(int VertexArray) => new(VertexArray);
        public static explicit operator int(VertexArrayHandle handle) => handle.Handle;
    }
}
