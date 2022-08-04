using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProblem506
{
    class Car : IDrive, IMechanical
    {
        //  運転メソッド
        public void Drive()
        {
            Console.WriteLine("運転する");
        }
        //  メンテナンスメソッド
        public void Maintain()
        {
            Console.WriteLine("メンテナンスする");
        }
    }
}
