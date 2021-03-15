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

        /// <summary>
        /// Inorder traversal left -> root -> right
        /// </summary>
        /// <param name="head"></param>

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

        /// <summary>
        /// preorder traversal root -> left -> right
        /// </summary>
        /// <param name="head"></param>

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

        /// <summary>
        /// postorder traversal left -> right -> root
        /// </summary>
        /// <param name="head"></param>
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


        //public Node Root { get { return root; } }

        

        /// <summary>
        /// Prints the tree
        /// </summary>
        public void Print()
        {
            root.Print();
        }

       
        /// <summary>
        /// Level order traversal of binary tree
        /// </summary>
        /// <param name="head"></param>
        public void levelOrderTraversal(Node head)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(head);
            Console.WriteLine("\nLevel Order Traverasal");
            while(queue.Count != 0)
            {
                Node temp = queue.Dequeue();
                Console.Write(temp.data + " ");
                if(temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if(temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }

        }

        /// <summary>
        /// Inserting node via level order traversal
        /// Iterating through every level and searching for null left and right children in tree
        /// </summary>
        /// <param name="head"></param>
        /// <param name="data"></param>
        public void insertInBinaryTree(Node head, int data)
        {
            if(head == null)
            {
                root = new Node(data);
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(head);
            while(queue.Count != 0)
            {
                Node temp = queue.Dequeue();                
                if(temp.left == null)
                {
                    temp.left = new Node(data);
                    break;
                }
                else
                {
                    queue.Enqueue(temp.left);
                }
                if(temp.right == null)
                {
                    temp.right = new Node(data);
                    break;
                }
                else
                {
                    queue.Enqueue(temp.right);
                }
            }
        }

        public void deleteNode(Node head, int data)
        {
            if (head == null)
                return;
            if(root.left == null && root.right == null)
            {
                if (root.data == data)
                    return;
                else
                    return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(head);
            Node temp = null, keyNode = null;
            while(queue.Count != 0)
            {
                temp = queue.Dequeue();
                if(temp.data == data)
                {
                    keyNode = temp;
                }
                if(temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if(temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }

            if(keyNode != null)
            {
                int x = temp.data;
                deleteDeepest(temp);
                keyNode.data = x;
            }
        }

        public void deleteDeepest(Node delNode)
        {
            Node temp = root;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(temp);
            while(queue.Count != 0)
            {
                temp = queue.Dequeue();
                if(temp == delNode)
                {
                    temp = null;
                    return;
                }
                if(temp.right != null)
                {
                    if(temp.right == delNode)
                    {
                        temp.right = null;
                        return;
                    }
                    else
                    {
                        queue.Enqueue(temp.right);
                    }
                }
                if(temp.left != null)
                {
                    if(temp.left == delNode)
                    {
                        temp.left = null;
                        return;
                    }
                    else
                    {
                        queue.Enqueue(temp.left);
                    }
                }
            }
        }

    }


}
