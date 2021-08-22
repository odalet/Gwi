using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator.Utils
{
    internal static class Extensions
    {
        public static void AddToNestedDict<TKey1, TKey2, TValue>(this IDictionary<TKey1, Dictionary<TKey2, TValue>> dict, TKey1 key1, TKey2 key2, TValue value)
            where TKey1 : notnull
            where TKey2 : notnull
        {
            if (!dict.TryGetValue(key1, out var nestedDict))
            {
                nestedDict = new Dictionary<TKey2, TValue>();
                dict.Add(key1, nestedDict);
            }

            nestedDict.Add(key2, value);
        }
    }
}
