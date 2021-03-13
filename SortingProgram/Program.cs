using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingProgram.Helper;

namespace SortingProgram
{
    class Program
    {
        private static Random _random = new Random();
        static void Main(string[] args)
        {
            //int[] arr = { 64, 25, 12, 22, 11 };
            //SelectionSort selectionSort = new SelectionSort();
            //InsertionSort insertionSort = new InsertionSort();
            //arr = selectionSort.sort(arr);
            //arr = new int[] { 64, 25, 12, 22, 11 };
            //int[] arr1 = insertionSort.sort2(arr);

            //ShellSort shellSort = new ShellSort();
            //arr = new int[] { 64, 25, 12, 22, 11, 33, 41, 121 };
            //int[] arr2 = shellSort.sort(arr);
            //string input = "SHELLSORTEXAMPLE";
            //char[] sortInput = new char[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    sortInput[i] = (char)(input[i]);
            //}
            //char[] arr2 = shellSort.sort(sortInput);

            MergeSort mergeSort = new MergeSort();
            int[] arr = new int[] { 64, 25, 12, 22, 11, 33, 41, 121 };
            mergeSort.sort(arr, 0, arr.Length - 1);
            int[] arr2 = arr;

            //QuickSort quickSort = new QuickSort();
            //int[] arr = new int[] { 64, 25, 12, 22, 11, 33, 41, 121 };
            //quickSort.sort(arr, 0, arr.Length - 1);
            //int[] arr2 = arr;


            int[] num = new int[1000000];
            
            for(int i=0; i<num.Length; i++)
            {
                num[i] = generateRandom();
            }

            int[] quick = num;
            int[] linear = num;
            var timer = new Stopwatch();
            timer.Start();
            int max = linear.Max();
            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            Console.WriteLine("Time taken for linear search: " + timeTaken.ToString(@"m\:ss\.fff"));


            var timer2 = new Stopwatch();
            timer2.Start();
            QuickSort quickSort = new QuickSort();
            quickSort.sort(quick, 0, quick.Length - 1);
            int max2 = quick[quick.Length - 1];
            timer2.Stop();

            TimeSpan timeTaken2 = timer2.Elapsed;
            Console.WriteLine("Time taken for quick sort: " + timeTaken2.ToString(@"m\:ss\.fff"));
            Console.ReadKey();
        }

        public static int generateRandom()
        {
            return _random.Next(0, 100);
        }
    }
}
