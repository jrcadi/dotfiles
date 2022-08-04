using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("0以上の数値を入力してください：");
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("終了します");
                    break;
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
