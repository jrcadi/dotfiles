using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator {
    public class NumLetter:Letter{ //子クラスの追加 継承
        public NumLetter(Random random):base(random){ //p57 コンストラクタ 
        }
        public override string GetLetter(){ //メソッドのオーバライド
            // return base.GetLetter(); //親クラスのGetLetterメソッドの戻り値をこのメソッドの戻り値としている
            return random.Next(10).ToString();
        }
    }
}
