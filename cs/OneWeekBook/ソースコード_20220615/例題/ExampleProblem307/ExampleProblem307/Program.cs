using System;

namespace ExampleProblem307
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] n = new int[10];
            //  乱数を代入・表示
            for (int i = 0; i < n.Length; i++)
            {
                int num = rnd.Next(1, 101); //  1から100までの乱数発生
                n[i] = num;
                Console.Write("{0} ", num); //  値を表示
            }
            Console.WriteLine();    //  改行
            string[] names = { "偶数:", "奇数:" };
            //  奇数・偶数を表示
            for (int i = 0; i <= 1; i++)
            {
                Console.Write(names[i]);
                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j] % 2 == i)
                    {
                        Console.Write("{0} ", n[j]);
                    }
                }
                Console.WriteLine();    //  改行
            }
        }
    }
}
