using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex1_2
{
    class Calc
    {
        private int num1;
        private int num2;

        public int Num1
        {
            set { num1 = value; }
            get { return num1; }
        }
        
        public int Num2
        {
            set { num2 = value; }
            get { return num2; }
        }

        public Calc()
        {
        }

        public Calc(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public void ShowAdd()
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }
    }
}
