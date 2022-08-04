using System;

namespace ExampleProblem402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("英文を入力してください:");
            string str = Console.ReadLine();
            //  大文字で表示
            Console.WriteLine("大文字:{0}", str.ToUpper());
            //  小文字で表示
            Console.WriteLine("大文字:{0}", str.ToLower());
        }
    }
}
