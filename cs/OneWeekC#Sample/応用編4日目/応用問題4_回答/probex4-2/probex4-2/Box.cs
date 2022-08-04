﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex4_2
{
    class Box : PlaneFigure
    {
        public Box()
        {
        }

        public Box(double width, double height) : base(width, height)
        {
        }

        public override double Area
        {
            get
            {
                return width * height;
            }
        }
    }
}
