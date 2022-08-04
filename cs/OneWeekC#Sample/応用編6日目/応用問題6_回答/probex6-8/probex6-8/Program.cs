using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["cat"] = "猫";
            data["dog"] = "犬";
            data["bird"] = "鳥";
            data["tiger"] = "トラ";

            Console.Write("英語で動物の名前を入力してください：");
            string animal = Console.ReadLine();

            if(data.ContainsKey(animal))
            {
                Console.WriteLine("「" + data[animal] + "」です。");
            }
            else
            {
                Console.WriteLine("対応するデータは登録されていません。");
            }
               
        }
    }
}
