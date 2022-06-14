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
            NumOfLetters = 12;
        }
        public int NumOfLetters { get; set; } 
        private bool isNonMark;
        public bool IsNonMark {        //NonMarkに対応
            get { return isNonMark; }
            set { isNonMark = value; 
                    if(isNonMark)  factory = new NonMarkLetterFactory();
            }
        }
        private bool isAll;
        public bool IsAll {                 //Allに対応
            get { return isAll; }
            set { isAll = value;
                    if (isAll)  factory = new AllLetterFactory();
            }
        }
        private bool isMark2;
        public bool IsMark2 {           //Mark2に対応
            get { return isMark2; }
            set { isMark2 = value;
                    if (isMark2)  factory = new Mark2LetterFactory();
            }
        }
        public string MakePassword() {
            var generator = new PasswordGenerator(random);
            return generator.MakePassword(NumOfLetters, factory);
        }
    }
}
