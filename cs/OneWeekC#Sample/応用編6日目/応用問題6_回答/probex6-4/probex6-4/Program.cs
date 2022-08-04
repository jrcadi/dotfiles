using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            while(true)
            {
                Console.Write("文字列を入力:");
                string s = Console.ReadLine();

                if(s == "")
                {
                    break;
                }
                else
                {
                    list.Add(s);
                }
            }

            for(int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }
            Console.WriteLine();
        }
    }
}
