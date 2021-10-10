using System;

namespace Gwi.OpenGL
{
    public static unsafe class GLExtensions
    {
        // Misc

        public static void Clear(this GL gl, ClearBufferMask mask) => gl.Api.glClear((uint)mask);
        public static void ClearColor(this GL gl, float red, float green, float blue, float alpha) => gl.Api.glClearColor(red, green, blue, alpha);

        public static unsafe string? GetString(this GL gl, StringName name)
        {
            var ptr = gl.Api.glGetString((uint)name);
            return Marshalling.PtrToString((nint)ptr);
        }

        public static unsafe string? GetString(this GL gl, StringName name, int index)
        {
            var ptr = gl.Api.glGetStringi((uint)name, (uint)index);
            return Marshalling.PtrToString((nint)ptr);
        }

        public static ErrorCode GetError(this GL gl) => (ErrorCode)gl.Api.glGetError();

        public static void DrawElements(this GL gl, PrimitiveType mode, int count, DrawElementsType type, nint indices) => DrawElements(gl, mode, count, type, (void*)indices);
        public static void DrawElements(this GL gl, PrimitiveType mode, int count, DrawElementsType type, void* indices) =>
            gl.Api.glDrawElements((uint)mode, count, (uint)type, indices);

        // Shaders

        public static uint CreateProgram(this GL gl) => gl.Api.glCreateProgram();
        public static uint CreateShader(this GL gl, ShaderType type) => gl.Api.glCreateShader((uint)type);

        public static void ShaderSource(this GL gl, uint shader, string source)
        {
            var length = source.Length;
            var strings = new string[] { source };
            var ptr = (byte**)Marshalling.StringArrayToPtr(strings);
            gl.Api.glShaderSource(shader, 1, ptr, &length);
            Marshalling.CopyPtrToStringArray((nint)ptr, strings);
            _ = Marshalling.Free((nint)ptr);
        }

        public static int GetShader(this GL gl, uint shader, ShaderParameterName parameterName)
        {
            var result = 0;
            gl.Api.glGetShaderiv(shader, (uint)parameterName, &result);
            return result;
        }

        public static string GetShaderInfoLog(this GL gl, uint shader)
        {
            var logLength = GetShader(gl, shader, ShaderParameterName.InfoLogLength);
            if (logLength <= 0) return string.Empty;

            var bufSize = logLength * 2; // To be on the safe side
            var length = 0;
            var ptr = (byte*)Marshalling.AllocateString(bufSize);
            try
            {
                gl.Api.glGetShaderInfoLog(shader, bufSize, &length, ptr);
                return Marshalling.PtrToString((nint)ptr) ?? "";
            }
            finally { Marshalling.FreeString((nint)ptr); }
        }

        public static void CompileShader(this GL gl, uint shader) => gl.Api.glCompileShader(shader);

        public static void AttachShader(this GL gl, uint program, uint shader) => gl.Api.glAttachShader(program, shader);
        public static void DetachShader(this GL gl, uint program, uint shader) => gl.Api.glDetachShader(program, shader);

        public static void LinkProgram(this GL gl, uint program) => gl.Api.glLinkProgram(program);
        public static void UseProgram(this GL gl, uint program) => gl.Api.glUseProgram(program);

        public static int GetProgram(this GL gl, uint program, ProgramPropertyArb parameterName)
        {
            var result = 0;
            gl.Api.glGetProgramiv(program, (uint)parameterName, &result);
            return result;
        }

        public static string GetProgramInfoLog(this GL gl, uint shader)
        {
            var logLength = GetProgram(gl, shader, ProgramPropertyArb.InfoLogLength);
            if (logLength <= 0) return string.Empty;

            var bufSize = logLength * 2; // To be on the safe side
            var length = 0;
            var ptr = (byte*)Marshalling.AllocateString(bufSize);
            try
            {
                gl.Api.glGetProgramInfoLog(shader, bufSize, &length, ptr);
                return Marshalling.PtrToString((nint)ptr) ?? "";
            }
            finally { Marshalling.FreeString((nint)ptr); }
        }

        public static void DeleteProgram(this GL gl, uint program) => gl.Api.glDeleteProgram(program);
        public static void DeleteShader(this GL gl, uint shader) => gl.Api.glDeleteShader(shader);

