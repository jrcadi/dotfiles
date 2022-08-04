using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex4_2
{
    abstract class PlaneFigure
    {
        protected double area = 0;
        protected double width = 0;
        protected double height = 0;

        public PlaneFigure()
        {
        }

        public PlaneFigure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public abstract double Area
        {
            get;
        }

    }
}
