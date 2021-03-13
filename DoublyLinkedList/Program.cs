using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoublyLinkedList;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            //dll.insertAtBeginning(1);
            //dll.insertAtEnd(2);
            //dll.insertAtEnd(3);
            //dll.printList();
            //Console.WriteLine("\nLength is: " + dll.getLength());
            //dll.insertAtEnd(4);
            //dll.insertAtEnd(5);
            //dll.insertAtPosition(3, 10);
            //dll.printList();
            //Console.WriteLine("\nLength is: " + dll.getLength());
            //dll.reverseList();
            //dll.printList();
            //dll.head = new DoublyLinkedList.Node(10);
            dll.createList(8);
            //dll.generateTestList(8);
            dll.printList();
            dll.swapKthNode(3);
            dll.printList();
            Console.ReadKey();
        }
    }
}
