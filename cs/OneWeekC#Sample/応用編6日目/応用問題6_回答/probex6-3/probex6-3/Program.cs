using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rand = new Random();

            while(true)
            {
                int num = rand.Next(0, 101);
                Console.WriteLine("0～100の値を出力:{0}", num);

                if(num == 0)
                {
                    break;
                }
                else
                {
                    list.Add(num);
                }
            }

            for(int i = 0; i < 10; i++)
            {
                int cnt = 0;
                Console.Write("一の位が{0}:", i);
                for(int j = 0; j < list.Count; j++)
                {
                    if(list[j] % 10 == i)
                    {
                        Console.Write("{0} ", list[j]);
                        cnt++;
                    }
                }
                if(cnt == 0)
                {
                    Console.Write("なし");
                }
                Console.WriteLine();
            }
        }
    }
}
