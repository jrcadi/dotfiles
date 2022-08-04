using System;

namespace ExampleProblem506
{
    class Program
    {
        //  自動車を運転する
        static void DriveACar(IDrive car)
        {
            car.Drive();
            //car.Maintain();   
        }
        //  自動車をメンテナンスする
        static void MaintainACar(IMechanical car)
        {
            //car.Drive();
            car.Maintain();
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            DriveACar(c);
            MaintainACar(c);
        }
    }
}
