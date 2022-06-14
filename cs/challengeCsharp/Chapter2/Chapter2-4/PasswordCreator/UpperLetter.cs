using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace PasswordCreator {
    class UpperLetter : Letter {
        public UpperLetter(Random random) : base(random) {
        }
        public override string GetLetter() {
            char c = (char)random.Next(65, 91);
            return c.ToString();
        }
    }
}