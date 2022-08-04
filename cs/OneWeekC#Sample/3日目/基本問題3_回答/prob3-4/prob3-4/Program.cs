using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力：");
            int n = int.Parse(Console.ReadLine());

            if(n <= 20 || 80 <= n)
            {
                Console.WriteLine("20以下か80以上の値です");
            }
        }
    }
}
