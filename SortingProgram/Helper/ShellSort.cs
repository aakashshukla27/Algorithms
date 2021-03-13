using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProgram.Helper
{
    class ShellSort
    {
        public char[] sort(char[] ip)
        {
            int n = ip.Length;
            int h = 1;
            while(h < n/3)
            {
                h = (3 * h) + 1;
            }
            while (h >= 1)
            {
                for (int i = h; i < n; i++)
                {
                    for (int j = i; j >= h && (ip[j] < ip[j - h]); j = j - h)
                    {
                        char temp = ip[j];
                        ip[j] = ip[j - h];
                        ip[j - h] = temp;
                        
                    }
                }
                h = h / 3;
            }
            return ip;
        }
    }
}
