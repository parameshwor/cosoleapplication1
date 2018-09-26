using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 6;
            double sum = Add(a, b);
            Console.WriteLine(sum);

        }
        static double Add (double a, double b)
        {
            return (a + b);
        }
    }
}
