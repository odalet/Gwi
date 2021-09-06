using System;
using GLFW;
using GlfwSlikTestApp.Silk;
using Silk.NET.Core.Contexts;
using Silk.NET.OpenGL;
using N = System.Numerics;

namespace GlfwSlikTestApp
{
    internal static class SilkImpl
    {
        internal sealed class GlfwNativeLib : INativeContext
        {
            public void Dispose() { /* Nothing to do */ }
            public nint GetProcAddress(string proc, int? slot = null) => Glfw.GetProcAddress(proc);
            public bool TryGetProcAddress(string proc, out nint addr, int? slot = null)
            {
                try
                {
                    addr = GetProcAddress(proc, slot);
                    return true;
                }
                catch
                {
                    addr = 0;
                    return false;
                }
            }
        }

        private static bool showExtensions = false;
        private static Window window;
        private static GL gl;
        private static readonly Random rand = new();

        private static float rotation = 0f;
        private static N.Vector2 translation = new(0f, 0f);
        //private static N.Vector4 color = new(1f, 1f, 1f, 1f);
        private static N.Vector4 color = new(0.5f, 0.5f, 0.5f, 0.5f);

        public static void Run() => Run2();

        public static void Run1()
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
            gl = new GL(lib);

            // Info
            Console.WriteLine("Version   : " + gl.GetStringS(StringName.Version));
            Console.WriteLine("Vendor    : " + gl.GetStringS(StringName.Vendor));
            Console.WriteLine("GLSL      : " + gl.GetStringS(StringName.ShadingLanguageVersion));
            Console.WriteLine("Renderer  : " + gl.GetStringS(StringName.Renderer));
            if (showExtensions)
            {
                Console.WriteLine("Extensions: ");
                var extensions = (gl.GetStringS(StringName.Extensions) ?? "").Split(" ");
                foreach (var extension in extensions)
                    Console.WriteLine($"\t{extension}");
            }

            gl.Viewport(0, 0, width, height);

            // Build the triangle
            TriangleBuilder.CreateTriangle(gl, out var vbo, out var vao, out var ebo);
            var triangle = new TriangleShader(gl);

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
                gl.ClearColor(0.45f, 0.55f, 0.6f, 1f);
                gl.Clear(ClearBufferMask.ColorBufferBit);

                triangle.UseShader();
                gl.BindVertexArray(vao);
                gl.DrawElements(PrimitiveType.Triangles, 3, DrawElementsType.UnsignedInt, 0);
                gl.BindVertexArray(0);

                // Shader parameters
                gl.Uniform1(triangle.GetUniformLocation("rotation"), rotation);
                gl.Uniform2(triangle.GetUniformLocation("translation"), translation.X, translation.Y);
                gl.Uniform3(triangle.GetUniformLocation("color"), color.X, color.Y, color.Z);

                gl.CheckGLError("End of frame");

                Glfw.SwapBuffers(window);
            }
        }

        public static void Run2()
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
            gl = new GL(lib);

            // Info
            Console.WriteLine("Version   : " + gl.GetStringS(StringName.Version));
            Console.WriteLine("Vendor    : " + gl.GetStringS(StringName.Vendor));
            Console.WriteLine("GLSL      : " + gl.GetStringS(StringName.ShadingLanguageVersion));
            Console.WriteLine("Renderer  : " + gl.GetStringS(StringName.Renderer));
            if (showExtensions)
            {
                Console.WriteLine("Extensions: ");
                var extensions = (gl.GetStringS(StringName.Extensions) ?? "").Split(" ");
                foreach (var extension in extensions)
                    Console.WriteLine($"\t{extension}");
            }

            gl.Viewport(0, 0, width, height);

            var quad = new QuadShader(gl);


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
                gl.ClearColor(0.45f, 0.55f, 0.6f, 1f);
                gl.Clear(ClearBufferMask.ColorBufferBit);

                gl.BindVertexArray(quad.Vao);
                gl.UseProgram(quad.Shader); //quad.Shader.UseShader();

                gl.DrawElements(PrimitiveType.Triangles, 3u, DrawElementsType.UnsignedInt, 0);
                //gl.BindVertexArray(0);

                //// Shader parameters
                //gl.Uniform1(triangle.GetUniformLocation("rotation"), rotation);
                //gl.Uniform2(triangle.GetUniformLocation("translation"), translation.X, translation.Y);
                //gl.Uniform3(triangle.GetUniformLocation("color"), color.X, color.Y, color.Z);

                gl.CheckGLError("End of frame");

                Glfw.SwapBuffers(window);
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
