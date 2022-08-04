using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob6_3
{
    class Circle
    {
        public double r;

        public double Circumference()
        {
            return 2 * 3.14 * r;
        }

        public double Area()
        {
            return r * r * 3.14;
        }
    }
}
