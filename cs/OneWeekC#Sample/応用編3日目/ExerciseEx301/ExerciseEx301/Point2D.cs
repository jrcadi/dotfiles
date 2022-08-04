using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx301
{
    class Point2D : Vector2D
    {
        public Point2D(double x,double y) : base(x,y)
        {
        }
        public Point2D(Point2D p) : base(p)
        {
        }
        public Point2D() : base(0,0)
        {
        }
        public double Distance(Point2D p)
        {
            double x = X - p.X;
            double y = Y - p.Y;
            return Math.Sqrt(x * x + y * y);
        }
        public override bool Equals(object obj)
        {
            Point2D p = obj as Point2D;
            if(Distance(p) < 0.01)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string s = "(" + X + "," + Y + ")";
            return s;
        }
    }
}
