using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// このクラスはProgramクラスのMainメソッドで使用される
/// MakePasswordメソッド内で、AllLetterFactoryクラスのCreateメソッドを呼び出している
/// </summary>
namespace PasswordCreator {
    public class PasswordGenerator {
        private Random random;
        public PasswordGenerator(Random random) {
            this.random = random;
        }
        public string MakePassword(int count) {
            //剰余を利用して、数字、英小文字、英大文字、記号の順に引数countの値の文字数をランダムに生成する
            string password = string.Empty;
            for(int i = 0; i < count; i++) {
                AllLetterFactory factory = new AllLetterFactory();
                Letter letter = factory.Create(random, i);
                password += letter.GetLetter();
            }
            return password;
        }
    }
}
