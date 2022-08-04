using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("温度を入力してください(-10～35)：");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("摂氏{0}度", n);

            if (n < -10 || n > 35)
            {
                Console.WriteLine("適切な値を入力してください。");
            }
            else if(n >= 30)
            {
                Console.WriteLine("真夏日です。");
            }
            else if(n >= 25 && n < 30)
            {
                Console.WriteLine("夏日です。");
            }
            else if(n < 0)
            {
                Console.WriteLine("真冬日です。");
            }
        }
    }
}
