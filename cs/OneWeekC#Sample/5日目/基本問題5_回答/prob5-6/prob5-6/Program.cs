using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            int max = 0, min = 10, total = 0;
            Random rand = new Random();

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(1, 11);
                Console.Write("{0} ", data[i]);
                total += data[i];

                if(max < data[i])
                {
                    max = data[i];
                }
                if(min > data[i])
                {
                    min = data[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("最大値：{0}", max);
            Console.WriteLine("最小値：{0}", min);
            Console.WriteLine("平均値：{0}", total / data.Length);
        }
    }
}
