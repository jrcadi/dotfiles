using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[30];
            int n1 = 1;
            int n2 = 1;
            int n3 = 2;
            int n4;
            int i = 0;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            while(n3 < data.Length)
            {
                data[i] = n3;

                n4 = n3 + n2 + n1;

                n1 = n2;
                n2 = n3;
                n3 = n4;
                i++;
            }

            for(int j = 0; j < i; j++)
            {
                Console.WriteLine(data[j]);
            }
        }
    }
}
