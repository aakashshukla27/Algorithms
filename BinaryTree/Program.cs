using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree(10);
            
            Node node0 = binaryTree.root;
            for(int i = 20; i<= 100; i += 10)
            {
                binaryTree.insertInBinaryTree(node0, i);
            }
            
            //Console.WriteLine("\nInorder traversal");
            //binaryTree.inorderTraversal(node0);
            //Console.WriteLine("\nPreorder traversal");
            //binaryTree.preOrderTraversal(node0);
            //Console.WriteLine("\nPostorder traversal");
            //binaryTree.postOrderTraversal(node0);

           
            binaryTree.Print();

            //Level order traversal

            //binaryTree.levelOrderTraversal(node0);

            binaryTree.deleteNode(node0, 40);
            binaryTree.Print();
            Console.ReadKey();
        }
    }
}
