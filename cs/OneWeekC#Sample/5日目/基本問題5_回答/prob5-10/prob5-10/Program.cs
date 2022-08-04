using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[7];
            Random rand = new Random();

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(1, 11);
                Console.Write("{0} ", data[i]);
            }

            Console.WriteLine();

            for(int i = 0; i < data.Length; i++)
            {
                for(int j = 0; j < data[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
