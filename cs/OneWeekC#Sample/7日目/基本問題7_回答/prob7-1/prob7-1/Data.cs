using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob7_1
{
    class Data
    {
        private int number = 0;
        private string comment = "";

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
            }
        }
    }
}
