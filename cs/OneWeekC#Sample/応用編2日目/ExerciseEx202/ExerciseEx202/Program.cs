using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("一つ目の数:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("二つ目の数:");
            int b = int.Parse(Console.ReadLine());
            int n = Numeric.Max(a, b);  //  nにa,bのうち最大値を代入
            Console.WriteLine("二つの数値のうち最大値:{0}", n);
        }
    }
}
