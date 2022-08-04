using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise502
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = { 0.2, 1.4, -0.8 };
            //  配列の要素を表示
            for(int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("d[{0}]={1}", i, d[i]);
            }
        }
    }
}
