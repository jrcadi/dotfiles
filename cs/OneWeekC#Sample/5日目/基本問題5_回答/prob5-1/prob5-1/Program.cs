using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            Random rand = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(1, 11);
                Console.Write("a[{0}]={1} ", i, a[i]);
            }
            Console.WriteLine();
        }
    }
}
