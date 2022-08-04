using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力：");
            int n = int.Parse(Console.ReadLine());

            if (n < 50)
            {
                Console.WriteLine("50未満です");
            }
        }
    }
}
