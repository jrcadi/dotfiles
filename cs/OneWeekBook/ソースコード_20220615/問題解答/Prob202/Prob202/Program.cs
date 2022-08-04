using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob202
{
    class Program
    {
        static void Main(string[] args)
        {
            //  コンソールから整数値を入力
            int n = int.Parse(Console.ReadLine());
            //  nが0かどうかの判定は「n == 0」
            if (n == 0)
            {
                Console.WriteLine("0です。");
            }
            else
            {
                Console.WriteLine("0ではありません。");
            }
        }
    }
}
