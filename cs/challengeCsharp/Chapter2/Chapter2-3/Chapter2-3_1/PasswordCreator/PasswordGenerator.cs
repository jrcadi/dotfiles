using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// このクラスはProgramクラスのMainメソッドで使用される
/// MakePasswordメソッド内で、Letterクラスを継承した4つのクラスを使用している。
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
                Letter letter = null;   //Letter型なので、Letterクラスを継承したクラスのインスタンスを代入できる
                int n = i % 4;
                if(n == 0) letter = new NumLetter(random);  //NumLetterクラスのインスタンスを変数letterに代入
                if(n == 1) letter = new LowerLetter(random);
                if(n == 2) letter = new UpperLetter(random);
                if(n == 3) letter = new MarkLetter(random);
                password += letter.GetLetter();
            }
            return password;
        }
    }
}
