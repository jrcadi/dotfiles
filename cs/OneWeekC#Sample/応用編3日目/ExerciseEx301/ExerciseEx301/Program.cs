using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("p1.X = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("p1.Y = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("p2.X = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("p2.Y = ");
            double y2 = double.Parse(Console.ReadLine());
            Point2D p1 = new Point2D(x1,y1);
            Point2D p2 = new Point2D(x2,y2);
            //  座標の表示
            Console.WriteLine("p1={0} p2={1}", p1, p2);
            //  二点間の距離の表示
            Console.WriteLine("p1,p2の距離:{0}", p1.Distance(p2));
            //  同じ点だったらその旨を表示する
            if (p1.Equals(p2))
            {
                Console.WriteLine("p1,p2は同一の点です。");
            }
        }
    }
}
