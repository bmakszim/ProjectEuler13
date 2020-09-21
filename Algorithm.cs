using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler13
{
    public class Algorithm
    {
        public string Run(List<string> list)
        {
            string result = string.Empty;

            while (list.Any())
            {
                result = SummarizeEndChars(ref list) + result;
            }

            if (result.Length > 10)
            {
                return result.Substring(0, 10);
            }
            return result;
        }

        public string SummarizeEndChars(ref List<string> input)
        {
            var output = new List<string>();
            int temp = 0;
            foreach (string row in input)
            {
                temp += row[row.Length - 1].ToString().ToNumber();
                string newRow = row.Remove(row.Length - 1);

                if (!string.IsNullOrWhiteSpace(newRow))
                {
                    output.Add(newRow);
                }
            }

            string result = temp.ToString();

            string newResult = result.Remove(result.Length - 1);

            if (!string.IsNullOrWhiteSpace(newResult))
            {
                output.Add(newResult);
            }

            input = output;

            return result[result.Length - 1].ToString();
        }

    }
}
