using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "personData.txt";

            // 1) Create a text file and store person data in it
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                Console.Write("Enter Person Name: ");
                string personName = Console.ReadLine();

                Console.Write("Enter Person Address: ");
                string personAddress = Console.ReadLine();

                Console.Write("Enter City: ");
                string city = Console.ReadLine();

                Console.Write("Enter Country: ");
                string country = Console.ReadLine();

                writer.WriteLine($"{personName},{personAddress},{city},{country}");
            }

            // 2) Read the data from the file
            Console.WriteLine("Data from the file:");
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }

            // 3) Append one more record to it
            using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                Console.WriteLine("Enter additional person data:");

                Console.Write("Enter Person Name: ");
                string personName = Console.ReadLine();

                Console.Write("Enter Person Address: ");
                string personAddress = Console.ReadLine();

                Console.Write("Enter City: ");
                string city = Console.ReadLine();

                Console.Write("Enter Country: ");
                string country = Console.ReadLine();

                writer.WriteLine($"{personName},{personAddress},{city},{country}");
            }

            // 4) Read the data again after appending
            Console.WriteLine("Data from the file after appending:");
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }
}