using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordCreator;

namespace PasswordCreatorUI {
    public class Controller {
        private Random random;
        private ILetterFactory factory;
        public Controller() {
            this.random = new Random();
            factory = new AllLetterFactory();
        }
        public int NumOfLetters { get; set; } = 12;
        public string MakePassword() {
            var generator = new PasswordGenerator(random);
            return generator.MakePassword(NumOfLetters, factory);
        }
    }
}
