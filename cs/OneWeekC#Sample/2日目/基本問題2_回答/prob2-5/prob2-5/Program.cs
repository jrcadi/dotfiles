using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列1を入力：");
            string s1 = Console.ReadLine();
            Console.Write("文字列2を入力：");
            string s2 = Console.ReadLine();

            Console.WriteLine("文字列1 + 文字列2 = {0}", s1 + s2);
        }
    }
}
