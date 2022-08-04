using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample509
{
    //  スーパークラス（抽象プロパティ持つ）
    abstract class VectorBase
    {
        //  抽象プロパティ
        public abstract double X
        {
            set;
            get;
        }
        public abstract double Y
        {
            set;
            get;
        }
    }
}
