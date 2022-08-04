using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample507
{
    class Program
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();          //  カラスクラス
            Sparrow s = new Sparrow();    //  すずめクラス
            //  カラスが鳴く
            Console.Write(c.Name + " : ");
            c.Sing();
            //  すずめが鳴く
            Console.Write(s.Name + " : ");
            s.Sing();
        }
    }
}
