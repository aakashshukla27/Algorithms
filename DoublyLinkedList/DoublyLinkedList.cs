using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        public Node head;
        Random random = new Random();
        public class Node
        {
            public int data;
            public Node prev;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.prev = null;
                this.next = null;
            }
        }
        /// <summary>
        /// Inserts new node at the beginning of the doubly linked list 
        /// </summary>
        /// <param name="data"></param>
        public void insertAtBeginning(int data)
        {
            Node new_node = new Node(data);           
            new_node.next = head;
            head = new_node;
            new_node.prev = null;
        }
        /// <summary>
        /// Inserts new node at the end of the doubly linked list
        /// </summary>
        /// <param name="data"></param>
        public void insertAtEnd(int data)
        {
            Node new_node = new Node(data);
            if(head == null)
            {
                head = new_node;
                return;
            }
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new_node;
            new_node.prev = temp;
        }

        /// <summary>
        /// Prints the double linked list
        /// </summary>
        public void printList()
        {
            Node temp = head;
            Console.WriteLine("\nPrinting Doubly Linked List");
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        /// <summary>
        /// Gets the length of the doubly linked list
        /// </summary>
        /// <returns></returns>
        public int getLength()
        {
            Node temp = head;
            if(temp == null)
            {
                return 0;
            }
            int count = 0;
            while(temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        /// <summary>
        /// Inserts at given position in doubly linked list
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void insertAtPosition(int position, int data)
        {
            Node temp = head;
            if(position == 1)
            {
                insertAtBeginning(data);
                return;
            }
            int count = 1;
            while(count < position)
            {
                temp = temp.next;
                count++;
            }
            Node new_node = new Node(data);
            temp.prev.next = new_node;
            new_node.prev = temp.prev;
            new_node.next = temp;
            temp.prev = new_node;
        }

        /// <summary>
        /// Reverses the doubly linked list
        /// </summary>
        public void reverseList()
        {
            Node temp = null;
            Node current = head;
            while(current != null)
            {
                temp = current.prev;
                current.prev = current.next;
                current.next = temp;
                current = current.prev;
            }

            head = temp.prev;
        }

        /// <summary>
        /// Generates a doubly linked list
        /// </summary>
        /// <param name="length"></param>
        public void createList(int length)
        {
            Node temp = head;
            if(temp == null)
            {
                Node new_node = new Node(generateRandom());
                head = new_node;
                createList(length - 1);
                return;
            }
            for(int i=0; i<length; i++)
            {
                Node new_node = new Node(generateRandom());
                temp.next = new_node;
                new_node.prev = temp;
                new_node.next = null;
                temp = temp.next;                
            }

        }

        
        /// <summary>
        /// Generates random numbers for doubly linked list
        /// </summary>
        /// <returns></returns>
        public int generateRandom()
        {
            return random.Next(1, 100);
        }


        public void swapKthNode(int position)
        {
            int totalLength = getLength();
            if(position > totalLength)
            {
                Console.WriteLine("Position greater than length. Program terminated.");
                return;
            }
           

            int firstPosition = position;
            int secondPosition = totalLength - position + 1;
            Node node1 = head, node2 = head;
            Node node1Prev = null, node2Prev = null;

            for(int i=0; i<secondPosition; i++)
            {
                if(i < firstPosition - 1) // make this -1
                {
                    node1Prev = node1;
                    node1 = node1.next;
                }
                if(i < secondPosition - 1)
                {
                    node2Prev = node2;
                    node2 = node2.next;
                }
            }
            
            Node newNode = node2.next;
            node1Prev.next = node2;
            node2.prev = node1Prev;
            node2.next = node1.next;
            node1.next.prev = node2;
            
            node2Prev.next = node1;
            node1.prev = node2Prev;
            node1.next = newNode;
            newNode.prev = node1;


        }


        public void generateTestList(int length)
        {
            head = new Node(1);
            Node temp = head;
            for(int i=2; i<=length; i++)
            {
                Node new_node = new Node(i);
                temp.next = new_node;
                new_node.prev = temp;
                temp = temp.next;
            }
        }
        


    }
}
