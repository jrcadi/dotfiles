using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = rand.Next(1, 11);

            if (n %2 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("★");
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("☆");
                }
            }
            Console.WriteLine();
        }
    }
}
