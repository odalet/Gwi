using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct TextureHandle : IEquatable<TextureHandle>
    {
        public static readonly TextureHandle Zero = new(0);

        public TextureHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is TextureHandle device && Equals(device);

        public bool Equals([AllowNull] TextureHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(TextureHandle left, TextureHandle right) => left.Equals(right);

        public static bool operator !=(TextureHandle left, TextureHandle right) => !(left == right);

        public static explicit operator TextureHandle(int Texture) => new(Texture);
        public static explicit operator int(TextureHandle handle) => handle.Handle;
    }
}
