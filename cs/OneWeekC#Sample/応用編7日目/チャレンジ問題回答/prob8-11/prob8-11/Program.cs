using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[40];
            int n1 = 1;
            int n2 = 1;
            int n3;
            int i = 0;

            Console.WriteLine(n1);

            while(n2 < data.Length)
            {
                data[i] = n2;
                n3 = n2 + n1;

                n1 = n2;
                n2 = n3;
                i++;
            }

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(data[j]);
            }
        }
    }
}
