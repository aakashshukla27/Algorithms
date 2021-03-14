using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.right = null;
            this.left = null;
        }
    }
    public class BinaryTree
    {
        public Node root;
        public BinaryTree(int data)
        {
            root = new Node(data);
        }
        public BinaryTree()
        {
            root = null;
        }

        public void inorderTraversal(Node head)
        {
            if(head == null)
            {
                return;
            }
            Node temp = head;
            inorderTraversal(temp.left);
            Console.Write(temp.data + " ");
            inorderTraversal(temp.right);
        }

        public void preOrderTraversal(Node head)
        {
            if(head == null)
            {
                return;
            }
            Node temp = head;
            Console.Write(temp.data + " ");
            preOrderTraversal(temp.left);
            preOrderTraversal(temp.right);
        }

        public void postOrderTraversal(Node head)
        {
            if(head == null)
            {
                return;
            }
            Node temp = head;
            postOrderTraversal(temp.left);
            postOrderTraversal(temp.right);
            Console.Write(temp.data + " ");
        }

        public void insertInBinaryTree(Node head, int data)
        {
            if(head == null)
            {
                root = new Node(data);
                return;
            }

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(head);
            while(q.Count != 0)
            {
                head = q.Peek();
                q.Dequeue();
                if(head.left == null)
                {
                    head.left = new Node(data);
                    break;
                }
                else
                {
                    q.Enqueue(head.left);
                }

                if(head.right == null)
                {
                    head.right = new Node(data);
                    break;
                }
                else
                {
                    q.Enqueue(head.right);
                }
            }
        }

        public Node Root { get { return root; } }

        public void Print()
        {
            Root.Print();
        }

    }


}
