using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProblem407
{
    class Student
    {
        //  名前
        private string name;
        //  学年
        private int grade;
        //  年齢
        private int age;
        public Student(string name, int grade, int age)
        {
            SetInformation(name,grade,age);
        }
        //  学生情報の設定
        public void SetInformation(string name, int grade, int age)
        {
            this.name = name; this.grade = grade; this.age = age;
        }
        //  学生情報の表示
        public void ShowInformation()
        {
            Console.WriteLine("名前:{0} 学年:{1} 年齢:{2}", name, grade, age);
        }

    }
}
