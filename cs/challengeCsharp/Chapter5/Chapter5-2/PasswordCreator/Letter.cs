using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator {
    public class Letter {
        protected Random random;
        public Letter(Random random) {      //コンストラクター
            this.random = random;           //引数の値をprotected変数に格納
        }
        public virtual string GetLetter() { //子クラスはこのメソッドを使える
            return string.Empty;                //戻り値を設定する
        }
    }
}
