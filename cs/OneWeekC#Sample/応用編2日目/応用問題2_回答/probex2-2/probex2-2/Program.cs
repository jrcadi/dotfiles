using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex2_2
{
    class Program
    {
        static int Mul(int a, int b, int c)
        {
            return a * b * c;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int a = r.Next(1, 11);
            int b = r.Next(1, 11);
            int c = r.Next(1, 11);
            int result = Mul(a, b, c);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("a * b * c = {0}", result);
        }
    }
}
