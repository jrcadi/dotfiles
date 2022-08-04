using System;

namespace ExampleProblem404
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            //  図形の幅と高さを入力
            Console.Write("幅(cm):");
            r.Width = double.Parse(Console.ReadLine());
            Console.Write("高さ(cm):");
            r.Height = double.Parse(Console.ReadLine());
            //  面積の表示
            Console.WriteLine("面積:{0}cm2", r.GetArea());
            //  周の長さの表示
            Console.WriteLine("周の長さ:{0}cm", r.GetPerimeter());
        }
    }
}
