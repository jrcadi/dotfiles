using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx303
{
    //  子クラス
    class Child : Parent
    {
        public override void Foo()
        {
            Console.WriteLine("子クラスのFoo()メソッド");
        }
    }
}
