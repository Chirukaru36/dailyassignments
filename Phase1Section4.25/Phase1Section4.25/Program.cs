using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._25
{
    internal class Program

    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Student(string name, int age)
            {
                Name = name;
                Age = age;


            }
            static void Main(string[] args)
            {
                runApp();
            }

            static void runApp()
            {
                // Create an array of students to sort
                Student[] students = {
                new Student("John", 25),
                new Student("Alice", 22),
                new Student("Bob", 28),
                new Student("Eve", 20)
            };

                Console.WriteLine("Unsorted Students:");
                PrintStudents(students);

                // Perform Insertion Sort
                InsertionSort(students);

                Console.WriteLine("\nSorted Students:");
                PrintStudents(students);
            }

            static void InsertionSort(Student[] arr)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    Student key = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j].Age > key.Age)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = key;
                }
            }

            static void PrintStudents(Student[] arr)
            {
                foreach (var student in arr)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
                }


                Console.ReadLine();
            }

            
        }
    }
}

         
    

    
    

  
