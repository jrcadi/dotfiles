using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx101
{
    class Vector2D
    {
        public Vector2D()
        {
        }
        public Vector2D(double x,double y)
        {
            X = x; Y = y;
        }
        public Vector2D(Vector2D v)
        {
            X = v.X; Y = v.Y;
        }
        public void Add(Vector2D v)
        {
            X += v.X; Y += v.Y;
        }
        public void Sub(Vector2D v)
        {
            X -= v.X; Y -= v.Y;
        }
        public void Mul(double k)
        {
            X *= k; Y *= k;
        }
        public double DotProduct(Vector2D v)
        {
            return X * v.X + Y * v.Y;
        }
        public double X
        {
            set; get;
        }
        public double Y
        {
            set; get;
        }
    }
}
