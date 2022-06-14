using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 紛らわしい文字の排除
/// 大文字OとI,小文字のl を使わない
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
