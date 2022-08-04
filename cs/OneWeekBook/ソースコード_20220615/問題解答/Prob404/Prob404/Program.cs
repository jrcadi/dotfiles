using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob404
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January","February","March","April","May","June","July","August","September","October","November","December" };
            Console.Write("月（1～12）を入力してください:");
            int m = int.Parse(Console.ReadLine());
            if(m >= 1 && m <= months.Length)
            {
                //  m月の中の配列のインデックスはm-1
                Console.WriteLine("{0}",months[m-1]);
            }
            else
            {
                Console.WriteLine("適切な値を入力してください。");
            }
        }
    }
}
