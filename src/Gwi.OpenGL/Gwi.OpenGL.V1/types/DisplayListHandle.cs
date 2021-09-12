using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct DisplayListHandle : IEquatable<DisplayListHandle>
    {
        public static readonly DisplayListHandle Zero = new(0);

        public DisplayListHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is DisplayListHandle device && Equals(device);

        public bool Equals([AllowNull] DisplayListHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(DisplayListHandle left, DisplayListHandle right) => left.Equals(right);

        public static bool operator !=(DisplayListHandle left, DisplayListHandle right) => !(left == right);

        public static explicit operator DisplayListHandle(int DisplayList) => new(DisplayList);
        public static explicit operator int(DisplayListHandle handle) => handle.Handle;
    }
}
