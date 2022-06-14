using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter4-4 デリゲート
/// </summary>
namespace DelegateTraining {
    class Program {
        static void Main(string[] args) {
            var calculation = new Calculation();
            int ans = calculation.Execute(9);
            Console.WriteLine(ans);
        }
    }
}
