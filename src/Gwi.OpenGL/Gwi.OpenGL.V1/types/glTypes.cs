using System;
using System.Runtime.InteropServices;

namespace Gwi.OpenGL
{
    public readonly struct GLSync
    {
        public GLSync(IntPtr value) => Value = value;
        public IntPtr Value { get; }
        public static explicit operator GLSync(IntPtr value) => new(value);
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct GLHandleARB
    {
        [FieldOffset(0)] private readonly uint value1;
        [FieldOffset(0)] private readonly IntPtr value2;

        public GLHandleARB(uint value)
        {
            value2 = IntPtr.Zero;
            value1 = value;
        }

        public GLHandleARB(IntPtr value)
        {
            value1 = 0;
            value2 = value;
        }

        public static explicit operator GLHandleARB(uint value) => new(value);
        public static explicit operator GLHandleARB(IntPtr value) => new(value);
        public static explicit operator uint(GLHandleARB value) => value.value1;
        public static explicit operator IntPtr(GLHandleARB value) => value.value2;
    }
}
