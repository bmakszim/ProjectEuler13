using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler13
{
    class Program
    {
        static void Main(string[] args)
        {

            var alg = new Algorithm();
            var reader = new FileReader();
            string result = alg.Run(reader.ToList());

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
