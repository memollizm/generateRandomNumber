using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double num = random.NextDouble();
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
