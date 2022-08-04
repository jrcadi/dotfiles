using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rand = new Random();

            while(true)
            {
                int num = rand.Next(0, 11);
                Console.WriteLine("0～10の値を出力:{0}", num);

                if(num == 0)
                {
                    break;
                }
                else
                {

                    Console.Write("出力された数：");
                    if(list.Count == 0)
                    {
                        list.Add(num);
                        Console.Write("{0} ", list[0]);
                    }
                    else
                    {
                        for(int i = 0; i < list.Count; i++)
                        {
                            if(list[i] > num)
                            {
                                list.Insert(i, num);
                                break;
                            }
                            else
                            {
                                if(i == list.Count - 1)
                                {
                                    list.Add(num);
                                    break;
                                }
                            }
                        }
                        for(int i = 0; i < list.Count; i++)
                        {
                            Console.Write("{0} ", list[i]);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
