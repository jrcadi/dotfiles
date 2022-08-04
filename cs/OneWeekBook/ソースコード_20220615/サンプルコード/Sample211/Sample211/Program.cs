using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample211
{
    class Program
    {
        static void Main(string[] args)
        {
            //  キーボードから数値を入力
            Console.Write("1から3の整数を入力:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    //  numが1だった場合の処理
                    Console.WriteLine("one");    
                    break;
                case 2:
                    //  numが2だった場合の処理
                    Console.WriteLine("two");    
                    break;
                case 3:
                    //  numが3だった場合の処理
                    Console.WriteLine("three");  
                    break;
                default:
                    //  それ以外の値が入力された場合の処理
                    Console.WriteLine("不適切な値です。"); 
                    break;
            }
        }
    }
}
