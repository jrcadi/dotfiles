using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            HashSet<int> hash = new HashSet<int>();

            Console.Write("乱数：");
            for(int i = 0; i < 10; i++)
            {
                int num = rand.Next(1, 11);
                Console.Write("{0} ", num);
                hash.Add(num);
            }
            Console.WriteLine();

            Console.Write("出現した数：");
            foreach(int n in hash)
            {
                Console.Write("{0} ", n);
            }

            Console.WriteLine();
        }
    }
}
