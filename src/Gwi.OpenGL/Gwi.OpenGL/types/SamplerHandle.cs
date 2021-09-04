using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct SamplerHandle : IEquatable<SamplerHandle>
    {
        public static readonly SamplerHandle Zero = new(0);

        public SamplerHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is SamplerHandle device && Equals(device);

        public bool Equals([AllowNull] SamplerHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(SamplerHandle left, SamplerHandle right) => left.Equals(right);

        public static bool operator !=(SamplerHandle left, SamplerHandle right) => !(left == right);

        public static explicit operator SamplerHandle(int Sampler) => new(Sampler);
        public static explicit operator int(SamplerHandle handle) => handle.Handle;
    }
}
