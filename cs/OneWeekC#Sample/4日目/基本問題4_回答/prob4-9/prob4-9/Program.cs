using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new System.Random();
            while(true)
            {
                int n = rand.Next(1, 101);
                Console.WriteLine(n);
                if (n % 10 == 0)
                {
                    Console.WriteLine("終了します");
                    break;
                }
            }
        }
    }
}
