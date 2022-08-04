using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力：");
            int n = int.Parse(Console.ReadLine());

            if(n != 4)
            {
                Console.WriteLine("4ではありません");
            }
        }
    }
}
