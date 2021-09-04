using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct FramebufferHandle : IEquatable<FramebufferHandle>
    {
        public static readonly FramebufferHandle Zero = new(0);

        public FramebufferHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is FramebufferHandle device && Equals(device);

        public bool Equals([AllowNull] FramebufferHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(FramebufferHandle left, FramebufferHandle right) => left.Equals(right);

        public static bool operator !=(FramebufferHandle left, FramebufferHandle right) => !(left == right);

        public static explicit operator FramebufferHandle(int Framebuffer) => new(Framebuffer);
        public static explicit operator int(FramebufferHandle handle) => handle.Handle;
    }
}
