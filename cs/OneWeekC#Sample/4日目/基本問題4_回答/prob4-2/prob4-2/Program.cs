using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数：");
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            while(i < n)
            {
                Console.Write("■");
                i++;
            }
            Console.WriteLine();
        }
    }
}
