using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace PasswordCreator {
    public class UpperLetter:Letter{ //子クラスの追加 継承
        public UpperLetter(Random random):base(random){ //p57 コンストラクタ 
        }
        public override string GetLetter(){ //メソッドのオーバライド
            char c = (char)random.Next(65, 91);
            return c.ToString();
        }
    }
}

