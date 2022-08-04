using System;

namespace ExampleProblem303
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数あてゲーム");
            Console.WriteLine("0から10の数値を入力してください。");
            Random rnd = new Random();
            //  0～10までの乱数を発生させる
            int n = rnd.Next(11);
            int i = 1;  //  カウンタ
            while (i <= 3)
            {
                Console.Write("{0}回目:", i);
                int ans = int.Parse(Console.ReadLine());
                if (ans < n)
                {
                    Console.WriteLine("小さすぎます。");
                }
                else if (ans > n)
                {
                    Console.WriteLine("大きすぎます。");
                }
                else
                {
                    //  正解の場合はループから抜ける
                    Console.WriteLine("正解です!");
                    break;
                }
                i++;
            }
            //  3回入力しても外れたらゲームオーバー
            if (i == 4)
            {
                Console.WriteLine("ゲームオーバー!");
                Console.WriteLine("正解は{0}です。", n);
            }
        }
    }
}
