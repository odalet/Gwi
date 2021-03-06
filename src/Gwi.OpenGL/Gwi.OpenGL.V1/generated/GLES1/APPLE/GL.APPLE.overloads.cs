// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gwi.OpenGL.GLES1
{
#pragma warning disable IDE1006 // Naming Styles

    public static class APPLEOverloads
    {
        // GetInteger64vAPPLE overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetInteger64vAPPLE(this GL.APPLEExtension glInstance, GetPName pname, ref long parameters)
        {
            fixed (long* parameters_ptr = &parameters) // RefInsteadOfPointerLayer
            {
                glInstance.GetInteger64vAPPLE(pname, parameters_ptr);
            }
        }

        // GetSyncivAPPLE overloads

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetSyncivAPPLE(this GL.APPLEExtension glInstance, GLSync sync, SyncParameterName pname, ref int length, Span<int> values)
        {
            fixed (int* length_ptr = &length) // RefInsteadOfPointerLayer
            {
                var count = (int)(values.Length);
                fixed (int* values_ptr = values) // SpanOrArrayLayer
                {
                    glInstance.GetSyncivAPPLE(sync, pname, count, length_ptr, values_ptr);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetSyncivAPPLE(this GL.APPLEExtension glInstance, GLSync sync, SyncParameterName pname, ref int length, int[] values)
        {
            fixed (int* length_ptr = &length) // RefInsteadOfPointerLayer
            {
                var count = (int)(values.Length);
                fixed (int* values_ptr = values) // SpanOrArrayLayer
                {
                    glInstance.GetSyncivAPPLE(sync, pname, count, length_ptr, values_ptr);
                }
            }
        }

        // Generated by Gwi.OpenGL.BindingGenerator.Parsing.RefInsteadOfPointerOverloader
        public static unsafe void GetSyncivAPPLE(this GL.APPLEExtension glInstance, GLSync sync, SyncParameterName pname, int count, ref int length, ref int values)
        {
            fixed (int* length_ptr = &length) // RefInsteadOfPointerLayer
            fixed (int* values_ptr = &values) // RefInsteadOfPointerLayer
            {
                glInstance.GetSyncivAPPLE(sync, pname, count, length_ptr, values_ptr);
            }
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
