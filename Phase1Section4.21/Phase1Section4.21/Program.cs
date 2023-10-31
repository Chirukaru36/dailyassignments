using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            
        }

        static void runApp()
        {
            string[] students = { "Alice", "Bob", "Charlie", "David", "Eve" };

            Console.WriteLine("Original List of Students:");
            PrintStudents(students);

            
            BubbleSort(students);

            Console.WriteLine("\nSorted List of Students:");
            PrintStudents(students);
        }

        static void BubbleSort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                       
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintStudents(string[] arr)
        {
            foreach (var student in arr)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
 
