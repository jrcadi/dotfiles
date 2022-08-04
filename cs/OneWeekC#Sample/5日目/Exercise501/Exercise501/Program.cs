using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise501
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            //  for文を用いて、要素に値を代入
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
            }
            //  for文を用いて、要素を表示
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
        }
    }
}
