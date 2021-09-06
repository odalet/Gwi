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

        public static void Run() => Run1();

        public static unsafe void Run1()
        {
            const int width = 1024;
            const int height = 768;

            // Set some common hints for the OpenGL profile creation
            Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
            Glfw.WindowHint(Hint.OpenglDebugContext, true);
            Glfw.WindowHint(Hint.OpenglForwardCompatible, true);
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

                gl.BindVertexArray(vao);
                triangle.UseShader();
                gl.DrawElements(PrimitiveType.Triangles, 3, DrawElementsType.UnsignedInt, null);
                gl.BindVertexArray(0);

                // Shader parameters
                gl.Uniform1(triangle.GetUniformLocation("rotation"), rotation);
                gl.Uniform2(triangle.GetUniformLocation("translation"), translation.X, translation.Y);
                gl.Uniform3(triangle.GetUniformLocation("color"), color.X, color.Y, color.Z);

                gl.CheckGLError("End of frame");

                Glfw.SwapBuffers(window);
            }
        }

        public static unsafe void Run2()
        {
            const int width = 1024;
            const int height = 768;

            // Set some common hints for the OpenGL profile creation
            Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            //Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Compatibility);
            Glfw.WindowHint(Hint.OpenglDebugContext, true);
            Glfw.WindowHint(Hint.OpenglForwardCompatible, true);
            //Glfw.WindowHint(Hint.Doublebuffer, true); // ?
            Glfw.WindowHint(Hint.Decorated, true);

            Glfw.WindowHint(Hint.RefreshRate, -1);
            Glfw.WindowHint(Hint.DepthBits, -1);
            Glfw.WindowHint(Hint.StencilBits, -1);
            Glfw.WindowHint(Hint.RedBits, -1);
            Glfw.WindowHint(Hint.GreenBits, -1);
            Glfw.WindowHint(Hint.BlueBits, -1);
            Glfw.WindowHint(Hint.AlphaBits, -1);

            Glfw.WindowHint(Hint.TransparentFramebuffer, false);

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
            quad.Build();

            // Set a key callback
            _ = Glfw.SetKeyCallback(window, KeyCallback);

            var tick = 0L;
            //ChangeRandomColor();

            while (!Glfw.WindowShouldClose(window))
            {
                // Poll for OS events and swap front/back buffers
                Glfw.PollEvents();

                //Clear the color channel.
                gl.Clear(ClearBufferMask.ColorBufferBit);

                //Bind the geometry and shader.
                gl.BindVertexArray(quad.Vao);
                gl.UseProgram(quad.Shader);

                //Draw the geometry.
                var len = 6u; // (uint)Indices.Length
                gl.DrawElements(PrimitiveType.Triangles, len, DrawElementsType.UnsignedInt, null);

                gl.CheckGLError("End of frame");

                Glfw.SwapBuffers(window);
            }
        }

        private static uint Vbo;
        private static uint Ebo;
        private static uint Vao;
        private static uint Shader;
        //Vertex shaders are run on each vertex.
        private static readonly string VertexShaderSource = @"
        #version 330 core //Using version GLSL version 3.3
        layout (location = 0) in vec4 vPos;
        
        void main()
        {
            gl_Position = vec4(vPos.x, vPos.y, vPos.z, 1.0);
        }
        ";

        //Fragment shaders are run on each fragment/pixel of the geometry.
        private static readonly string FragmentShaderSource = @"
        #version 330 core
        out vec4 FragColor;

        void main()
        {
            FragColor = vec4(1.0f, 0.5f, 0.2f, 1.0f);
        }
        ";

        //Vertex data, uploaded to the VBO.
        private static readonly float[] Vertices =
        {
            //X    Y      Z
             0.5f,  0.5f, 0.0f,
             0.5f, -0.5f, 0.0f,
            -0.5f, -0.5f, 0.0f,
            -0.5f,  0.5f, 0.5f
        };

        //Index data, uploaded to the EBO.
        private static readonly uint[] Indices =
        {
            0, 1, 3,
            1, 2, 3
        };
        public static unsafe void Run3()
        {
            const int width = 1024;
            const int height = 768;

            // Set some common hints for the OpenGL profile creation
            Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
            //Glfw.WindowHint(Hint.OpenglProfile, Profile.Compatibility);
            Glfw.WindowHint(Hint.OpenglDebugContext, true);
            Glfw.WindowHint(Hint.OpenglForwardCompatible, true);
            Glfw.WindowHint(Hint.Doublebuffer, true); // ?
            Glfw.WindowHint(Hint.Decorated, true);

            //Glfw.WindowHint(Hint.RefreshRate, -1);
            //Glfw.WindowHint(Hint.DepthBits, -1);
            //Glfw.WindowHint(Hint.StencilBits, -1);
            //Glfw.WindowHint(Hint.RedBits, -1);
            //Glfw.WindowHint(Hint.GreenBits, -1);
            //Glfw.WindowHint(Hint.BlueBits, -1);
            //Glfw.WindowHint(Hint.AlphaBits, -1);

            //Glfw.WindowHint(Hint.TransparentFramebuffer, false);

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

            //Getting the opengl api for drawing to the screen.
            var Gl = gl; // Gl = GL.GetApi(window);

            //Creating a vertex array.
            Vao = Gl.GenVertexArray();
            Gl.BindVertexArray(Vao);

            //Initializing a vertex buffer that holds the vertex data.
            Vbo = Gl.GenBuffer(); //Creating the buffer.
            Gl.BindBuffer(BufferTargetARB.ArrayBuffer, Vbo); //Binding the buffer.
            fixed (void* v = &Vertices[0])
            {
                Gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint)(Vertices.Length * sizeof(uint)), v, BufferUsageARB.StaticDraw); //Setting buffer data.
            }

            //Initializing a element buffer that holds the index data.
            Ebo = Gl.GenBuffer(); //Creating the buffer.
            Gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, Ebo); //Binding the buffer.
            fixed (void* i = &Indices[0])
            {
                Gl.BufferData(BufferTargetARB.ElementArrayBuffer, (nuint)(Indices.Length * sizeof(uint)), i, BufferUsageARB.StaticDraw); //Setting buffer data.
            }

            //Creating a vertex shader.
            uint vertexShader = Gl.CreateShader(ShaderType.VertexShader);
            Gl.ShaderSource(vertexShader, VertexShaderSource);
            Gl.CompileShader(vertexShader);

            //Checking the shader for compilation errors.
            string infoLog = Gl.GetShaderInfoLog(vertexShader);
            if (!string.IsNullOrWhiteSpace(infoLog))
            {
                Console.WriteLine($"Error compiling vertex shader {infoLog}");
            }

            //Creating a fragment shader.
            uint fragmentShader = Gl.CreateShader(ShaderType.FragmentShader);
            Gl.ShaderSource(fragmentShader, FragmentShaderSource);
            Gl.CompileShader(fragmentShader);

            //Checking the shader for compilation errors.
            infoLog = Gl.GetShaderInfoLog(fragmentShader);
            if (!string.IsNullOrWhiteSpace(infoLog))
            {
                Console.WriteLine($"Error compiling fragment shader {infoLog}");
            }

            //Combining the shaders under one shader program.
            Shader = Gl.CreateProgram();
            Gl.AttachShader(Shader, vertexShader);
            Gl.AttachShader(Shader, fragmentShader);
            Gl.LinkProgram(Shader);

            //Checking the linking for errors.
            Gl.GetProgram(Shader, GLEnum.LinkStatus, out var status);
            if (status == 0)
            {
                Console.WriteLine($"Error linking shader {Gl.GetProgramInfoLog(Shader)}");
            }

            //Delete the no longer useful individual shaders;
            Gl.DetachShader(Shader, vertexShader);
            Gl.DetachShader(Shader, fragmentShader);
            Gl.DeleteShader(vertexShader);
            Gl.DeleteShader(fragmentShader);

            //Tell opengl how to give the data to the shaders.
            Gl.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), null);
            Gl.EnableVertexAttribArray(0);

            // Set a key callback
            _ = Glfw.SetKeyCallback(window, KeyCallback);

            while (!Glfw.WindowShouldClose(window))
            {
                // Poll for OS events and swap front/back buffers
                Glfw.PollEvents();

                //Clear the color channel.
                Gl.Clear(ClearBufferMask.ColorBufferBit);

                //Bind the geometry and shader.
                Gl.BindVertexArray(Vao);
                Gl.UseProgram(Shader);

                //Draw the geometry.
                Gl.DrawElements(PrimitiveType.Triangles, (uint)Indices.Length, DrawElementsType.UnsignedInt, null);
                //Gl.DrawElements(PrimitiveType.Triangles, (uint)Indices.Length, DrawElementsType.UnsignedInt, 0);

                Gl.CheckGLError("End of frame");
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
