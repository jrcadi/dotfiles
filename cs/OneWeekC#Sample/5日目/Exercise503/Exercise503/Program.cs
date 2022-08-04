using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise503
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Random rnd = new Random();
            int sum = 0;    //  合計
            double avg = 0.0;   //  平均
            int min = 101, max = 0; //  最小値・最大値
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 101);    //  1～100までの乱数をa[i]に代入
                Console.Write("{0} ", a[i]);
                sum += a[i];    //  合計値の更新
                if(a[i] < min)
                {
                    min = a[i]; //  最小値の更新
                }
                if(a[i] > max)
                {
                    max = a[i]; //  最大値の更新
                }
            }
            avg = sum / (double)a.Length;
            Console.WriteLine();
            Console.WriteLine("合計値:{0} 平均値:{1} 最大値:{2} 最小値{3}", sum, avg, max, min);
        }
    }
}
