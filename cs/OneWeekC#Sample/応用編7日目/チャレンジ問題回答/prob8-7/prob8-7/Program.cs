using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int denominator1 = rand.Next(2, 11);
            int numerator1 = rand.Next(1, 11);
            int denominator2 = rand.Next(2, 11);
            int numerator2 = rand.Next(1, 11);

            if(numerator1 % denominator1 == 0)
            {
                Console.Write("{0} + ", numerator1 / denominator1);
            }
            else if(numerator1 > denominator1)
            {
                Console.Write("{0}.{1}/{2} + ", numerator1 / denominator1, numerator1 % denominator1, denominator1);
            }
            else
            {
                Console.Write("{0}/{1} + ", numerator1, denominator1);
            }

            if (numerator2 % denominator2 == 0)
            {
                Console.Write("{0} = ", numerator2 / denominator2);
            }
            else if (numerator1 > denominator1)
            {
                Console.Write("{0}.{1}/{2} = ", numerator2 / denominator2, numerator2 % denominator2, denominator2);
            }
            else
            {
                Console.Write("{0}/{1} = ", numerator2, denominator2);
            }

            int resultDenominator = lcm(denominator1, denominator2);
            if(denominator1 != resultDenominator)
            {
                numerator1 = numerator1 * (resultDenominator / denominator1);
            }
            if (denominator2 != resultDenominator)
            {
                numerator2 = numerator2 * (resultDenominator / denominator2);
            }

            int resultNumerator = numerator1 + numerator2;
            int n = gcd(resultNumerator, resultDenominator);

            resultDenominator = resultDenominator / n;
            resultNumerator = resultNumerator / n;

            if (resultNumerator % resultDenominator == 0)
            {
                Console.WriteLine("{0}", resultNumerator / resultDenominator);
            }
            else if (resultNumerator > resultDenominator)
            {
                Console.WriteLine("{0}.{1}/{2}", resultNumerator / resultDenominator, resultNumerator % resultDenominator, resultDenominator);
            }
            else
            {
                Console.WriteLine("{0}/{1}", resultNumerator, resultDenominator);
            }
        }

        static int gcd(int x, int y)
        {
            int r;
            while ((r = x % y) != 0)
            {
                x = y;
                y = r;
            }
            return y;
        }


        static int lcm(int x, int y)
        {
            return ((x * y) / gcd(x, y));
        }
    }
}
