using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            string[] students = { "pooja", "neha", "Chaithra", "ruchi", "rani" };

            Console.WriteLine("Unsorted Students:");
            PrintStudents(students);

            
            SelectionSort(students);

            Console.WriteLine("\nSorted Students:");
            PrintStudents(students);
        }

        static void SelectionSort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j].CompareTo(arr[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    
                    string temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        static void PrintStudents(string[] arr)
        {
            foreach (string student in arr)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
 
