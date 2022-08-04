using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("回数を入力:");
            //  キーボードから繰り返しの回数numを入力
            int num = int.Parse(Console.ReadLine());
            //  num回の繰り返し。
            //  for(int i = 1; i <= num ;i++)とする書き方もある。
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("HelloC#!");
            }
        }
    }
}
