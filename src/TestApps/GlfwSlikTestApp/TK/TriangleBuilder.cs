using OpenTK.Graphics.OpenGL4;

namespace GlfwSlikTestApp.TK
{
    internal static class TriangleBuilder
    {
        public static void CreateTriangle(out uint vbo, out uint vao, out uint ebo)
        {
            // create the triangle
            var triangle_vertices = new float[]
            {
                0.0f, 0.25f, 0.0f,	// position vertex 1
		        1.0f, 0.0f, 0.0f,	 // color vertex 1
		        0.25f, -0.25f, 0.0f,  // position vertex 1
		        0.0f, 1.0f, 0.0f,	 // color vertex 1
		        -0.25f, -0.25f, 0.0f, // position vertex 1
		        0.0f, 0.0f, 1.0f,	 // color vertex 1
	        };

            var triangle_indices = new uint[] { 0, 1, 2 };

            GL.GenVertexArrays(1, out vao);
            GL.GenBuffers(1, out vbo);
            GL.GenBuffers(1, out ebo);
            GL.BindVertexArray(vao);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            //GL.BufferData(BufferTarget.ArrayBuffer, new UIntPtr((uint)(sizeof(float) * triangle_vertices.Length)), vertices, BufferUsageHint.StaticDraw);
            GL.BufferData(BufferTarget.ArrayBuffer, sizeof(float) * triangle_vertices.Length, triangle_vertices, BufferUsageHint.StaticDraw);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);
            //GL.BufferData(BufferTarget.ElementArrayBuffer, new UIntPtr((uint)(sizeof(uint) * triangle_indices.Length)), indices, BufferUsageHint.StaticDraw);
            GL.BufferData(BufferTarget.ElementArrayBuffer, sizeof(uint) * triangle_indices.Length, triangle_indices, BufferUsageHint.StaticDraw);

            // Positions
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);

            // Colors
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 3 * sizeof(float));
            GL.EnableVertexAttribArray(1);

            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindVertexArray(0);
        }
    }
}
