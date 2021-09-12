using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct RenderbufferHandle : IEquatable<RenderbufferHandle>
    {
        public static readonly RenderbufferHandle Zero = new(0);

        public RenderbufferHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is RenderbufferHandle device && Equals(device);

        public bool Equals([AllowNull] RenderbufferHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(RenderbufferHandle left, RenderbufferHandle right) => left.Equals(right);

        public static bool operator !=(RenderbufferHandle left, RenderbufferHandle right) => !(left == right);

        public static explicit operator RenderbufferHandle(int Renderbuffer) => new(Renderbuffer);
        public static explicit operator int(RenderbufferHandle handle) => handle.Handle;
    }
}
