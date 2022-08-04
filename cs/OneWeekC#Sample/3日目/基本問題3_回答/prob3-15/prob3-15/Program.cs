using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("点数(1-100):");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 100)
            {
                Console.WriteLine("範囲外");
            }
            else if (n >= 80)
            {
                Console.WriteLine("優");
            }
            else if (n < 80 && n >= 70)
            {
                Console.WriteLine("良");
            }
            else if (n < 70 && n >= 60)
            {
                Console.WriteLine("可");
            }
            else if(n < 60)
            {
                Console.WriteLine("不可");
            }
        }
    }
}
