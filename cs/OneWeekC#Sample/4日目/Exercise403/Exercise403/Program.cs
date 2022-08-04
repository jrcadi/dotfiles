using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise403
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 11);    //  1から10までの乱数を発生させaに代入
            int b = rnd.Next(1, 11);    //  1から10までの乱数を発生させbに代入
            Console.WriteLine("a={0} b={1}", a, b);
            //  回答を入力（正解出るまで繰り返す)
            while (true)
            {
                Console.Write("a+b=");
                int ans = int.Parse(Console.ReadLine());    //  回答の数値を入力
                if(ans == a + b)
                {
                    Console.WriteLine("正解");
                    break;
                }
                else
                {
                    Console.WriteLine("間違い");
                }
            }
        }
    }
}
