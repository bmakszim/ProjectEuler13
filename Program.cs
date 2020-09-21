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
            var parser = new FileReader();
            string result = alg.Run(parser.ToList());

            //var r = new Parser().ToList();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
