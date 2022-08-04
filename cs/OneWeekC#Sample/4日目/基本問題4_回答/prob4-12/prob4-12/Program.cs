using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt1 = 0, cnt2 = 0;
            Random rand = new System.Random();

            for(int i = 0; i < 5; i++)
            {
                int n = rand.Next(1, 101);
                Console.WriteLine(n);
                if (n % 2 == 0)
                {
                    cnt1++;
                }
                else
                {
                    cnt2++;
                }
            }
            Console.WriteLine("偶数の数：{0}", cnt1);
            Console.WriteLine("奇数の数：{0}", cnt2);
        }
    }
}
