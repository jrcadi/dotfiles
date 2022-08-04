using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx603
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January","February","March","April","May",
                    "June","July","August","September","October","November","December"};
            Dictionary<string, int> m = new Dictionary<string, int>();
            //  月の名前と番号を対応
            for(int i = 0; i < months.Length; i++)
            {
                m[months[i]] = i + 1;
            }
            //  月の名前を入力
            Console.Write("英語で月の名前を入力して下さい:");
            string name = Console.ReadLine();
            //  結果の表示
            Console.WriteLine("{0}は{1}月です。", name, m[name]);
        }
    }
}
