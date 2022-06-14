using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter2-1 クラスを使おう！（後半）
/// </summary>
namespace PasswordCreator {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int count = 12;
            //インスタンスの生成時にコンストラクターが呼び出される
            //PasswordGeneratorクラスのコンストラクターにはRandom型の引数が必要
            PasswordGenerator generator = new PasswordGenerator(random);
            string password = generator.MakePassword(count);
            Console.WriteLine(password);
        }
    }
}
