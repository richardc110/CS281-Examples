using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double a = 1.2;
            double b = 1.7;
            double c = 2.9;

            Console.WriteLine(a + b == c);
            if (Math.Abs(a + b - c) < 1.0e-15)
            {
                Console.WriteLine("對了");
            }
            else
            {
                Console.WriteLine("錯了");
            }
        }
    }
}