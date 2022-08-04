using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample505
{
    //  ベースクラス
    class Parent
    {
        public virtual void Foo()
        {
            Console.WriteLine("親クラスのFoo()メソッド");
        }
    }
}
