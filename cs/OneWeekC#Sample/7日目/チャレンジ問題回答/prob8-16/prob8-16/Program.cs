using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            Random rand = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(1, 101);
            }

            for(int i = 0; i < data.Length; i++)
            {
                for (int j = i; j < data.Length; j++)
                {
                    if(data[i] < data[j])
                    {
                        int tmp = data[i];
                        data[i] = data[j];
                        data[j] = tmp;
                    }
                }
            }

            for(int i = 0; i < data.Length; i++)
            {
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();
        }
    }
}
