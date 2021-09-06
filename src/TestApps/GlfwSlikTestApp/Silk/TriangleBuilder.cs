using Silk.NET.OpenGL;

namespace GlfwSlikTestApp.Silk
{
    internal static class TriangleBuilder
    {
        public static unsafe void CreateTriangle(GL gl, out uint vbo, out uint vao, out uint ebo)
        {
            // create the triangle
            var triangle_vertices = new float[]
            {
                0.0f, 0.25f, 0.0f,	// position vertex 1
		        1.0f, 0.0f, 0.0f,	 // color vertex 1
		        0.25f, -0.25f, 0.0f,  // position vertex 2
		        0.0f, 1.0f, 0.0f,	 // color vertex 2
		        -0.25f, -0.25f, 0.0f, // position vertex 3
		        0.0f, 0.0f, 1.0f,	 // color vertex 3
	        };

            var triangle_indices = new uint[] { 0, 1, 2 };

            fixed (void* vertices_ptr = &triangle_vertices[0])
            fixed (void* indices_ptr = &triangle_indices[0])
            {
                gl.GenVertexArrays(1, out vao);
                gl.GenBuffers(1, out vbo);
                gl.GenBuffers(1, out ebo);
                gl.BindVertexArray(vao);
                
                gl.BindBuffer(BufferTargetARB.ArrayBuffer, vbo);
                gl.BufferData(BufferTargetARB.ArrayBuffer, (uint)(sizeof(float) * triangle_vertices.Length), vertices_ptr, BufferUsageARB.StaticDraw);
                
                gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, ebo);
                gl.BufferData(BufferTargetARB.ElementArrayBuffer, (uint)(sizeof(uint) * triangle_indices.Length), indices_ptr, BufferUsageARB.StaticDraw);

                // Positions
                gl.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), (void*)0);
                gl.EnableVertexAttribArray(0);

                // Colors
                gl.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), (void*)(3 * sizeof(float)));
                gl.EnableVertexAttribArray(1);

                gl.BindBuffer(BufferTargetARB.ArrayBuffer, 0u);
                gl.BindVertexArray(0u);
            }
        }
    }
}
