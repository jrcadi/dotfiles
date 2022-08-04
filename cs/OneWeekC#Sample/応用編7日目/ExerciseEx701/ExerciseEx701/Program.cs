using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx701
{
    //  デリゲート
    delegate void Operation(int a, int b);
    //  Calcクラス
    class Calc
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }
    //  Programクラス
    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        static void Div(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
        static void Main(string[] args)
        {
            Calc c = new Calc();
            //  デリゲートの設定
            Operation o1 = new Operation(Add);
            o1 += new Operation(c.Sub);
            o1 += new Operation(Mul);
            o1 += new Operation(Div);
            //  デリゲートで設定したメソッドの呼び出し
            o1(2, 1);
        }
    }
}
