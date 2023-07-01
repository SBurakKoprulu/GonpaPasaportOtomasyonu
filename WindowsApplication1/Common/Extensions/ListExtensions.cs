using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonpaPasaportOtomasyonu.Common.Extensions
{
    public static class ListExtensions
    {
        public static IEnumerable<List<T>> SplitPartition<T>(this List<T> values, int chunkSize)
        {
            for (int i = 0; i < values.Count; i += chunkSize)
            {
                yield return values.GetRange(i, Math.Min(chunkSize, values.Count - i));
            }
        }
    }
}
