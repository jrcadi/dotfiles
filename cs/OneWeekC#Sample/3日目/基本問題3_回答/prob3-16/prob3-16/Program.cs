using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力：");
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0 && n % 3 == 0)
            {
                Console.WriteLine("2と3の公倍数です。");
            }
            else if(n % 2 == 0)
            {
                Console.WriteLine("2の倍数です。");
            }
            else if(n % 3 == 0)
            {
                Console.WriteLine("3の倍数です。");
            }
        }
    }
}
