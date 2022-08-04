using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProblem408
{
    class Hoo
    {
        public Hoo()
        {
            Console.WriteLine("Hooクラスのインスタンスが生成されました");
        }
        public void Foo()
        {
            Console.WriteLine("Fooメソッドが実行されました");
        }
        ~Hoo()
        {
            Console.WriteLine("Hooクラスのインスタンスが消去されました");
        }
    }
}
