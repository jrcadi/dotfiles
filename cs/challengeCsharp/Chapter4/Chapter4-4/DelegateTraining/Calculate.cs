using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTraining {
    public class Calculation {
        //ラムダ式を使用する
        private Func<int, int> function = x => {
                                            if ( x < 10 ) return x * x;
                                            else return x * 2;
                                        };
        public int Execute(int n) {
            return function(n);
        }

        ////メソッドの中でラムダ式を使用する（以下のコードのコメントを解除したら、10～16行目をコメントアウトすること）
        //public int Execute(int n) {
        //    Func<int, int> function;
        //    if (n < 10){
        //        function = x => x * x;
        //    } else{
        //        function = x => x * 2;
        //    }
        //    int ans = function(n);
        //    return ans;
        //}
    }
}
