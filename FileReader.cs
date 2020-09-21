using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler13
{
    public class FileReader
    {
        private const string LineBreak = "<br />";
        private const string FilePath = "../../Numbers.txt";

        public List<string> ToList()
        {
            var result = new List<string>();

            using (StreamReader sr = new StreamReader(FilePath))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    line = line.TrimEnd(LineBreak.ToArray());
                    result.Add(line);
                }
            }

            return result;
        }
    }
}
