using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    class Vector2D
    {
        public double x, y;
        public void Add(Vector2D v)
        {
            x += v.x; y += v.y;
        }
        public void Sub(Vector2D v)
        {
            x -= v.x; y -= v.y;
        }
        public void Mul(double k)
        {
            x *= k; y *= k;
        }
        public double DotProduct(Vector2D v)
        {
            return x * v.x + y * v.y;
        }
    }
}
