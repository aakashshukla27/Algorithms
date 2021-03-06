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
            Console.WriteLine("\nSize: " + binaryTree.getSize(node0));
            Console.WriteLine("\nRight view of tree\n");
            binaryTree.rightView(node0);
            Console.WriteLine("\nLeft view of tree\n");
            binaryTree.leftView(node0);
            
            Console.WriteLine("\nMaximum Item is: " + binaryTree.findMaxNode(node0));
            binaryTree.printAncestors(node0, 60);
            Console.WriteLine("\nHeight of tree");
            Console.WriteLine(binaryTree.findHeight(node0));

            binaryTree.topView(node0);


            Console.ReadKey();
        }
    }
}
