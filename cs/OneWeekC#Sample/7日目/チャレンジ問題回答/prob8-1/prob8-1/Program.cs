using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 1; a <= 100; a++)
            {
                for (int b = 1; b <= 100; b++)
                {
                    for (int c = 1; c <= 100; c++)
                    {
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine("a={0} b={1} c={2} ={3}", a, b, c, c * c);
                        }
                    }
                }
            }
        }
    }
}
