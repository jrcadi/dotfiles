using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// このクラスはProgramクラスのMainメソッドで使用される
/// </summary>
namespace PasswordCreator {
    public class PasswordGenerator {
        public string MakePassword(Random random, int count) {
            //剰余を利用して、数字、英小文字、英大文字、記号の順に引数countの値の文字数をランダムに生成する
            string password = string.Empty;
            for(int i = 0; i < count; i++) {
                int n = i % 4;
                if(n == 0) password += GetNumLetter(random);
                if(n == 1) password += GetLowerLetter(random);
                if(n == 2) password += GetUpperLetter(random);
                if(n == 3) password += GetMarkLetter(random);
            }
            return password;
        }
        private string GetNumLetter(Random random) {
            return random.Next(10).ToString();
        }
        private string GetLowerLetter(Random random) {
            char c = (char)random.Next(97, 123);
            return c.ToString();
        }
        private string GetUpperLetter(Random random) {
            char c = (char)random.Next(65, 91);
            return c.ToString();
        }
        private string GetMarkLetter(Random random) {
            string[] mark = { "!", "#", "$", "%", "&", "@" };
            int n = random.Next(mark.Length);
            return mark[n];
        }
    }
}
