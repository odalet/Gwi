using System;
using GLFW;
using Gwi;
using Gwi.OpenGL.GL4;

namespace GlfwTestApp
{
    internal sealed class GlfwNativeLib : INativeLib
    {
        public nint GetProcAddress(string procedureName) => Glfw.GetProcAddress(procedureName);
    }

    class Program
    {
        private static Window window;
        private static GL gl;
        private static Random rand = new();

        static void Main(string[] args)
        {
            const int width = 1024;
            const int height = 768;

            // Set some common hints for the OpenGL profile creation
            Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
            Glfw.WindowHint(Hint.Doublebuffer, true);
            Glfw.WindowHint(Hint.Decorated, true);

            window = Glfw.CreateWindow(width, height, "Test", Monitor.None, Window.None);
            Glfw.MakeContextCurrent(window);

            // Effectively enables VSYNC by setting to 1.
            Glfw.SwapInterval(1);

            // Find center position based on window and monitor sizes
            var screenSize = Glfw.PrimaryMonitor.WorkArea;
            var x = (screenSize.Width - width) / 2;
            var y = (screenSize.Height - height) / 2;
            Glfw.SetWindowPosition(window, x, y);

            var lib = new GlfwNativeLib();
            gl = new GL(lib);

            // Set a key callback
            _ = Glfw.SetKeyCallback(window, KeyCallback);

            var tick = 0L;
            ChangeRandomColor();

            while (!Glfw.WindowShouldClose(window))
            {
                // Poll for OS events and swap front/back buffers
                Glfw.PollEvents();
                Glfw.SwapBuffers(window);

                // Change background color to something random every 60 draws
                if (tick++ % 60 == 0)
                    ChangeRandomColor();

                // Clear the buffer to the set color
                gl.Clear(ClearBufferMask.ColorBufferBit); // GL_COLOR_BUFFER_BIT
            }
        }

        private static void ChangeRandomColor()
        {
            var r = (float)rand.NextDouble();
            var g = (float)rand.NextDouble();
            var b = (float)rand.NextDouble();
            gl.ClearColor(r, g, b, 1f);
        }

        private static void KeyCallback(IntPtr w, Keys key, int scanCode, InputState state, ModifierKeys mods)
        {
            switch (key)
            {
                case Keys.Escape:
                    Glfw.SetWindowShouldClose(window, true);
                    break;
            }
        }
    }
}
