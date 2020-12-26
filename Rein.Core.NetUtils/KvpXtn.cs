namespace Rein.Core.NetUtils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Reflection;

    public static class KvpXtn
    {
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> kvp, out TKey a, out TValue b) => (a, b) = (kvp.Key, kvp.Value);
        public static (TKey key, TValue value) Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> kvp) => (kvp.Key, kvp.Value);
    }
}
