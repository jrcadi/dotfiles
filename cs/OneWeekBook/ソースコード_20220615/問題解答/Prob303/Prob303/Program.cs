using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob303
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("回数を入力:");
            int n = int.Parse(Console.ReadLine());
            //  whileループを用いた場合の書式
            while(n >= 0)
            {
                Console.Write("{0} ", n);
                //  入力された整数値をカウンタとし、そのまま0になるまで1を引き続ける
                n--;
            }
            //  forループを用いた場合
 /*
            for(int i = n; i >= 0; i--)
            {
                Console.Write("{0} ", i);
            }
*/
            Console.WriteLine();
        }
    }
}
