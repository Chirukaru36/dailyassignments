using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            Console.WriteLine("Array Demo: Storing Students and Marks");

            
            string[] students = new string[5];
            double[] marks = new double[5];

            
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the name of student {i + 1}: ");
                students[i] = Console.ReadLine();

                Console.Write($"Enter the mark for {students[i]}: ");
                double mark;
                if (double.TryParse(Console.ReadLine(), out mark))
                {
                    marks[i] = mark;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid mark.");
                    i--; 
                }
            }

            Console.WriteLine("Students and Their Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{students[i]}: {marks[i]}");
            }

            Console.ReadLine();
        }
    }
}
 
