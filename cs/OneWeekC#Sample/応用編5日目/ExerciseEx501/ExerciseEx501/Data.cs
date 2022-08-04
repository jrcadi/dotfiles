using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx501
{
    class Data : IWrite,IRead
    {
        //  データ
        private int num = 0;
        public void Write(int num)
        {
            this.num = num;
        }
        public int Read()
        {
            return num;
        }
    }
}
