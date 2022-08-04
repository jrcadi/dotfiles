using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            Random rand = new Random();

            while(true)
            {
                int num = rand.Next(0, 11);
                Console.WriteLine("0～10の値を出力：{0}", num);
                if(num == 0)
                {
                    break;
                }
                else
                {
                    if(num % 2 == 0)
                    {
                        list1.Add(num);
                    }
                    else
                    {
                        list2.Add(num);
                    }
                }
            }

            Console.Write("偶数：");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write("{0} ", list1[i]);
            }
            Console.WriteLine();

            Console.Write("奇数：");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write("{0} ", list2[i]);
            }
            Console.WriteLine();
        }
    }
}
