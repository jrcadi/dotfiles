using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            int cnt1 = 0, cnt2 = 0, cnt3 = 0;
            Random rand = new Random();

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(-10, 11);
                Console.Write("{0} ", data[i]);

                if(data[i] > 0)
                {
                    cnt1++;
                }
                else if(data[i] < 0)
                {
                    cnt2++;
                }
                else
                {
                    cnt3++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("0より大きい数：{0}個", cnt1);
            Console.WriteLine("0より小さい数：{0}個", cnt2);
            Console.WriteLine("0の個数：{0}個", cnt3);
        }
    }
}
