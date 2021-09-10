using System;

namespace Gwi.OpenGL.BindingGenerator.Utils
{
    internal static class ArrayExtensions
    {
        public static T[] MakeCopyAndGrow<T>(this T[] array, int additionalElements)
        {
            var newArray = new T[array.Length + additionalElements];
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }
    }
}
