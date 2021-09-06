using System;
using GLFW;
using GlfwSlikTestApp.TK;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using N = System.Numerics;

namespace GlfwSlikTestApp
{
    class OpenTKImpl
    {
        internal sealed class GlfwNativeLib : IBindingsContext
        {
            //public void Dispose() { /* Nothing to do */ }
            //public nint GetProcAddress(string proc, int? slot = null) => Glfw.GetProcAddress(proc);
            //public bool TryGetProcAddress(string proc, out nint addr, int? slot = null)
            //{
            //    try
            //    {
            //        addr = GetProcAddress(proc, slot);
            //        return true;
            //    }
            //    catch
            //    {
            //        addr = 0;
            //        return false;
            //    }
            //}
            public IntPtr GetProcAddress(string procName) => Glfw.GetProcAddress(procName);
        }

        private static bool showExtensions = false;
        private static Window window;
        private static GL gl;
        private static readonly Random rand = new();

        private static float rotation = 0f;
        private static N.Vector2 translation = new(0f, 0f);
        //private static N.Vector4 color = new(1f, 1f, 1f, 1f);
        private static N.Vector4 color = new(0.5f, 0.5f, 0.5f, 0.5f);

        public static void Run()
        {
            const int width = 1024;
            const int height = 768;

            // Set some common hints for the OpenGL profile creation
            Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
            Glfw.WindowHint(Hint.OpenglDebugContext, true);
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
            GL.LoadBindings(lib);

            // Info
            Console.WriteLine("Version   : " + GL.GetString(StringName.Version));
            Console.WriteLine("Vendor    : " + GL.GetString(StringName.Vendor));
            Console.WriteLine("GLSL      : " + GL.GetString(StringName.ShadingLanguageVersion));
            Console.WriteLine("Renderer  : " + GL.GetString(StringName.Renderer));
            if (showExtensions)
            {
                Console.WriteLine("Extensions: ");
                var extensions = (GL.GetString(StringName.Extensions) ?? "").Split(" ");
                foreach (var extension in extensions)
                    Console.WriteLine($"\t{extension}");
            }

            GL.Viewport(0, 0, width, height);

            // Build the triangle
            TriangleBuilder.CreateTriangle(out var vbo, out var vao, out var ebo);
            var triangle = new TriangleShader();

            // Set a key callback
            _ = Glfw.SetKeyCallback(window, KeyCallback);

            var tick = 0L;
            //ChangeRandomColor();

            while (!Glfw.WindowShouldClose(window))
            {
                // Poll for OS events and swap front/back buffers
                Glfw.PollEvents();

                //// Change background color to something random every 60 draws
                //if (tick++ % 60 == 0)
                //    ChangeRandomColor();

                //// Clear the buffer to the set color
                //gl.Clear(ClearBufferMask.ColorBufferBit); // GL_COLOR_BUFFER_BIT

                // Draw the triangle
                GL.ClearColor(0.45f, 0.55f, 0.6f, 1f);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                triangle.UseShader();
                GL.BindVertexArray(vao);
                GL.DrawElements(PrimitiveType.Triangles, 3, DrawElementsType.UnsignedInt, 0);
                GL.BindVertexArray(0);

                // Shader parameters
                GL.Uniform1(triangle.GetUniformLocation("rotation"), rotation);
                GL.Uniform2(triangle.GetUniformLocation("translation"), translation.X, translation.Y);
                GL.Uniform3(triangle.GetUniformLocation("color"), color.X, color.Y, color.Z);

                Util.CheckGLError("End of frame");

                Glfw.SwapBuffers(window);
            }
        }

        private static void ChangeRandomColor()
        {
            var r = (float)rand.NextDouble();
            var g = (float)rand.NextDouble();
            var b = (float)rand.NextDouble();
            GL.ClearColor(r, g, b, 1f);
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
