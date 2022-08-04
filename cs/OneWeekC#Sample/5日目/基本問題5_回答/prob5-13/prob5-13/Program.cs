using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 3];
            int max = 0, min = 9;
            Random rand = new Random();

            for(int i = 0; i < data.GetLength(0); i++)
            {
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rand.Next(0, 10);
                    Console.Write("{0} ", data[i, j]);

                    if(max  < data[i, j])
                    {
                        max = data[i, j];
                    }
                    if(min > data[i, j])
                    {
                        min = data[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("最大値：{0}", max);
            Console.WriteLine("最小値：{0}", min);
        }
    }
}
