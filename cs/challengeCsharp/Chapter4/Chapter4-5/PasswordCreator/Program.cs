using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter2-6 静的メソッドを使おう！
/// </summary>
namespace PasswordCreator {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int count = 12;
            ILetterFactory factory = new AllLetterFactory();
            //ILetterFactory factory = new NonMarkLetterFactory();
            PasswordGenerator generator = new PasswordGenerator(random);
            string password = generator.MakePassword(count, factory);
            Console.WriteLine(password);
        }
    }
}
