using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob103
{
    class Program
    {
        static void Main(string[] args)
        {
            //  整数値をa,b,cに入力
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            //  結果を表示
            double total = a + b + c;      //  合計
            double average = total / 3.0;   //  平均
            Console.WriteLine("a + b + c = {0}", total);
            Console.WriteLine("a,b,cの平均 = {0}", average);
        }
    }
}
