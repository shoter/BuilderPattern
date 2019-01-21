using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public static class IListExtensions
    {
        public static List<T> Clone<T>(this List<T> list)
        {
            return list.GetRange(0, list.Count);
        }
    }
}
