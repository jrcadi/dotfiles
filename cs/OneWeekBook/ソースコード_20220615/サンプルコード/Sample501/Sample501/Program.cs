using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample501
{
    class Program
    {
        static void Main(string[] args)
        {
            //  要素2つの配列を作る
            Data[] d = new Data[2];
            //  Dataのインスタンスの数を表示
            Data.ShowNumber();
            //  1つ目のインスタンスを生成
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = new Data(i * 100);
                //  Dataのインスタンスを生成
                Data.ShowNumber();
            }
        }
    }
}
