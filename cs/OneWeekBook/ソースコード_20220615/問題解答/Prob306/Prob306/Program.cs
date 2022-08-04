using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob306
{
    class Program
    {
        static void Main(string[] args)
        {
            //  無限ループによって処理を繰り返す
            while (true)
            {
                Console.Write("文字列を入力:");
                //  キーボードから文字列を入力させる
                string str = Console.ReadLine();
                if (str == "")
                {
                    //  空文字ならループから出る
                    break;
                }
                //  入力された文字列を表示する
                Console.WriteLine(str);

            }
        }
    }
}
