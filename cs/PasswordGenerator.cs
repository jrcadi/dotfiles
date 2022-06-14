using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator {
    public class PasswordGenerator {
        private Random random;
        public PasswordGenerator(Random random){ //コンストラクタ
            this.random = random;
        }
        public string MakePassword(int count) {
		string password = string.Empty;
		Letter letter = new NumLetter(random);
		password += letter.GetLetter();
	
		letter = new LowerLetter(random);
		password += letter.GetLetter();
		
		letter = new UpperLetter(random);
		password += letter.GetLetter();

		letter = new MarkLetter(random);
		password += letter.GetLetter();
	
		return password;
        }
    
    }
}
