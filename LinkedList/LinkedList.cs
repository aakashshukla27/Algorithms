using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;

        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                this.data = d;
                this.next = null;
            }
        }

        /// <summary>
        /// Insert new node at the beginning
        /// </summary>
        /// <param name="new_data"></param>

        public void insertAtBeginning(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        /// <summary>
        /// Insert node at end
        /// </summary>
        /// <param name="new_data"></param>
        public void insertAtEnd(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            new_node.next = null;
            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = new_node;
            return;
        }
        /// <summary>
        /// Prints linked list
        /// </summary>
        public void displayList()
        {
            Node temp = head;
            while (temp.next != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.Write(temp.data);
            Console.WriteLine();
        }

        /// <summary>
        /// Return length of lined list
        /// </summary>
        public int getLength()
        {
            Node temp = head;
            if (temp == null)
            {
                return 0;
            }
            int counter = 1;
            while (temp.next != null)
            {
                temp = temp.next;
                counter++;
            }

            return counter;
        }

        /// <summary>
        /// insert new node in linkedlist at given position
        /// </summary>
        /// <param name="new_data"></param>
        /// <param name="position"></param>
        public void insertAtPosition(int new_data, int position)
        {
            if (position > getLength())
            {
                Console.WriteLine("Position cannot be higher than length");
                return;
            }
            Node newNode = new Node(new_data);
            Node temp = head;
            for (int i = 1; i < position - 1; i++)
            {
                temp = temp.next;
            }
            newNode.next = temp.next;
            temp.next = newNode;
        }
        /// <summary>
        /// Deleteing first occurance of data
        /// </summary>
        /// <param name="data"></param>
        public void deleteFirstOccurance(int data)
        {
            if (head == null)
            {
                return;
            }
            Node temp = head;
            /*
             * If head is equal to new data
             */
            if (head.data == data)
            {
                head.next = head;
                return;
            }
            Node prev = null;
            /*
             * Storing previous nodes data as well
             */
            while (temp != null)
            {
                if (temp.data == data)
                {
                    break;
                }
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
            temp = null;
            return;
        }
        /// <summary>
        /// delete node at nth position
        /// </summary>
        /// <param name="position"></param>
        public void deleteNode(int position)
        {
            if (position > getLength())
            {
                Console.WriteLine("Position higher tham list length");
                return;
            }
            if (position == 1)
            {
                head.next = head;
                return;
            }
            Node temp = head;
            Node prev = null;
            for (int i = 0; i < position - 1; i++)
            {
                prev = temp;
                temp = temp.next;
            }
            prev.next = temp.next;
            temp.next = null;
            return;
        }
        /// <summary>
        /// check if given value exists in linked list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>

        public bool checkIfExists(int data)
        {
            if (head == null)
            {
                return false;
            }
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        /// <summary>
        /// returns recursively the length of the linked list
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int getCountRecursive(Node node)
        {
            if (head == null)
            {
                return 0;
            }

            return 1 + getCountRecursive(node.next);
        }
        /// <summary>
        /// Driver method for recursive count
        /// </summary>
        /// <returns></returns>
        public int getLengthRecursive()
        {
            return getCountRecursive(head);
        }

        /// <summary>
        /// Reverses a given linked list
        /// </summary>

        public void reverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
        }

        /// <summary>
        /// Gets the middle of the linked list
        /// </summary>

        public void printMiddle()
        {
            Node slowPtr = head;
            Node fastPtr = head;
            if (head != null)
            {
                while (fastPtr != null && fastPtr.next != null)
                {
                    fastPtr = fastPtr.next.next;
                    slowPtr = slowPtr.next;
                }
                Console.WriteLine("Middle Node is " + slowPtr.data);
            }
        }

        /// <summary>
        /// Reverse input linked list
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public Node ReverseListPalindrome(Node input)
        {
            Node prev = null;
            Node current = input;
            Node next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        /// <summary>
        /// Function to compare 2 lists
        /// </summary>
        /// <param name="head1"></param>
        /// <param name="head2"></param>
        /// <returns></returns>

        public bool compareLists(Node head1, Node head2)
        {
            Node temp1 = head1;
            Node temp2 = head2;
            while (temp1 != null && temp2 != null)
            {
                if (temp1.data == temp2.data)
                {
                    temp1 = temp1.next;
                    temp2 = temp2.next;
                }
                else
                {
                    return false;
                }
            }

            if (temp1 == null && temp2 == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// Checks if list is a palidrome
        /// </summary>
        /// <returns></returns>
        public bool checkPalindrome()
        {
            if (head == null || getLength() == 1)
            {
                return true;
            }

            bool result = false;

            Node slowPtr = head;
            Node fastPtr = head;
            Node middleNode = null;
            Node prevSlowPtr = null;
            while (fastPtr != null && fastPtr.next != null)
            {
                fastPtr = fastPtr.next.next;
                prevSlowPtr = slowPtr;
                slowPtr = slowPtr.next;
            }

            if (fastPtr != null)
            {
                middleNode = slowPtr;
                slowPtr = slowPtr.next;
            }

            Node secondHalf = slowPtr;
            prevSlowPtr.next = null;
            secondHalf = ReverseListPalindrome(secondHalf);
            Node firstHalf = head;
            result = compareLists(firstHalf, secondHalf);
            secondHalf = ReverseListPalindrome(secondHalf);
            if (middleNode != null)
            {
                prevSlowPtr.next = middleNode;
                middleNode.next = secondHalf;
            }
            else
            {
                prevSlowPtr.next = secondHalf;
            }


            return result;


        }


        public bool cycleDetection()
        {
            Node temp = head;
            List<Node> list = new List<Node>();
            list.Add(temp);
            temp = temp.next;
            while (temp != null)
            {
                if (list.Contains(temp))
                {
                    return true;
                }
                else
                {
                    temp = temp.next;
                }
            }

            return false;

        }


        public void SegregateList(Node input)
        {
            Node temp = input;

            Node prev = null;
            while (temp != null)
            {
                prev = temp;
                temp = temp.next;
            }

            Node lastNode = prev;
            temp = input;


            Node firstEven = null;
            while (temp != null)
            {

                if (temp.data % 2 == 0)
                {

                    if (firstEven == null)
                    {
                        firstEven = temp;
                    }
                    temp = temp.next;
                }
                if (temp.data % 2 == 1)
                {
                    Node temp2 = temp;
                    temp = temp.next;
                    temp2.next = null;
                    lastNode.next = temp2;
                }
            }
        }

    }
}
