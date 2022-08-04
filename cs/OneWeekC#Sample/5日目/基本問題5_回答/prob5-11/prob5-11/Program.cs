using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            Random rand = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(1, 101);
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("0以上60未満：");
            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 0 && data[i] < 60)
                {
                    Console.Write("{0} ", data[i]);
                }
            }
            Console.WriteLine();

            Console.Write("60以上80未満：");
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 60 && data[i] < 80)
                {
                    Console.Write("{0} ", data[i]);
                }
            }
            Console.WriteLine();

            Console.Write("80以上：");
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 80)
                {
                    Console.Write("{0} ", data[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
