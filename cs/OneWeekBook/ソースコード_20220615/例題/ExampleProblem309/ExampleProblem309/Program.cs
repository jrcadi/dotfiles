using System;

namespace ExampleProblem309
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[10];
            //  配列に1から99の乱数を代入
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            //  数値の範囲による数の分類
            for (int i = 0; i < 100; i += 10)
            {
                Console.Write("{0}以上{1}未満:", i, i + 10);
                foreach (int n in a)
                {
                    if (n >= i && n < i + 10)
                    {
                        Console.Write("{0} ", n);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
