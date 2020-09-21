using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler13
{
    public static class Extensions
    {
        public static int ToNumber(this string c)
        {
            return Convert.ToInt32(c);
        }

        public static void AddIfNotEmpty(this IList<string> list, string element)
        {
            if (!string.IsNullOrWhiteSpace(element))
            {
                list.Add(element);
            }
        }
    }
}
