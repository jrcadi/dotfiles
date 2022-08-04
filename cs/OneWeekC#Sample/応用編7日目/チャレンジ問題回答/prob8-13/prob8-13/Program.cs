using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data1 = new int[10];
            int[] data2 = new int[10];
            int[] data3 = new int[10];
            int[] data4 = new int[10];
            Random rand = new Random();

            Console.Write("配列1：");
            for(int i = 0; i < 10; i++)
            {
                data1[i] = rand.Next(1, 11);
                Console.Write("{0} ", data1[i]);
            }
            Console.WriteLine();
            Console.Write("配列2：");
            for (int i = 0; i < 10; i++)
            {
                data2[i] = rand.Next(1, 11);
                Console.Write("{0} ", data2[i]);
            }
            Console.WriteLine();

            for(int i = 0; i < 10; i++)
            {
                int val1 = 0;
                int val2 = 0;

                for(int j = 0; j < 10; j++)
                {
                    if(data1[j] == i + 1)
                    {
                        val1 = 1;
                        break;
                    }
                }

                for (int j = 0; j < 10; j++)
                {
                    if (data2[j] == i + 1)
                    {
                        val2 = 1;
                        break;
                    }
                }

                if(val1 == 1 && val2 == 1)
                {
                    data3[i] = i + 1;
                    data4[i] = 0;
                }
                else if(val1 == 0 && val2 == 0)
                {
                    data4[i] = 0;
                    data3[i] = 0;
                }
                else
                {
                    data3[i] = 0;
                    data4[i] = i + 1;
                }
            }
            Console.WriteLine();
            Console.Write("共通の数:");
            for(int i = 0; i < 10; i++)
            {
                if(data3[i] != 0)
                {
                    Console.Write("{0} ", data3[i]);
                }
            }

            Console.WriteLine();
            Console.Write("どちらか入っている数：");
            for (int i = 0; i < 10; i++)
            {
                if (data4[i] != 0)
                {
                    Console.Write("{0} ", data4[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
