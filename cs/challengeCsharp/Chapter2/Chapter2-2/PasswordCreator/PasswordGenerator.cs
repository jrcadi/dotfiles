using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// このクラスはProgramクラスのMainメソッドで使用される
/// コンストラクターを用意した
/// </summary>
namespace PasswordCreator {
    public class PasswordGenerator {
        private Random random;  //private変数はクラス内の全メソッドで使用できる
        public PasswordGenerator(Random random) {
            this.random = random;   //引数の値をprivate変数randomに格納する
        }
        public string MakePassword(int count) {
            //剰余を利用して、数字、英小文字、英大文字、記号の順に引数countの値の文字数をランダムに生成する
            string password = string.Empty;
            for(int i = 0; i < count; i++) {
                int n = i % 4;
                if(n == 0) password += GetNumLetter();
                if(n == 1) password += GetLowerLetter();
                if(n == 2) password += GetUpperLetter();
                if(n == 3) password += GetMarkLetter();
            }
            return password;
        }
        private string GetNumLetter() {
            return random.Next(10).ToString();
        }
        private string GetLowerLetter() {
            char c = (char)random.Next(97, 123);
            return c.ToString();
        }
        private string GetUpperLetter() {
            char c = (char)random.Next(65, 91);
            return c.ToString();
        }
        private string GetMarkLetter() {
            string[] mark = { "!", "#", "$", "%", "&", "@" };
            int n = random.Next(mark.Length);
            return mark[n];
        }
    }
}
