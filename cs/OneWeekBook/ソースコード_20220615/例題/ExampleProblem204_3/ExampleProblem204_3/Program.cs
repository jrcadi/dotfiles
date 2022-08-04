using System;

namespace ExampleProblem204_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  月を入力
            Console.Write("月(1～12)を入力して下さい:");
            int m = int.Parse(Console.ReadLine());
            string d = "";
            switch (m)
            {
                case 2:
                    d = "28か29";
                    break;
                case 4:
                case 5:
                case 9:
                case 11:
                    d = "30";
                    break;
                case 1:
                case 3:
                case 6:
                case 7:
                case 8:
                case 12:
                    d = "31";
                    break;
                default:
                    Console.WriteLine("適切な値を入力してください");
                    return;
            }
            Console.WriteLine("{0}月の長さは{1}日です", m, d);
        }
    }
}
