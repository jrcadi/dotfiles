using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter1-5 パスワードを生成せよ！ （前半の部）
/// 数字・英小文字・英大文字・記号の順に4文字をランダムに生成する
/// </summary>
namespace test02 {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            string password = MakePassword(random);
            Console.WriteLine(password);
        }
        private static string MakePassword(Random random) {
            //数字・英小文字・英大文字・記号の順に4文字をランダムに生成する
            string password = string.Empty;
            password += GetNumLetter(random);
            password += GetLowerLetter(random);
            password += GetUpperLetter(random);
            password += GetMarkLetter(random);
            return password;
        }
        //以下の4つのメソッドはMakePasswordメソッドで呼び出される
        private static string GetNumLetter(Random random) {
            return random.Next(10).ToString();
        }
        private static string GetLowerLetter(Random random) {
            char c = (char)random.Next(97, 123);
            return c.ToString();
        }
        private static string GetUpperLetter(Random random) {
            char c = (char)random.Next(65, 91);
            return c.ToString();
        }
        private static string GetMarkLetter(Random random) {
            string[] mark = { "!", "#", "$", "%", "&", "@" };
            int n = random.Next(mark.Length);
            return mark[n];
        }
    }
}
