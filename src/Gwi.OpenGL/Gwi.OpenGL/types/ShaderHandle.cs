using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct ShaderHandle : IEquatable<ShaderHandle>
    {
        public static readonly ShaderHandle Zero = new(0);

        public ShaderHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is ShaderHandle device && Equals(device);

        public bool Equals([AllowNull] ShaderHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(ShaderHandle left, ShaderHandle right) => left.Equals(right);

        public static bool operator !=(ShaderHandle left, ShaderHandle right) => !(left == right);

        public static explicit operator ShaderHandle(int Shader) => new(Shader);
        public static explicit operator int(ShaderHandle handle) => handle.Handle;
    }
}
