using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int num = int.Parse(Console.ReadLine());
            //  forループを使って約数を表示する
            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
