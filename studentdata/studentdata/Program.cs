using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdata
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Grade: {Grade}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string[] lines = File.ReadAllLines("C:\\Users\\pooja\\OneDrive\\Desktop\\.Net class Assignments\\Students.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Student student = new Student
                {
                    Name = parts[0],
                    Age = int.Parse(parts[1]),
                    Grade = parts[2]

                };

                students.Add(student);

                foreach (Student Students in students)
                {
                    Console.WriteLine($"Name: {Students.Name}, Roll Number: {Students.Age}, Grade: {Students.Grade}");
                }
            }
            Console.ReadLine();
        }
    }
}
