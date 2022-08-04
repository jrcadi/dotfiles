using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob201
{
    class Program
    {
        static void Main(string[] args)
        {
            //  コンソールから整数値を入力
            int n = int.Parse(Console.ReadLine());
            //  nが4かどうかの判定は「n == 4」
            if (n == 4)
            {
                Console.WriteLine("4です。");
            }
        }
    }
}
