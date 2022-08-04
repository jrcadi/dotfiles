using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 3];
            Random rand = new Random();

            for(int i = 0; i < data.GetLength(0); i++)
            {
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rand.Next(0, 10);
                    Console.Write("{0} ", data[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
