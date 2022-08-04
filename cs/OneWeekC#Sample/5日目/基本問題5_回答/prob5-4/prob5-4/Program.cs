using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            Random rand = new Random();

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(1, 101);
                Console.Write("{0} ", data[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("50以上の数:");
            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 50)
                {
                    Console.Write("{0} ", data[i]);
                }
            }
            Console.WriteLine();

            Console.Write("50未満の数:");
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 50)
                {
                    Console.Write("{0} ", data[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
