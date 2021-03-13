using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProgram.Helper
{
    public class MergeSort
    {
       
        public void sort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int mid = (low + high) / 2;
                sort(arr, low, mid);
                sort(arr, mid + 1, high);
                merge(arr, low, mid, high);
            }
        }

        public void merge(int[] arr, int low, int mid, int high)
        {
            int[] temp = new int[high - low + 1];
            int i = low, j = mid + 1, k = 0;

            while(i<=mid && j <= high)
            {
                if(arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                    k++;
                }
            }
            while(i<= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }
            while(j<= high)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }
            for(i = low; i<= high; i++)
            {
                arr[i] = temp[i - low];
            }
        }
    }
}
