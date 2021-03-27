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

        /// <summary>
        /// Delete node in a binary tree
        /// Traverse till end and store
        /// node to delete and last node
        /// </summary>
        /// <param name="head"></param>
        /// <param name="data"></param>

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
            /*
             * Replace the node to be deleted's data with data of last node
             */
            
            if (keyNode != null)
            {
                int x = temp.data;
                deleteDeepest(temp);
                keyNode.data = x;
            }
        }

        /// <summary>
        /// Delete deepest node of a tree
        /// </summary>
        /// <param name="delNode"></param>
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
        /// <summary>
        /// Get size of tree
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int getSize(Node head)
        {
            if(head == null)
            {
                return 0;
            }
            else
            {
                return (getSize(head.left) + 1 + getSize(head.right));
            }
        }

        /// <summary>
        /// Printing the last node at every level
        /// </summary>
        /// <param name="head"></param>
        public void rightView(Node head)
        {
            if(head == null)
            {
                return;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(head);

            while(queue.Count != 0)
            {
                int n = queue.Count;
                for(int i=1; i <= n; i++)
                {
                    Node temp = queue.Dequeue();
                    if(i == n)
                    {
                        Console.Write(temp.data + " ");
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
            }            
        }


        /// <summary>
        /// Left View of Binary Tree
        /// </summary>
        /// <param name="head"></param>

        public void leftView(Node head)
        {
            if (head == null)
            {
                return;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(head);

            while (queue.Count != 0)
            {
                int n = queue.Count;
                for (int i = 1; i <= n; i++)
                {
                    Node temp = queue.Dequeue();
                    if (i == 1)
                    {
                        Console.Write(temp.data + " ");
                    }

                   
                    if (temp.left != null)
                    {
                        queue.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        queue.Enqueue(temp.right);
                    }
                }
            }
        }

        /// <summary>
        /// Find maximum node in binary tree
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int findMaxNode(Node head)
        {
            if (head == null)
                return 0;

            int result = head.data;
            int leftMax = findMaxNode(head.left);
            int rightMax = findMaxNode(head.right);
            return Math.Max(result, Math.Max(leftMax, rightMax));
        }

        /// <summary>
        /// Find minimum node in binary tree
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int findMinNode(Node head)
        {
            if(head == null)
            {
                return 0;
            }
            int result = head.data;
            int leftMin = findMinNode(head.left);
            int rightMin = findMinNode(head.right);
            return Math.Min(result, Math.Min(leftMin, rightMin));
        }

        //Inorder traversal without recursion
        public void inorderTraversalWithoutRecursion(Node head)
        {
            if(head == null)
            {
                return;
            }

            Stack<Node> s = new Stack<Node>();
            Node current = head;

            while (current != null || s.Count > 0)
            {
                while (current != null)
                {
                    s.Push(current);
                    current = current.left;
                }


                current = s.Pop();

                Console.Write(current.data + " ");

                current = current.right;
            }
        }

        /// <summary>
        /// Print ancestors of given target value
        /// </summary>
        /// <param name="head"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool printAncestors(Node head, int target)
        {
            if(head == null)
            {
                return false;
            }
            if(head.data == target)
            {
                return true;
            }

            if(printAncestors(head.left, target) || printAncestors(head.right, target))
            {
                Console.Write(head.data + " ");
                return true;
            }

            
            return false;
        }
        
        /// <summary>
        /// Recursive method to find height of binary tree
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int findHeight(Node head)
        {
            if(head == null)
            {
                return 0;
            }
            
            int leftMax = findHeight(head.left);
            int rightMax = findHeight(head.right);

            leftMax += 1;
            rightMax += 1;

            return Math.Max(leftMax, rightMax);

        }


        /// <summary>
        /// Class used for printing top view
        /// </summary>
        public class QueueNode
        {
            public Node node;
            public int level;
            public QueueNode(Node node, int level)
            {
                this.node = node;
                this.level = level;
            }
        }


        /// <summary>
        /// printing top view of binary tree
        /// </summary>
        /// <param name="head"></param>
        public void topView(Node head)
        {
            Queue<QueueNode> queue = new Queue<QueueNode>();
            SortedDictionary<int, int> map = new SortedDictionary<int, int>();
            queue.Enqueue(new QueueNode(head, 0));
            while (queue.Count > 0)
            {
                
                QueueNode r = queue.Dequeue();

                if (!map.ContainsKey(r.level))
                {
                    map.Add(r.level, r.node.data);
                }

                
                if (r.node.left != null)
                {
                    queue.Enqueue(new QueueNode(r.node.left, r.level - 1));
                }
                if (r.node.right != null)
                {
                    queue.Enqueue(new QueueNode(r.node.right, r.level + 1));
                }
            }

            foreach(int value in map.Values)
            {
                Console.WriteLine(value + " ");
            }


        }

       

    }


}
