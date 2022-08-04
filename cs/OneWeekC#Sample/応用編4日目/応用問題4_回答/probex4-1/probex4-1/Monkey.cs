using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex4_1
{
    class Monkey : Animal
    {
        public Monkey()
        {
            name = "猿";
        }

        public override void Bark()
        {
            Console.WriteLine("キーキー");
        }

        public override void Move()
        {
            Console.WriteLine("木に登る");
        }
    }
}
