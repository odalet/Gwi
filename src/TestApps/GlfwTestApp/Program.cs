using System;
using System.Numerics;
using GLFW;
using Gwi.OpenGL;

namespace GlfwTestApp
{
    class Program
    {
        private static readonly bool showExtensions = false;
        private static Window window;
        private static GL gl;
        private static readonly Random rand = new();

        private static float rotation = 0f;
        private static Vector2 translation = new(0f, 0f);
        //private static Vector4 color = new(1f, 1f, 1f, 1f);
        private static Vector4 color = new(0.5f, 0.5f, 0.5f, 0.5f);

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

            gl = new GL(procedureName => Glfw.GetProcAddress(procedureName));

            // Info
            Console.WriteLine("Version   : " + gl.GetString(StringName.Version));
            Console.WriteLine("Vendor    : " + gl.GetString(StringName.Vendor));
            Console.WriteLine("GLSL      : " + gl.GetString(StringName.ShadingLanguageVersion));
            Console.WriteLine("Renderer  : " + gl.GetString(StringName.Renderer));
            if (showExtensions)
            {
                Console.WriteLine("Extensions: ");
                var extensions = (gl.GetString(StringName.Extensions) ?? "").Split(" ");
                foreach (var extension in extensions)
                    Console.WriteLine($"\t{extension}");
            }

            gl.CheckGLError("1");

            // Build the triangle
            TriangleBuilder.CreateTriangleGeometry(gl, out var vbo, out var vao, out var ebo);
            using var triangle = TriangleBuilder.CreateTriangleShader(gl);

            // Set a key callback
            _ = Glfw.SetKeyCallback(window, KeyCallback);

            Loop(window, triangle, vao);
        }

        private static void Loop(Window window, Shader triangle, uint vao)
        {
            var tick = 0L;
            ChangeRandomColor();

            while (!Glfw.WindowShouldClose(window))
            {
                // Poll for OS events and swap front/back buffers
                Glfw.PollEvents();

                // Change background color to something random every 60 draws
                if (tick++ % 60 == 0)
                    ChangeRandomColor();

                // Clear the buffer to the set color
                gl.Clear(ClearBufferMask.ColorBufferBit);

                gl.BindVertexArray(vao);
                triangle.UseShader();
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
