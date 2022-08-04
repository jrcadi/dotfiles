using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseEx401
{
    class Chicken : Bird
    {
        public Chicken() : base("にわとり")
        {
        }
        //  にわとりがなく
        public override void Sing()
        {
            Console.WriteLine("コケコッコー");
        }
    }
}
