using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex1_3
{
    class Sample
    {
        public Sample()
        {
            Console.WriteLine("スタート");
        }

        public void func()
        {
            Console.WriteLine("func");
        }

        ~Sample()
        {
            Console.WriteLine("エンド");
        }
    }
}
