using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler13
{
    public class FileReader
    {
        public List<string> ToList()
        {
            var result = new List<string>();

            using (StreamReader sr = new StreamReader("../../Numbers.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    line = line.TrimEnd('<', 'b', 'r', '/', '>', ' ');

                    result.Add(line);
                }
            }

            return result;
        }
    }

    public static class Extensions
    {
        public static int ToNumber(this string c)
        {
            return Convert.ToInt32(c);
        }
    }

}
