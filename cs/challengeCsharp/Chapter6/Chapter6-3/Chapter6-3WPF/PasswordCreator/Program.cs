using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter6-2 パスワードの末尾を記号にする
/// </summary>
namespace PasswordCreator {
    class Program {
        static void Main(string[] args) {
            int count = 12;
            ILetterFactory factory = new AllLetterFactory();
            Random random = new Random();
            PasswordGenerator generator = new PasswordGenerator(random);
            string pw = generator.MakePassword(count, factory);
            Console.WriteLine(pw);
        }
    }
}
