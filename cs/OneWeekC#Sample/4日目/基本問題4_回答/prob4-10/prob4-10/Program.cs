using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new System.Random();

            for(int i = 0; i < 5; i++)
            {
                int n = rand.Next(1, 101);
                Console.WriteLine(n);
            }
        }
    }
}
