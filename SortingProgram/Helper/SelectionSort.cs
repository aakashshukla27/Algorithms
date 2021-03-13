using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProgram.Helper
{
    public class SelectionSort
    {
        public int[] sort(int[] input)
        {
            int n = input.Length;

            for(int i=0; i<n-1  ; i++)
            {
                int minIndex = i;
                for(int j=i+1; j < n; j++)
                {
                    if(input[j] < input[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = input[minIndex];
                input[minIndex] = input[i];
                input[i] = temp;
            }
            return input;
        }
    }
}
