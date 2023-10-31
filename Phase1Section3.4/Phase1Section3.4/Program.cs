using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
           
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            double[] doubleArray = new double[] { 12354.156, 2678.2789, 31234.35667, 44566.4987, 51234.598765 };
            char[] charArray = new char[] { 'A', 'B', 'C', 'D', 'E' };
            bool[] boolArray = new bool[] { true, false, true, false, true };
            


            
            int sum = intArray.Sum();
            double average = doubleArray.Average();
            char firstChar = charArray[0];
            bool isTrue = boolArray[0];

           
            Console.WriteLine("Sum of integers: " + sum);
            Console.WriteLine("Average of doubles: " + average);
            Console.WriteLine("First character: " + firstChar);
            Console.WriteLine("Is the first boolean true? " + isTrue);
        }
    }
}

