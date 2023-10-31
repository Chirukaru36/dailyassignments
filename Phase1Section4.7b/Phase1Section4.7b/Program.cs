using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._7b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            SingleLinkedList myList = new SingleLinkedList();

            myList.AddNode(1);
            myList.AddNode(2);
            myList.AddNode(3);

            Console.WriteLine("Linked List: ");
            myList.DisplayList();

            Console.ReadLine();
        }
    }
}

