using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter2-1 クラスを使おう！（前半　P.47まで）
/// </summary>
namespace PasswordCreator {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int count = 12;
            PasswordGenerator generator = new PasswordGenerator();//インスタンスを生成
            string password = generator.MakePassword(random, count);
            Console.WriteLine(password);
        }
    }
}
