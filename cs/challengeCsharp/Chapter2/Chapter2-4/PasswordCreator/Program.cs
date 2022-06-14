using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter2-4 抽象クラスを使おう！
/// </summary>
namespace PasswordCreator {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int count = 12;
            LetterFactory factory = new AllLetterFactory(); //記号を含むパスワード
            //LetterFactory factory = new NonMarkLetterFactory(); //記号を含まないパスワード
            PasswordGenerator generator = new PasswordGenerator(random);
            string password = generator.MakePassword(count, factory);
            Console.WriteLine(password);
        }
    }
}
