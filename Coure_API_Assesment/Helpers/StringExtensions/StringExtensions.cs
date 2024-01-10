using System.Collections.Generic;
using System.Linq;

namespace Coure_API_Assesment.Helpers.StringExtensions
{
    public static class StringExtensions
    {
        public static string ToDictionaryString<TKey, TValue>(this IDictionary<TKey, TValue> dictionary) where TKey : class where TValue : class
        {
            return $"{{ {string.Join(", ", dictionary.Select(kv => kv.Key + " = " + kv.Value).ToArray())} }}";
        }
    }
}
