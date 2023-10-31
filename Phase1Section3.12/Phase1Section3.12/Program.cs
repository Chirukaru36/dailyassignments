using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
            

            
            string textToWrite = "This is a text file example.\nYou can write text to this file.";
            File.WriteAllText("example.txt", textToWrite);
            Console.WriteLine("Text file 'example.txt' created.");

            
            string readText = File.ReadAllText("example.txt");
            Console.WriteLine("\nContents of 'example.txt':\n" + readText);

            Console.Read();
        }
    }
}

