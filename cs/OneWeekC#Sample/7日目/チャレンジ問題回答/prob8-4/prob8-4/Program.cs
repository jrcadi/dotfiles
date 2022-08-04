using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(1, 1001);
            int result = 0;

            Console.Write("{0}の桁数は", num);
            while(num != 0)
            {
                num = num / 10;
                result++;
            }

            Console.WriteLine("{0}桁です", result);
        }
    }
}
