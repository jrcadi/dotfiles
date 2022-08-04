using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob305
{
    class Program
    {
        static void Main(string[] args)
        {
            //  暫定の最大値・最小値
            int max = -1, min = 101;
            Random rnd = new Random();
            //  乱数を発生させながら、最小値・最大値を更新せさる
            for(int i = 0; i < 5; i++)
            {
                int n = rnd.Next(1, 101);
                Console.Write("{0} ",n);    //  乱数を発生させ値を表示
                if(n > max)
                {
                    //  もしもnがmaxより大きければ、暫定の最大値を更新
                    max = n;
                }
                if (n < min)
                {
                    //  もしもnがminより小さければ、暫定の最小値を更新
                    min = n;
                }

            }
            Console.WriteLine();
            //  最後に最大値・最小値を表示
            Console.WriteLine("最大値:{0}", max);
            Console.WriteLine("最小値:{0}", min);
        }
    }
}
