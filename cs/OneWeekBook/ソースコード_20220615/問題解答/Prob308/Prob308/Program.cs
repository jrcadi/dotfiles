using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob308
{
    class Program
    {
        static void Main(string[] args)
        {
            //  2から100までの数値のカウンタ
            for(int n = 2; n <= 100; n++)
            {
                //  自然数nの約数の数
                int count = 0;
                for(int i = 1; i <= n; i++)
                {
                    if(n % i == 0)
                    {
                        //  nがiで割り切れれば
                        //  nはiの約数という事になるので
                        //  カウントアップする
                        count++;
                    }
                }
                //  count == 2ということは
                //  約数が1かnのみということになるので
                //  素数とみなし表示する
                if(count == 2)
                {
                    Console.Write("{0} ", n);
                }
            }
            Console.WriteLine();
        }
    }
}
