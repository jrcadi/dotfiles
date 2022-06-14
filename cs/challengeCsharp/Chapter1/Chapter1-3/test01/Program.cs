using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter1-3 英字をランダムに	生成せよ！
/// </summary>
namespace test01 {
    class Program {
        static void Main(string[] args) {
            int count = 10;
            string password = MakeLowerAlphabet(count);
            //string password = MakeUpperAlphabet(count);
            Console.WriteLine(password);
        }
        private static string MakeUpperAlphabet(int count) {
            //英大文字をランダムに生成するメソッド　文字数は引数countの値に準ずる
            Random random = new Random();
            string password = string.Empty;
            for(int i = 0; i < count; i++) {
                int n = random.Next(65, 91);
                char c = (char)n;
                password += c.ToString();
            }
            return password;
        }
        private static string MakeLowerAlphabet(int count) {
            //英小文字をランダムに生成するメソッド　文字数は引数countの値に準ずる
            Random random = new Random();
            string password = string.Empty;
            for(int i = 0; i < count; i++) {
                int n = random.Next(97, 123);
                char c = (char)n;
                password += c.ToString();
            }
            return password;
        }
        private static string MakePassword(int count) {
            //数字をランダムに生成するメソッド　文字数は引数countの値に準ずる
            Random random = new Random();
            string password = string.Empty;
            for(int i = 0; i < count; i++) {
                password += random.Next(10);
            }
            return password;
        }
    }
}
