using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceproject
{
    
            struct Student
        {
            public int Assessment;
            public string Name;
            public string Class;
            public string Section;
        }

        struct Teacher
        {
            public string ReferenceMaterials;
            public string Name;
            public string ExamPreparation;
            public string Documents;
            public string Class;
            public string Section;
        }

        struct Subject
        {
            public string Books;
            public int SubjectCode;
            public string Name;
            public string LabGuides;
            public Teacher AssignedTeacher;
        }

        class Program
        {
            static void Main()
            {
                List<Student> students = new List<Student>();
                List<Teacher> teachers = new List<Teacher>();
                List<Subject> subjects = new List<Subject>();

       
                students.Add(new Student { Assessment = 1, Name = "Rani", Class="10",Section = " A" });
                students.Add(new Student { Assessment = 2, Name = "Chaithra", Class  = "12",Section = "B" });

                teachers.Add(new Teacher { ReferenceMaterials = "Materials 1", Name = "Teacher 1", ExamPreparation = "Preparation 1", Documents = "Docs 1", Class="10",Section = "A" });
                teachers.Add(new Teacher { ReferenceMaterials = "Materials 2", Name = "Teacher 2", ExamPreparation = "Preparation 2", Documents = "Docs 2", Class="12",Section = "B" });

                subjects.Add(new Subject { Books = "Books 1", SubjectCode = 101, Name = "Kannada", LabGuides = "Guides 1", AssignedTeacher = teachers[0] });
                subjects.Add(new Subject { Books = "Book2", SubjectCode = 102, Name = "English", LabGuides = "Guides 2", AssignedTeacher = teachers[1] });

           
                Console.WriteLine("Students in Class A:");
                foreach (var student in students)
                {
                    if (student.Section == "A")
                    {
                        Console.WriteLine($"{student.Name},Assessment:{student.Assessment}");
                    }
                }

 
                string teacherNameToSearch = "Teacher 1";
                Console.WriteLine($"Subjects taught by {teacherNameToSearch}:");
                foreach (var subject in subjects)
                {
                    if (subject.AssignedTeacher.Name == teacherNameToSearch)
                    {
                     Console.WriteLine($"Subject name:{subject.Name}," +
                         $"Subject Code:{subject.SubjectCode}");
                    }

                    Console.ReadLine();
                }
            }
        }
}

