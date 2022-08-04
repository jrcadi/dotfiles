using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(1, 1001);

            Console.WriteLine("{0}の約数は", num);
            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
