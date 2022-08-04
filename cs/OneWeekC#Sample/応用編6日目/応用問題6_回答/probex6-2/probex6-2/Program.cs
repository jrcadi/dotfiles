using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
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
                    list.Add(num);
                }
            }

            Console.WriteLine();
            for(int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write("{0} ", list[i]);
            }
            Console.WriteLine();
        }
    }
}
