using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Factoryクラス　つまり、インスタンスを返すメソッドを持っている
/// Createメソッドはインスタンスを返すメソッドであり、Factoryメソッドと呼ばれる
/// </summary>
namespace PasswordCreator {
    public class AllLetterFactory : LetterFactory{
        public override Letter Create(Random random, int i) {    //Letterを継承した、いずれかのクラスのインスタンスを返すメソッド
            int n = i % 4;
            if(n == 0) return new NumLetter(random);
            if(n == 1) return new LowerLetter(random);
            if(n == 2) return new UpperLetter(random);
            if(n == 3) return new MarkLetter(random);
            return null;         //上記の条件分岐に該当しない場合はnullを返す
        }
    }
}
