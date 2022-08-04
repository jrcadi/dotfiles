using System;

namespace ExampleProblem302
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力:");
            //  整数値を入力
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                //  nがiで割り切れればその値を表示する
                if (n % i == 0)
                {
                    Console.Write("{0} ", i);
                }

            }
            Console.WriteLine();
        }
    }
}
