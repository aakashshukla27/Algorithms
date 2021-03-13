using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProgram.Helper
{
    public class InsertionSort
    {
        public int[] sort(int[] input)
        {
            int n = input.Length;
            for(int i=1; i < n; i++)
            {
                int space = i;
                int key = input[i];
                for(int j = space-1; j>=0; j--)
                {
                    if(input[j] > key)
                    {
                        input[j + 1] = input[j];
                        space = j;
                        continue;
                    }
                    break;
                }
                input[space] = key;
            }


            return input;
        }

        public int[] sort2(int[] input)
        {
            int n = input.Length;

            for(int i = 1; i < n; i++)
            {
                for(int j=i; j>0 && input[j] < input[j-1]; j--)
                {
                    int temp = input[j];
                    input[j] = input[j - 1];
                    input[j - 1] = temp;
                }
            }
            return input;
        }
    }
}
