using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("あなたの姓を入力してください：");
            string n1 = Console.ReadLine();
            Console.Write("あなたの名を入力してください：");
            string n2 = Console.ReadLine();
            //  姓と名をつなげることによってフルネームを得る
            string name = n1 + n2;
            Console.WriteLine("あなたは{0}さんですね。",name);
        }
    }
}
