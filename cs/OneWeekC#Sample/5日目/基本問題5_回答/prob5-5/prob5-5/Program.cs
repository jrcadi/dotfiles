using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            Random rand = new Random();

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(1, 11);
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("3の倍数:");
            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] % 3 == 0)
                {
                    Console.Write("{0} ", data[i]);
                }
            }
            Console.WriteLine();

            Console.Write("3の倍数以外の数:");
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 3 != 0)
                {
                    Console.Write("{0} ", data[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
