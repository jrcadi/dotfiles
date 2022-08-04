using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProblem505
{
    class Mice : Mammals
    {
        public Mice()
        {
            this.name = "ネズミ";
        }
        //  吠える
        public override void Bark()
        {
            Console.WriteLine("チューチュー");
        }
    }
}
