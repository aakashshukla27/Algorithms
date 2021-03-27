using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTreeArray
    {
        int root = 0;
        int[] tree;

        public void createTree(int size)
        {
            for(int i=0; i<size; i++)
            {
                tree[i] = i;
            }

            int[] temp = new int[10];
            int test = temp.Length;
        }

        public void printTree()
        {

        }
    }
}
