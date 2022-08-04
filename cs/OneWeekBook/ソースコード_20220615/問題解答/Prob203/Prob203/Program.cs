using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob203
{
    class Program
    {
        static void Main(string[] args)
        {
            //  テストの点数を入力
            Console.Write("テストの点数を入力してください（0-100）:");
            int score = int.Parse(Console.ReadLine());
            if(score > 0 && score <= 100)
            {
                if (score >= 80)
                {
                    //  80点以上100点以下の場合
                    Console.WriteLine("優");
                }
                else if (score >= 70)
                {
                    //  80点未満70点以上の場合(80点以上の場合はすでに前のif文に該当)
                    Console.WriteLine("良");
                }
                else if (score >= 60)
                {
                    //  70点未満60点以上の場合(70点以上の場合はすでに前のif文に該当)
                    Console.WriteLine("可");
                }
                else
                {
                    //  60点未満0点以上の場合(60点以上の場合はすでに前のif文に該当)
                    Console.WriteLine("不可");
                }
            }
            else
            {
                //  以上のいずれにも該当しない場合（100より大きいか、0未満のいずれか）
                Console.WriteLine("不適切な値です");
            }
        }
    }
}
