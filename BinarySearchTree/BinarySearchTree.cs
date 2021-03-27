using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinarySearchTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree(int data)
        {
            root = new Node(data);
        }

        public BinarySearchTree()
        {
            root = null;
        }

        public void Print()
        {
            if (root == null)
                root = node;
            root.Print();
        }

        private Node search(Node head, int key)
        {
            if(head == null || head.data == key)
            {
                return root;
            }
            if(head.data < key)
            {
                return search(head.right, key);
            }
            else
            {
                return search(head.left, key);
            }
           
        }

        public Node searchKey(int data)
        {
            return search(root, data);
        }


        #region Create Binary Search Tree from preorder traversal
        private Node node;
        public Node createNode(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
            }

            if (node.data > data)
            {
                node.left = createNode(node.left, data);
            }

            if (node.data < data)
            {
                node.right = createNode(node.right, data);
            }
            return node;
        }

        public void create(int data)
        {
            node = createNode(node, data);
            node.Print();
        }

        public void PrintInorderTree()
        {
            node.Print();
        }


        #endregion



    }


}
