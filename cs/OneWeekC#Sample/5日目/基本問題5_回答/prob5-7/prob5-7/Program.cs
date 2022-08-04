using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            int total = 0, avg = 0;
            Random rand = new Random();

            for (int i = 0; i < data.Length; i ++)
            {
                data[i] = rand.Next(1, 11);
                Console.Write("{0} ", data[i]);
                total += data[i];
            }

            Console.WriteLine();
            Console.WriteLine();

            avg = total / data.Length;
            Console.WriteLine("合計値：{0}", total);
            Console.WriteLine("平均値：{0}", avg);
            Console.WriteLine();

            Console.Write("平均値より大きい数：");
            for(int i = 0; i < data.Length; i++)
            {
                if(avg < data[i])
                {
                    Console.Write("{0} ", data[i]);
                }
            }
            Console.WriteLine();

            Console.Write("平均値より小さい数：");
            for (int i = 0; i < data.Length; i++)
            {
                if (avg > data[i])
                {
                    Console.Write("{0} ", data[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
