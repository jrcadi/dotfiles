using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob302
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("forループ:");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("★");
            }
            Console.WriteLine();    //  次の処理に行くために改行
            Console.Write("whileループ:");
            int n = 0;  //  初期値はループの外で初期化
            while(n < 5)
            {
                Console.Write("★");
                n++;    //  カウンタの値はループ内で更新
            }
            Console.WriteLine();    //  次の処理に行くために改行
            Console.Write("do～whileループ:");
            n = 0;  //  初期値はループの外で初期化(一度使った変数なので0を代入するだけ)
            do
            {
                Console.Write("★");
                n++;    //  カウンタの値はループ内で更新
            } while (n < 5);
            Console.WriteLine();    //  次の処理に行くために改行
        }
    }
}