        public static void Uniform1(this GL gl, int location, int value) => gl.Api.glUniform1i(location, value);
        public static void Uniform1(this GL gl, int location, float value) => gl.Api.glUniform1f(location, value);
        public static void Uniform1(this GL gl, int location, double value) => gl.Api.glUniform1d(location, value);
        
        public static void Uniform2(this GL gl, int location, int v0, int v1) => gl.Api.glUniform2i(location, v0, v1);
        public static void Uniform2(this GL gl, int location, float v0, float v1) => gl.Api.glUniform2f(location, v0, v1);
        public static void Uniform2(this GL gl, int location, double v0, double v1) => gl.Api.glUniform2d(location, v0, v1);

        public static void Uniform3(this GL gl, int location, int v0, int v1, int v2) => gl.Api.glUniform3i(location, v0, v1, v2);
        public static void Uniform3(this GL gl, int location, float v0, float v1, float v2) => gl.Api.glUniform3f(location, v0, v1, v2);
        public static void Uniform3(this GL gl, int location, double v0, double v1, double v2) => gl.Api.glUniform3d(location, v0, v1, v2);

        public static void Uniform4(this GL gl, int location, int v0, int v1, int v2, int v3) => gl.Api.glUniform4i(location, v0, v1, v2, v3);
        public static void Uniform4(this GL gl, int location, float v0, float v1, float v2, float v3) => gl.Api.glUniform4f(location, v0, v1, v2, v3);
        public static void Uniform4(this GL gl, int location, double v0, double v1, double v2, double v3) => gl.Api.glUniform4d(location, v0, v1, v2, v3);

        public static string GetActiveUniform(this GL gl, uint program, int index, out int size, out UniformType type)
        {
            var maxLength = GetProgram(gl, program, ProgramPropertyArb.ActiveUniformMaxLength);
            var bufSize = maxLength == 0 ? 1 : maxLength;

            var typeValue = 0u;
            var nameLength = 0;
            fixed (int* sizePtr = &size)
            {
                var namePtr = (byte*)Marshalling.AllocateString(bufSize);
                gl.Api.glGetActiveUniform(program, (uint)index, bufSize, &nameLength, sizePtr, &typeValue, namePtr);

                type = (UniformType)typeValue;

                var name = Marshalling.PtrToString((nint)namePtr) ?? "";
                Marshalling.FreeString((nint)namePtr);

                return name.Substring(0, nameLength);
            }
        }

        public static int GetUniformLocation(this GL gl, uint program, string name)
        {
            var namePtr = (byte*)Marshalling.StringToPtr(name);
            try
            {
                return gl.Api.glGetUniformLocation(program, namePtr);
            }
            finally { Marshalling.FreeString((nint)namePtr); }
        }

        // VAO, VBO ...

        public static uint GenVertexArray(this GL gl) // Generates only 1 VAO
        {
            uint array;
            gl.Api.glGenVertexArrays(1, &array);
            return array;
        }

        public static void BindVertexArray(this GL gl, uint array) => gl.Api.glBindVertexArray(array);
        public static void EnableVertexAttribArray(this GL gl, int index) => gl.Api.glEnableVertexAttribArray((uint)index);

        public static void VertexAttribPointer(this GL gl, int index, int size, VertexAttribPointerType type, bool normalized, int stride, nint pointer) =>
            VertexAttribPointer(gl, index, size, type, normalized, stride, (void*)pointer);
        public static void VertexAttribPointer(this GL gl, int index, int size, VertexAttribPointerType type, bool normalized, int stride, void* pointer) => 
            gl.Api.glVertexAttribPointer((uint)index, size, (uint)type, (byte)(normalized ? 1 : 0), stride, pointer);

        public static uint GenBuffer(this GL gl) // Generates only 1 Buffer Object
        {
            uint buffer;
            gl.Api.glGenBuffers(1, &buffer);
            return buffer;
        }

        public static void BindBuffer(this GL gl, BufferTargetArb target, uint buffer) => gl.Api.glBindBuffer((uint)target, buffer);
        
        public static void BufferData(this GL gl, BufferTargetArb target, int size, nint data, BufferUsageArb usage) => BufferData(gl, target, size, (void*)data, usage);
        public static void BufferData(this GL gl, BufferTargetArb target, int size, void* data, BufferUsageArb usage) => gl.Api.glBufferData((uint)target, size, data, (uint)usage);
    }
}
