using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProblem404
{
    class Rectangle
    {
        //  幅
        private double width;
        //  高さ
        private double height;
        //  面積の取得
        public double GetArea()
        {
            return width * height;
        }
        //  周の長さ
        public double GetPerimeter()
        {
            return width * 2 + height * 2;
        }
        //  幅のプロパティ
        public double Width
        {
            set { width = value; }
            get { return width; }
        }
        //  高さのプロパティ
        public double Height
        {
            set { height = value; }
            get { return height; }
        }
    }
}
