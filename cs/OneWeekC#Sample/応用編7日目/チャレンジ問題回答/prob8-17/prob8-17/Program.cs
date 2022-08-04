using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_17
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 10000; i++)
            {
                int fraternityNum = fraternity(i);
                if(i == fraternity(fraternityNum) && i < fraternityNum)
                {
                    Console.WriteLine("{0}と{1}は友愛数", i, fraternityNum);
                }
            }
        }

        static int fraternity(int num)
        {
            int n = 0;
            for (int i = 1; i * 2 <= num; i++)
            {
                if (num % i == 0 && num != i)
                {
                    n += i;
                }
            }
            return n;
        }
    }
}
