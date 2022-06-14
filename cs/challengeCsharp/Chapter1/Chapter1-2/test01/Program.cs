using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter1-2 メソッドを活用せよ！
/// </summary>
namespace test01 {
    class Program {
        static void Main(string[] args) {
            int count = 14;
            string password = MakePassword(count);  //MakePasswordメソッドを呼び出す
            Console.WriteLine(password);
        }
        private static string MakePassword(int count) {
            Random random = new Random();
            string password = string.Empty;
            for(int i = 0; i < count; i++) {    //引数countの値を繰り返しの回数に使用している
                password += random.Next(10);
            }
            return password;
        }
    }
}
