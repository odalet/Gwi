////using System;
////using System.Collections.Generic;
////using System.Diagnostics;
////using System.Runtime.CompilerServices;
////using Gwi.OpenGL;
////using Gwi.OpenGL.GL4;

////namespace GlfwTestApp
////{
////    struct UniformFieldInfo
////    {
////        public int Location;
////        public string Name;
////        public int Size;
////        public UniformType Type;
////    }

////    internal abstract class Shader
////    {
////        public readonly string Name;

////        private readonly Dictionary<string, int> UniformToLocation = new Dictionary<string, int>();
////        private bool Initialized = false;

////        private readonly (ShaderType Type, string Path)[] Files;

////        protected Shader(GL gl, string name, string vertexShader, string fragmentShader)
////        {
////            GL = gl ?? throw new ArgumentNullException(nameof(gl));
////            Name = name;
////            Files = new[]{
////                (ShaderType.VertexShader, vertexShader),
////                (ShaderType.FragmentShader, fragmentShader),
////            };
////            Program = CreateProgram(name, Files);
////        }

////        protected GL GL { get; }
////        public ProgramHandle Program { get; private set; }

////        public void UseShader() => GL.UseProgram(Program);

////        public void Dispose()
////        {
////            if (Initialized)
////            {
////                GL.DeleteProgram(Program);
////                Initialized = false;
////            }
////        }

////        public UniformFieldInfo[] GetUniforms()
////        {
////            GL.GetProgram(Program, GetProgramParameterName.ActiveUniforms, out int uniformCount);

////            var uniforms = new UniformFieldInfo[uniformCount];
////            for (var i = 0; i < uniformCount; i++)
////            {
////                var name = GL.GetActiveUniform(Program, i, out var size, out var type);

////                UniformFieldInfo FieldInfo;
////                FieldInfo.Location = GetUniformLocation(name);
////                FieldInfo.Name = name;
////                FieldInfo.Size = size;
////                FieldInfo.Type = type;

////                uniforms[i] = FieldInfo;
////            }

////            return uniforms;
////        }

////        [MethodImpl(MethodImplOptions.AggressiveInlining)]
////        public int GetUniformLocation(string uniform)
////        {
////            if (UniformToLocation.TryGetValue(uniform, out int location) == false)
////            {
////                location = GL.GetUniformLocation(Program, uniform);
////                UniformToLocation.Add(uniform, location);

////                if (location == -1)
////                {
////                    Debug.Print($"The uniform '{uniform}' does not exist in the shader '{Name}'!");
////                }
////            }

////            return location;
////        }

////        private ProgramHandle CreateProgram(string name, params (ShaderType Type, string source)[] code)
////        {
////            GL.CreateProgram(name, out var program);
////            Program = program;

////            var shaders = new ShaderHandle[code.Length];
////            for (var i = 0; i < code.Length; i++)
////                shaders[i] = CompileShader(name, code[i].Type, code[i].source);

////            foreach (var shader in shaders)
////                GL.AttachShader(Program, shader);

////            GL.LinkProgram(Program);

////            GL.GetProgram(Program, GetProgramParameterName.LinkStatus, out int Success);
////            if (Success == 0)
////            {
////                string Info = GL.GetProgramInfoLog(Program);
////                Debug.WriteLine($"GL.LinkProgram had info log [{name}]:\n{Info}");
////            }

////            foreach (var shader in shaders)
////            {
////                GL.DetachShader(Program, shader);
////                GL.DeleteShader(shader);
////            }

////            Initialized = true;

////            return Program;
////        }

////        private ShaderHandle CompileShader(string name, ShaderType type, string source)
////        {
////            GL.CreateShader(type, name, out var shader);
////            GL.ShaderSource(shader, source);
////            GL.CompileShader(shader);

////            var success = 0;
////            GL.GetShaderi(shader, ShaderParameterName.CompileStatus, ref success);
////            if (success == 0)
////            {
////                var info = GL.GetShaderInfoLog(shader);
////                Debug.WriteLine($"GL.CompileShader for shader '{Name}' [{type}] had info log:\n{info}");
////            }

////            return shader;
////        }
////    }

////    internal static class Util
////    {
////        public static float Clamp(float value, float min, float max) => value < min ? min : value > max ? max : value;

////        [Conditional("DEBUG")]
////        public static void CheckGLError(this GL gl, string title)
////        {
////            var error = gl.GetError();
////            if (error != ErrorCode.NoError)
////                Debug.Print($"{title}: {error}");
////        }

////        [MethodImpl(MethodImplOptions.AggressiveInlining)]
////        public static void LabelObject(this GL gl, ObjectIdentifier objLabelIdent, int glObject, string name) =>
////            gl.ObjectLabel(objLabelIdent, (uint)glObject, name.Length, name);

////        [MethodImpl(MethodImplOptions.AggressiveInlining)]
////        public static void CreateTexture(this GL gl, TextureTarget target, string name, out TextureHandle texture)
////        {
////            texture = new TextureHandle();
////            gl.CreateTextures(target, 1, ref texture);
////            gl.LabelObject(ObjectIdentifier.Texture, texture.Handle, $"Texture: {name}");
////        }

////        [MethodImpl(MethodImplOptions.AggressiveInlining)]
////        public static void CreateProgram(this GL gl, string name, out ProgramHandle program)
////        {
////            program = gl.CreateProgram();
////            gl.LabelObject(ObjectIdentifier.Program, program.Handle, $"Program: {name}");
////        }

////        [MethodImpl(MethodImplOptions.AggressiveInlining)]
////        public static void CreateShader(this GL gl, ShaderType type, string name, out ShaderHandle shader)
////        {
////            shader = gl.CreateShader(type);
////            gl.LabelObject(ObjectIdentifier.Shader, shader.Handle, $"Shader: {type}: {name}");
////        }

////        [MethodImpl(MethodImplOptions.AggressiveInlining)]
////        public static void CreateBuffer(this GL gl, string name, out BufferHandle buffer)
////        {
////            buffer = new BufferHandle();
////            gl.CreateBuffers(1, ref buffer);
////            gl.LabelObject(ObjectIdentifier.Buffer, buffer.Handle, $"Buffer: {name}");
////        }

////        [MethodImpl(MethodImplOptions.AggressiveInlining)]
////        public static void CreateVertexBuffer(this GL gl, string name, out BufferHandle buffer) => gl.CreateBuffer($"VBO: {name}", out buffer);

////        [MethodImpl(MethodImplOptions.AggressiveInlining)]
////        public static void CreateElementBuffer(this GL gl, string name, out BufferHandle buffer) => gl.CreateBuffer($"EBO: {name}", out buffer);

////        [MethodImpl(MethodImplOptions.AggressiveInlining)]
////        public static void CreateVertexArray(this GL gl, string name, out VertexArrayHandle vao)
////        {
////            vao = new VertexArrayHandle();
////            gl.CreateVertexArrays(1, ref vao);
////            gl.LabelObject(ObjectIdentifier.VertexArray, vao.Handle, $"VAO: {name}");
////        }
////    }
////}
