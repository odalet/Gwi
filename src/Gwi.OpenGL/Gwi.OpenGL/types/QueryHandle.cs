using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct QueryHandle : IEquatable<QueryHandle>
    {
        public static readonly QueryHandle Zero = new(0);

        public QueryHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is QueryHandle device && Equals(device);

        public bool Equals([AllowNull] QueryHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(QueryHandle left, QueryHandle right) => left.Equals(right);

        public static bool operator !=(QueryHandle left, QueryHandle right) => !(left == right);

        public static explicit operator QueryHandle(int Query) => new(Query);
        public static explicit operator int(QueryHandle handle) => handle.Handle;
    }
}
