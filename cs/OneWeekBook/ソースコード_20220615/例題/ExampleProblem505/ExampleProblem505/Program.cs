using System;

namespace ExampleProblem505
{
    class Program
    {
        static void Main(string[] args)
        {
            //  哺乳類クラスのオブジェクトの配列を生成
            Mammals[] animals = new Mammals[2];
            animals[0] = new Cat();     //  猫クラスのインスタンス生成
            animals[1] = new Mice();    // ネズミクラスのインスタンスの生成
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].ShowName();
                animals[i].Bark();
                Console.WriteLine("------------");
            }
        }
    }
}
