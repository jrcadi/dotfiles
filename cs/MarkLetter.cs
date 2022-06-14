using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator {
    public class MarkLetter:Letter{ //子クラスの追加 継承
        public MarkLetter(Random random):base(random){ //p57 コンストラクタ 
        }
        public override string GetLetter(){ //メソッドのオーバライド
            string[] mark = { "!", "#", "$", "%", "&", "@" };
            int n = random.Next(mark.Length);
            return mark[n];
        }
    }
}
