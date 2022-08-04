using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列1を入力：");
            string s1 = Console.ReadLine();
            Console.Write("文字列2を入力：");
            string s2 = Console.ReadLine();

            if(s1 == s2)
            {
                Console.WriteLine("2つの文字列は等しい");
            }
            else
            {
                Console.WriteLine("2つの文字列は等しくない");
            }
        }
    }
}
