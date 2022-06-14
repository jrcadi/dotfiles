using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter1-1 数値をランダムに	生成せよ！
/// </summary>
namespace test01 {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();   //Randomクラスのインスタンスを生成
            string password = string.Empty;
            for(int i = 0; i < 10; i++) {
                password += random.Next(10);    //Nextメソッドは、0から9までの範囲でランダムな整数を返す
            }
            Console.WriteLine(password);
        }
    }
}
