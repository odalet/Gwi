using Gwi.OpenGL;

namespace GlfwTestApp
{
    internal static class TriangleBuilder
    {
        private const string vert = @"
#version 330 core

layout (location = 0) in vec3 position;
layout (location = 1) in vec3 color;

out vec3 vertexColor;

uniform float rotation;
uniform vec2 translation;

void main()
{
	vec2 rotated_pos;
	rotated_pos.x = translation.x + position.x*cos(rotation) - position.y*sin(rotation);
	rotated_pos.y = translation.y + position.x*sin(rotation) + position.y*cos(rotation);
    gl_Position = vec4(rotated_pos.x, rotated_pos.y, position.z, 1.0);
	vertexColor = color;
}
";

        private const string frag = @"
#version 330 core

out vec4 FragColor;

in vec3 vertexColor;
uniform vec3 color;

void main()
{		
	FragColor = vec4(color * vertexColor, 1.0);
	//FragColor = vec4(vertexColor, 1.0);
}
";
        
        public static Shader CreateTriangleShader(GL gl) => new(gl, "Triangle", vert, frag);

        public static unsafe void CreateTriangleGeometry(GL gl, out uint vbo, out uint vao, out uint ebo)
        {
            // create the triangle
            var vertices = new float[]
            {
                0.0f, 0.25f, 0.0f,	// position vertex 1
		        1.0f, 0.0f, 0.0f,	 // color vertex 1
		        0.25f, -0.25f, 0.0f,  // position vertex 2
		        0.0f, 1.0f, 0.0f,	 // color vertex 2
		        -0.25f, -0.25f, 0.0f, // position vertex 3
		        0.0f, 0.0f, 1.0f,	 // color vertex 3
	        };

            var indices = new uint[] { 0, 1, 2 };

            fixed (void* verticesPtr = &vertices[0])
            fixed (void* indicesPtr = &indices[0])
            {
                vao = gl.GenVertexArray();
                vbo = gl.GenBuffer();
                ebo = gl.GenBuffer();
                gl.BindVertexArray(vao);

                gl.BindBuffer(BufferTargetArb.ArrayBuffer, vbo);
                gl.BufferData(BufferTargetArb.ArrayBuffer, sizeof(float) * vertices.Length, verticesPtr, BufferUsageArb.StaticDraw);

                gl.BindBuffer(BufferTargetArb.ElementArrayBuffer, ebo);
                gl.BufferData(BufferTargetArb.ElementArrayBuffer, sizeof(uint) * indices.Length, indicesPtr, BufferUsageArb.StaticDraw);

                // Positions
                gl.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 0);
                gl.EnableVertexAttribArray(0);

                // Colors
                gl.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 3 * sizeof(float));
                gl.EnableVertexAttribArray(1);

                gl.BindBuffer(BufferTargetArb.ArrayBuffer, 0u);
                gl.BindVertexArray(0u);
            }
        }
    }
}
