using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(2, 101);
            string s = "";

            Console.Write("{0} = ", num);

            for(int i = 2; num != 1; i++)
            {
                while(num % i == 0)
                {
                    num = num / i;
                    Console.Write("{0}{1}", s, i);
                    s = "*";
                }
            }
            Console.WriteLine();
        }
    }
}
