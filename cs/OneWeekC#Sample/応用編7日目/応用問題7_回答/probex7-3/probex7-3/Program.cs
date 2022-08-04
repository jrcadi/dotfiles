using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2 };
            for(int i = 0; i < 4; i++)
            {
                try
                {
                    Console.WriteLine("a[" + i + "]=" + a[i]);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine("配列の範囲を超えています。");
                }
            }
        }
    }
}
