using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex3_2
{
    class FundCalc
    {
        protected double number1 = 0.0;
        protected double number2 = 0.0;

        public double Number1
        {
            set { number1 = value; }
            get { return number1; }
        }

        public double Number2
        {
            set { number2 = value; }
            get { return number2; }
        }

        public double Add()
        {
            return number1 + number2;
        }

        public double Sub()
        {
            return number1 - number2;
        }
    }
}
