namespace Rein.Core.NetUtils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public static class DictionaryXtn
    {
        public static IEnumerable<(TKey key, TValue value)> AsPairs<TKey, TValue>(this IDictionary<TKey, TValue> dict) => dict.Select(KvpXtn.Deconstruct);
    }
}
