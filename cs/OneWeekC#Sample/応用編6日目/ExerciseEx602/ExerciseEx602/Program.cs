using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx602
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            while (true)
            {
                Console.Write("1～10の整数を入力:");
                int num = int.Parse(Console.ReadLine());
                if (num < 1 || num > 10)
                {
                    break;  //  範囲外であればループから抜ける
                }
                l.Add(num);
            }
            //  lの並べ替え
            l.Sort();
            foreach (int n in l)
            {
                Console.Write("{0} ", n);
            }
        }
    }
}
