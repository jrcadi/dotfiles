using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[100];

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = 1;
            }

            for(int i = 2; i < Math.Sqrt(data.Length); i++)
            {
                if(data[i] == 1)
                {
                    for(int j = 0; i * (j + 2) < data.Length; j++)
                    {
                        data[i * (j + 2)] = 0;
                    }
                }
            }

            for (int i = 2; i < data.Length; i++)
            {
                if(data[i] == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
