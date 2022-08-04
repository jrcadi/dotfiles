using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                int num = i;
                int digit = 0;
                while(num != 0)
                {
                    num = num / 10;
                    digit++;
                }

                if (digit == 1)
                {
                    if(i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    if(i % 3 == 0 || i % 10 == 3 || (i / 10) == 3)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
