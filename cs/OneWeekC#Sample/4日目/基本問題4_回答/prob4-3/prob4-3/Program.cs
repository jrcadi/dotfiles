using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数：");
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            do
            {
                Console.Write("■");
                i++;
            } while (i < n);

            Console.WriteLine();
        }
    }
}
