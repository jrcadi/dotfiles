using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob401
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6]; //  int型の大きさ6の配列を作成
            Random rnd = new Random();  //  乱数発生の準備
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 11); //  1から10までの乱数を発生させ代入する
            }
            //  発生させた乱数を表示する
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}]={1} ", i, a[i]);
            }
            Console.WriteLine();    //  改行
        }
    }
}
