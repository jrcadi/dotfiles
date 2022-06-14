using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter1-5 パスワードを生成せよ！ （後半）
/// 数字、英小文字、英大文字、記号の順にランダムに任意の文字数を生成する
/// </summary>
namespace test02 {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int count = 12;
            string password = MakePassword(random, count);
            Console.WriteLine(password);
        }
        private static string MakePassword(Random random, int count) {
            //剰余を利用して、数字、英小文字、英大文字、記号の順に引数countの値の文字数をランダムに生成する
            string password = string.Empty;
            for(int i = 0; i < count; i++) {
                int n = i % 4;
                if(n == 0) {
                    password += GetNumLetter(random);
                }
                if(n == 1) {
                    password += GetLowerLetter(random);
                }
                if(n == 2) {
                    password += GetUpperLetter(random);
                }
                if(n == 3) {
                    password += GetMarkLetter(random);
                }
            }
            return password;
        }
        //以下の4つのメソッドは、MakePasswordメソッド内で呼び出される
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
