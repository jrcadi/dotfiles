using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            int[] odd = new int[10];
            int[] even = new int[10];

            Random rand = new Random();

            for(int i = 0; i < 10; i++)
            {
                data[i] = rand.Next(1, 101);
                Console.Write("{0} ", data[i]);
                if (data[i] % 2 == 0)
                {
                    even[i] = data[i];
                    odd[i] = 0;
                }
                else
                {
                    even[i] = 0;
                    odd[i] = data[i];
                }
            }

            Console.WriteLine();
            Console.Write("偶数：");
            for(int i = 0; i < 10; i++)
            {
                if (odd[i] != 0)
                {
                    Console.Write("{0} ", odd[i]);
                }
            }

            Console.WriteLine();
            Console.Write("奇数：");
            for (int i = 0; i < 10; i++)
            {
                if (even[i] != 0)
                {
                    Console.Write("{0} ", even[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
