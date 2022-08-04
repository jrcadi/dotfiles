using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f = new Fighter();
            Airplane a = new Airplane();

            a.Fly();
            f.Fly();
            f.Fight();
        }
    }
}
