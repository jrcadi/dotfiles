using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter1-4 記号をランダムに	生成せよ！
/// </summary>
namespace test01 {
    class Program {
        static void Main(string[] args) {
            int count = 10;
            string password = MakeMark(count);  
            Console.WriteLine(password);
        }
        private static string MakeMark(int count) {
            //記号をランダムに生成する　文字数は引数countの値に準ずる
            string[] marks = { "!", "#", "$", "%", "&", "@" };
            Random random = new Random();
            string password = string.Empty;
            for(int i = 0; i < count; i++) {
                int n = random.Next(marks.Length);  //Lengthプロパティで配列の要素数を取得できる　今回は6
                password += marks[n];
            }
            return password;
        }
        private static string MakeUpperAlphabet(int count) {
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
            Random random = new Random();
            string password = string.Empty;
            for(int i = 0; i < count; i++) {
                password += random.Next(10);
            }
            return password;
        }
    }
}
