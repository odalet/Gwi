using System;
using System.Diagnostics;

namespace Gwi.OpenGL
{
    public static class Utils
    {
        [Conditional("DEBUG")]
        public static void CheckGLError(this GL gl, string title)
        {
            var error = gl.GetError();
            if (error != ErrorCode.NoError)
                Console.WriteLine($"{title}: {error}");
        }
    }
}
