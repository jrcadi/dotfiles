using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Dog();
            animals[1] = new Monkey();

            for(int i = 0; i < animals.Length; i++)
            {
                animals[i].ShowName();
                animals[i].Move();
                animals[i].Bark();
                Console.WriteLine("------------");
            }
        }
    }
}
