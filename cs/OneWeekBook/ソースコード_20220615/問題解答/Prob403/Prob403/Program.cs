using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob403
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string型の大きさ5の配列を作成
            string[] str = new string[5];
            for(int i = 0; i < str.Length; i++)
            {
                Console.Write("{0}つ目の文字列を入力:", (i + 1));
                str[i] = Console.ReadLine();    //  コンソールから文字列を入力して代入
            }
            //  結果の表示 forを使ってもよいが、インデックス操作を必要としないので、foreach用いる
            foreach(string s in str)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine();
            
        }
    }
}
