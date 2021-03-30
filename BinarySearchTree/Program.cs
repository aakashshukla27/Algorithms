using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    class Program
    {
        private static Random _random = new Random();
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            int[] num = new int[50];
            //int[] num = { 10, 5, 1, 7, 40, 50, };
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = generateRandom();
            }


            for (int i = 0; i < num.Length; i++)
            {
                bst.create(num[i]);
            }

            bst.Print();


            bst.searchKey(10);


            Console.ReadKey();
        }
        public static int generateRandom()
        {
            return _random.Next(0, 100);
        }
    }
   
}
