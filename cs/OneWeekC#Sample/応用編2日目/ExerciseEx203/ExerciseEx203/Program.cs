using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx203
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("実数値を入力してください。");
            double n = double.Parse(Console.ReadLine());
            if(n >= 0)
            {
                //  平方根の表示
                double r = Math.Sqrt(n);    //  nの平方根をrに代入
                Console.WriteLine("{0}の平方根は{1}です。", n, r);
            }
            else
            {
                //  負の値の場合
                Console.WriteLine("正の数を入力してください。");
            }
        }
    }
}
