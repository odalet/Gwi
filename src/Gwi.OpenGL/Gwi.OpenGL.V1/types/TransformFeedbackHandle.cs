using System;
using System.Diagnostics.CodeAnalysis;

namespace Gwi.OpenGL
{
    public readonly struct TransformFeedbackHandle : IEquatable<TransformFeedbackHandle>
    {
        public static readonly TransformFeedbackHandle Zero = new(0);

        public TransformFeedbackHandle(int handle) => Handle = handle;

        public int Handle { get; }

        public override bool Equals(object? obj) => obj is TransformFeedbackHandle device && Equals(device);

        public bool Equals([AllowNull] TransformFeedbackHandle other) => Handle.Equals(other.Handle);

        public override int GetHashCode() => HashCode.Combine(Handle);

        public static bool operator ==(TransformFeedbackHandle left, TransformFeedbackHandle right) => left.Equals(right);

        public static bool operator !=(TransformFeedbackHandle left, TransformFeedbackHandle right) => !(left == right);

        public static explicit operator TransformFeedbackHandle(int TransformFeedback) => new(TransformFeedback);
        public static explicit operator int(TransformFeedbackHandle handle) => handle.Handle;
    }
}
