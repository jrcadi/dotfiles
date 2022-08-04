using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1, min = 100;
            Random rand = new System.Random();

            for (int i = 0; i < 5; i++)
            {
                int n = rand.Next(1, 101);
                Console.WriteLine(n);
                if(max < n)
                {
                    max = n;
                }
                if(min > n)
                {
                    min = n;
                }
            }
            Console.WriteLine("最大値：{0}", max);
            Console.WriteLine("最小値：{0}", min);

        }
    }
}
