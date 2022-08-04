using System;

namespace ExampleProblem204_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  月を入力
            Console.Write("月(1～12)を入力して下さい:");
            int m = int.Parse(Console.ReadLine());
            string d = "";
            if (m >= 1 && m <= 12)
            {
                if (m == 2)
                {
                    d = "28か29";
                }
                else if (m == 4 || m == 6 || m == 9 || m == 11)
                {
                    d = "30";
                }
                else
                {
                    d = "31";
                }
                Console.WriteLine("{0}月の長さは{1}日です", m, d);
            }
            else
            {
                Console.WriteLine("適切な値を入力してください");
            }
        }
    }
}
