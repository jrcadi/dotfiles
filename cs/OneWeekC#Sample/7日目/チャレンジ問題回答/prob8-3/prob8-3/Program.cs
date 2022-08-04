using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください：");
            int num = int.Parse(Console.ReadLine());

            int result = num;
            for (int i = 1; i < num; i++)
            {
                result *= i;
            }

            Console.WriteLine("{0}の階乗は{1}です", num, result);

        }
    }
}
