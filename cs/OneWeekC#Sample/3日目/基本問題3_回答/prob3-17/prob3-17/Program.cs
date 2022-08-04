using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力してください(1-100)：");
            int n = int.Parse(Console.ReadLine());

            if(n < 1 || n > 100)
            {
                Console.WriteLine("適切な値を入力してください。");
            }
            else if(n % 2 == 0 && n <= 50)
            {
                Console.WriteLine("50以下の偶数です。");
            }
            else if(n % 2 == 0)
            {
                Console.WriteLine("偶数です。");
            }
            else if(n <= 50)
            {
                Console.WriteLine("50以下です。");
            }
        }
    }
}
