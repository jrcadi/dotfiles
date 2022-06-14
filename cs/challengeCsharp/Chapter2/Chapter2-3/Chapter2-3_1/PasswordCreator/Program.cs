using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter2-3 ポリモーフィズムを使おう！（前半　P.64まで）
/// PasswordGeneratorクラスのコードを変更したが、このクラスのMainメソッド内のコードに変更はない
/// </summary>
namespace PasswordCreator {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int count = 12;
            PasswordGenerator generator = new PasswordGenerator(random);
            string password = generator.MakePassword(count);
            Console.WriteLine(password);
        }
    }
}
