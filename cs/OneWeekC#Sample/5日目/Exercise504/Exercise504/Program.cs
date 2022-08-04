using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise504
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[9, 9];
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <=9; j++)
                {
                    m[i - 1, j - 1] = i * j;
                }
            }
            //  九九の表を表示
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}*{1}={2} ", i, j, m[i - 1, j - 1]);
                }
                Console.WriteLine();
            }

        }
    }
}
