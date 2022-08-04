using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex2_4
{
    class Counter
    {
        private int count = 0;

        private static int totalCount = 0;

        public void Reset()
        {
            totalCount -= count;
            count = 0;
        }

        public void Increment()
        {
            count++;
            totalCount++;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public static int TotalCount
        {
            get
            {
                return totalCount;
            }
        }

    }
}
