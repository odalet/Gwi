using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Silk.NET.OpenGL;

namespace GlfwSlikTestApp.Silk
{
    struct UniformFieldInfo
    {
        public int Location;
        public string Name;
        public int Size;
        public UniformType Type;
    }

    internal abstract class Shader
    {
        public readonly string Name;

        private readonly Dictionary<string, int> UniformToLocation = new();
        private bool Initialized = false;

        protected Shader(GL gl, string name, string vertexShader, string fragmentShader)
        {
            GL = gl ?? throw new ArgumentNullException(nameof(gl));
            Name = name;
            Program = CreateProgram(name, new[]
            {
                (ShaderType.VertexShader, vertexShader),
                (ShaderType.FragmentShader, fragmentShader),
            });
        }

        protected GL GL { get; }
        public uint Program { get; private set; }

        public void UseShader() => GL.UseProgram(Program);

        public void Dispose()
        {
            if (Initialized)
            {
                GL.DeleteProgram(Program);
                Initialized = false;
            }
        }

        public UniformFieldInfo[] GetUniforms()
        {
            GL.GetProgram(Program, ProgramPropertyARB.ActiveUniforms, out var uniformCount);

            var uniforms = new UniformFieldInfo[uniformCount];
            for (var i = 0u; i < uniformCount; i++)
            {
                var name = GL.GetActiveUniform(Program, i, out var size, out var type);

                UniformFieldInfo FieldInfo;
                FieldInfo.Location = GetUniformLocation(name);
                FieldInfo.Name = name;
                FieldInfo.Size = size;
                FieldInfo.Type = type;

                uniforms[i] = FieldInfo;
            }

            return uniforms;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetUniformLocation(string uniform)
        {
            if (!UniformToLocation.TryGetValue(uniform, out var location))
            {
                location = GL.GetUniformLocation(Program, uniform);
                UniformToLocation.Add(uniform, location);

                if (location == -1)
                    Console.WriteLine($"The uniform '{uniform}' does not exist in the shader '{Name}'!");
            }

            return location;
        }

        private uint CreateProgram(string name, params (ShaderType Type, string source)[] code)
        {
            var shaders = new uint[code.Length];
            for (var i = 0; i < code.Length; i++)
                shaders[i] = CompileShader(name, code[i].Type, code[i].source);

            //GL.CreateProgram(name, out var program);
            //Program = program;
            Program = GL.CreateProgram();
            foreach (var shader in shaders)
                GL.AttachShader(Program, shader);

            GL.LinkProgram(Program);
            GL.GetProgram(Program, ProgramPropertyARB.LinkStatus, out var success);
            if (success == 0)
            {
                var info = GL.GetProgramInfoLog(Program);
                Console.WriteLine($"GL.LinkProgram had info log [{name}]:\n{info}");
            }

            foreach (var shader in shaders)
            {
                GL.DetachShader(Program, shader);
                GL.DeleteShader(shader);
            }

            Initialized = true;

            return Program;
        }

        private uint CompileShader(string name, ShaderType type, string source)
        {
            var shader = GL.CreateShader(type);
            //GL.CreateShader(type, name, out var shader);
            GL.ShaderSource(shader, source);
            GL.CompileShader(shader);
            GL.GetShader(shader, ShaderParameterName.CompileStatus, out var success);
            if (success == 0)
            {
                var info = GL.GetShaderInfoLog(shader);
                Console.WriteLine($"GL.CompileShader for shader '{Name}' [{type}] had info log:\n{info}");
            }

            return shader;
        }
    }

    internal static class Util
    {
        public static float Clamp(float value, float min, float max) => value < min ? min : value > max ? max : value;

        [Conditional("DEBUG")]
        public static void CheckGLError(this GL gl, string title)
        {
            var error = gl.GetError();
            if (error != GLEnum.NoError)
                Console.WriteLine($"{title}: {error}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void LabelObject(this GL gl, ObjectIdentifier objLabelIdent, uint glObject, string name) =>
            gl.ObjectLabel(objLabelIdent, glObject, (uint)name.Length, name);
        //gl.ObjectLabel(objLabelIdent, glObject, name.Length, name);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateTexture(this GL gl, TextureTarget target, string name, out uint texture)
        {
            gl.CreateTextures(target, 1, out texture);
            gl.LabelObject(ObjectIdentifier.Texture, texture, $"Texture: {name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateProgram(this GL gl, string name, out uint program)
        {
            program = gl.CreateProgram();
            gl.LabelObject(ObjectIdentifier.Program, program, $"Program: {name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateShader(this GL gl, ShaderType type, string name, out uint shader)
        {
            shader = gl.CreateShader(type);
            gl.LabelObject(ObjectIdentifier.Shader, shader, $"Shader: {type}: {name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateBuffer(this GL gl, string name, out uint buffer)
        {
            gl.CreateBuffers(1, out buffer);
            gl.LabelObject(ObjectIdentifier.Buffer, buffer, $"Buffer: {name}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateVertexBuffer(this GL gl, string name, out uint buffer) => gl.CreateBuffer($"VBO: {name}", out buffer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateElementBuffer(this GL gl, string name, out uint buffer) => gl.CreateBuffer($"EBO: {name}", out buffer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CreateVertexArray(this GL gl, string name, out uint vao)
        {
            gl.CreateVertexArrays(1, out vao);
            gl.LabelObject(ObjectIdentifier.VertexArray, vao, $"VAO: {name}");
        }
    }
}
