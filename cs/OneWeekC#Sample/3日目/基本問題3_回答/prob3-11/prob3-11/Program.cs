using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0から100までの数値を入力してください：");
            int n = int.Parse(Console.ReadLine());

            if (n >= 20 && n < 80)
            {
                Console.WriteLine("20以上80未満です。");
            }
            else if(n < 0 || n > 100)
            {
                Console.WriteLine("範囲外です。");
            }
            else if(n < 20 || n >= 80)
            {
                Console.WriteLine("20未満か、80以上です。");
            }
        }
    }
}
