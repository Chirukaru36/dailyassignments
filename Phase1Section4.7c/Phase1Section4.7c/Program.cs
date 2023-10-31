using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._7c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            DoubleLinkedList doublyLinkedList = new DoubleLinkedList();
            doublyLinkedList.AddNode(1);
            doublyLinkedList.AddNode(2);
            doublyLinkedList.AddNode(3);

            Console.WriteLine("Doubly Linked List:");
            doublyLinkedList.DisplayList();

            Console.ReadLine();

        }
    }
}
