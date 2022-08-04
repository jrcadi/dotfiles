using System;

namespace ExampleProblem206
{
    class Program
    {
        static void Main(string[] args)
        {
            //  H20の温度を乱数で決める
            Console.Write("H2Oの温度:");
            //  コンソールから温度を入力させる
            double temperature = double.Parse(Console.ReadLine());
            if (temperature >= 100.0)
            {
                Console.WriteLine("気体");
            }
            else if (temperature > 0.0)
            {
                Console.WriteLine("液体");
            }
            else
            {
                Console.WriteLine("固体");
            }
        }
    }
}
