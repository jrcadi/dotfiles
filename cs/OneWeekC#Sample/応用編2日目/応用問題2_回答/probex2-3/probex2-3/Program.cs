using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex2_3
{
    class Program
    {
        static void Squere(int h, int w)
        {
            if(w == 0 || h == 0)
            {
                return;
            }

            for(int i = 0; i < h; i++)
            {
                for(int j = 0; j < w; j++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int h = r.Next(1, 11);
            int w = r.Next(1, 11);

            Console.WriteLine("たて:{0}", h);
            Console.WriteLine("よこ:{0}", w);
            Squere(h, w);
        }
    }
}
