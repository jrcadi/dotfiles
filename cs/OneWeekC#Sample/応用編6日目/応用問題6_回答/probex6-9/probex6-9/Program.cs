using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("○");
            hashSet.Add("一");
            hashSet.Add("二");
            hashSet.Add("三");
            hashSet.Add("四");
            hashSet.Add("五");
            hashSet.Add("六");
            hashSet.Add("七");
            hashSet.Add("八");
            hashSet.Add("九");

            Console.Write("整数の値を入力してください：");
            string num = Console.ReadLine();

            string result = "";
            for(int i = num.Length - 1; i >= 0; i--)
            {
                int j = 0;
                foreach(string s in hashSet)
                {
                    if(int.Parse(num.Substring(i, 1)) == j)
                    {
                        result = s + result;
                        if((num.Length - i) % 3 == 0 && i != 0)
                        {
                            result = "," + result;
                        }
                        break;
                    }
                    j++;
                }   
            }

            Console.WriteLine("変換結果:" + result);
        }
    }
}
