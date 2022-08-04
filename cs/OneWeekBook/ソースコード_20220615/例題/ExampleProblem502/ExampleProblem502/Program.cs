using System;

namespace ExampleProblem502
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("角度を入力:");
            double angle = double.Parse(Console.ReadLine());
            //  角度を弧度法に変換
            double rad = Math.PI * angle / 180.0;
            //  入力した角度のsin,cos,tanの表示
            Console.WriteLine("sin{0}°= {1}", angle, Math.Sin(rad));
            Console.WriteLine("cos{0}°= {1}", angle, Math.Cos(rad));
            Console.WriteLine("tan{0}°= {1}", angle, Math.Tan(rad));
        }
    }
}
