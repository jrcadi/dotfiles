using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob6_1
{
    class MinMax
    {
        public int Max(int n1, int n2, int n3)
        {
            if(n1 > n2)
            {
                if (n3 > n1)
                {
                    return n3;
                }
                return n1;
            }
            else
            {
                if(n3 > n2)
                {
                    return n3;
                }
                return n2;
            }
        }

        public int Min(int n1, int n2, int n3)
        {
            if(n1 < n2)
            {
                if(n3 < n1)
                {
                    return n3;
                }
                return n1;
            }
            else
            {
                if(n3 < n2)
                {
                    return n3;
                }
                return n2;
            }
        }
    }
}
