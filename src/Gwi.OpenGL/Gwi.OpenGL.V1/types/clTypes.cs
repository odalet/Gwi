using System;

namespace Gwi.OpenGL
{
    public readonly struct CLContext
    {
        public CLContext(IntPtr value) => Value = value;
        public IntPtr Value { get; }
        public static explicit operator CLContext(IntPtr value) => new(value);
    }

    public readonly struct CLEvent
    {
        public CLEvent(IntPtr value) => Value = value;
        public IntPtr Value { get; }
        public static explicit operator CLEvent(IntPtr value) => new(value);
    }
}
