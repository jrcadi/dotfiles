using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise303
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    Console.WriteLine("TWO");
                    break;
                case 3:
                    Console.WriteLine("THREE");
                    break;
                default:
                    Console.WriteLine("範囲外");
                    break;
            }
        }
    }
}
