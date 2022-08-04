using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample502
{
    class Program
    {
        //  staticなフィールド
        private static int snum = 100;
        //  インスタンスフィールド
        public int inum = 200;
        //  staticなメソッド
        public static void Foo()
        {
            Console.WriteLine("Fooメソッド（staticメソッド)");
        }
        public void Bar()
        {
            Console.WriteLine("Barメソッド（インスタンスメソッド）");
        }
        static void Main(string[] args)
        {
            //  インスタンスの生成
            Program p = new Program();
            Console.WriteLine("pのインスタンスフィールド:inum = {0}",
                     p.inum);
            Console.WriteLine("Programのクラスフィールド:snum = {0}",
                     snum);
            Foo();
            p.Bar();
        }
    }
}
