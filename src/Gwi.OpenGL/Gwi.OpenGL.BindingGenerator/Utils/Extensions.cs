using System.Collections.Generic;

namespace Gwi.OpenGL.BindingGenerator.Utils
{
    internal static class Extensions
    {
        public static void Add<TKey1, TKey2, TValue>(this IDictionary<TKey1, Dictionary<TKey2, TValue>> dict, TKey1 key1, TKey2 key2, TValue value)
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

        public static void Add<TKey, TValue>(this IDictionary<TKey, HashSet<TValue>> dict, TKey key, TValue value) where TKey : notnull
        {
            if (dict.TryGetValue(key, out var nestedCollection) == false)
            {
                nestedCollection = new HashSet<TValue>();
                dict.Add(key, nestedCollection);
            }

            _ = nestedCollection.Add(value);
        }
    }
}
