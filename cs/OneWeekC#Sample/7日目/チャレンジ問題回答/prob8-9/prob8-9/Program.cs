using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10000; i++)
            {
                int num = 0;
                int j;
                for(j = 1; j < i; j++)
                {
                    if((i % j) == 0)
                    {
                        num += j;
                    }
                }

                if(j == num)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
