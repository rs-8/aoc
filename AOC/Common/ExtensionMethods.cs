using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Common
{
    public static class ExtensionMethods
    {
        public static bool IsBetween(this int x, int min, int max) => min <= x && x <= max; 

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
            return enumerable;
        }

        public static bool IsNotEmpty<T>(this List<T> list) => list.Count > 0;
    }
}