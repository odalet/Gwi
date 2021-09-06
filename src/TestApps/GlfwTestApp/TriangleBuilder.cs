////using Gwi.OpenGL;
////using Gwi.OpenGL.GL4;

////namespace GlfwTestApp
////{
////    internal static class TriangleBuilder
////    {
////        public static void CreateTriangle(GL gl, ref BufferHandle vbo, ref VertexArrayHandle vao, ref BufferHandle ebo)
////        {
////            // create the triangle
////            var triangle_vertices = new float[]
////            {
////                0.0f, 0.25f, 0.0f,	// position vertex 1
////		        1.0f, 0.0f, 0.0f,	 // color vertex 1
////		        0.25f, -0.25f, 0.0f,  // position vertex 1
////		        0.0f, 1.0f, 0.0f,	 // color vertex 1
////		        -0.25f, -0.25f, 0.0f, // position vertex 1
////		        0.0f, 0.0f, 1.0f,	 // color vertex 1
////	        };

////            var triangle_indices = new uint[] { 0, 1, 2 };

////            gl.GenVertexArrays(1, ref vao);
////            gl.GenBuffers(1, ref vbo);
////            gl.GenBuffers(1, ref ebo);
////            gl.BindVertexArray(vao);
////            gl.BindBuffer(BufferTargetARB.ArrayBuffer, vbo);
////            //gl.BufferData(BufferTargetARB.ArrayBuffer, new UIntPtr((uint)(sizeof(float) * triangle_vertices.Length)), vertices, BufferUsageHint.StaticDraw);
////            gl.BufferData(BufferTargetARB.ArrayBuffer, triangle_vertices, BufferUsageARB.StaticDraw);
////            gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, ebo);
////            //gl.BufferData(BufferTargetARB.ElementArrayBuffer, new UIntPtr((uint)(sizeof(uint) * triangle_indices.Length)), indices, BufferUsageHint.StaticDraw);
////            //gl.BufferData(BufferTargetARB.ElementArrayBuffer, sizeof(uint) * triangle_indices.Length, triangle_indices, BufferUsageARB.StaticDraw);
////            gl.BufferData(BufferTargetARB.ElementArrayBuffer, triangle_indices, BufferUsageARB.StaticDraw);

////            // Positions
////            gl.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 0);
////            gl.EnableVertexAttribArray(0);

////            // Colors
////            gl.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 3 * sizeof(float));
////            gl.EnableVertexAttribArray(1);

////            gl.BindBuffer(BufferTargetARB.ArrayBuffer, BufferHandle.Zero);
////            gl.BindVertexArray(VertexArrayHandle.Zero);
////        }
////    }
////}
