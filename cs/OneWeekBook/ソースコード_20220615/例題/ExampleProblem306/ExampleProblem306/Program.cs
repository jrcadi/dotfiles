using System;

namespace ExampleProblem306
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            //  数値の入力
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}つ目の数値:", i + 1);
                int n = int.Parse(Console.ReadLine());
                a[i] = n;
            }
            //  入力した数値を表示し改行
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            //  最初の数を仮の最大値・最小値に設定
            int max = a[0];
            int min = a[0];
            //  最大値・最小値を求める
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            //  最大値・最小値の表示
            Console.WriteLine("最大値:{0}", max);
            Console.WriteLine("最小値:{0}", min);
        }
    }
}
