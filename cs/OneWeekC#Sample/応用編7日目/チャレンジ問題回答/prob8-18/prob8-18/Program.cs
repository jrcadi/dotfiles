using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[50];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = 1;
            }

            for(int i = 1; i <= data.Length; i++)
            {
                for (int j = 1; j <= data.Length; j++)
                {
                    if(j % i == 0)
                    {
                        data[j - 1] = data[j - 1] * -1;
                    }
                }
            }

            int cnt = 0;
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] == -1)
                {
                    cnt++;
                }
            }
            Console.WriteLine("開いているロッカーは{0}個です", cnt);
        }
    }
}
