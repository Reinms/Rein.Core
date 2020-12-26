namespace InitGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal static class LinqXtn
    {
        public static IEnumerable<TTo> SelectWhere<TFrom, TTo>(this IEnumerable<TFrom> from, Func<TFrom, TTo?> fn) => from.Select(fn).Where(NotNull);
        public static Boolean NotNull<T>(this T input) => input is not null;
    }
}
