using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler13
{
    public class Algorithm
    {
        private const int ResultLength = 10;

        public string Run(List<string> list)
        {
            string result = string.Empty;

            while (list.Any())
            {
                var builder = new StringBuilder();
                result = builder.Append(SummarizeEndChars(ref list))
                                .Append(result)
                                .ToString(0, Math.Min(builder.Length, ResultLength));
            }

            return result;
        }

        private string SummarizeEndChars(ref List<string> input)
        {
            var output = new List<string>();
            int intResult = 0;

            foreach (string row in input)
            {
                intResult += row[row.Length - 1].ToString().ToNumber();
                output.AddIfNotEmpty(row.Remove(row.Length - 1));
            }

            string result = intResult.ToString();
            output.AddIfNotEmpty(result.Remove(result.Length - 1));
            
            input = output;
            return result.Last().ToString();
        }
    }
}
