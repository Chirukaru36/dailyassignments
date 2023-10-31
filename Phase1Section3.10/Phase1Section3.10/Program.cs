using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
            
            string greeting = "Hello, ";
            string name = "John";
            string message = greeting + name + "!";
            Console.WriteLine("Using string: " + message);

            
            StringBuilder builder = new StringBuilder("StringBuilder Example: ");
            builder.Append("This is a ");
            builder.Append("longer text that can be modified efficiently.");
            Console.WriteLine(builder.ToString());

            
            builder.Replace("longer", "shorter");
            builder.Insert(25, " dynamically ");
            Console.WriteLine("Modified text: " + builder.ToString());

            
            builder.Append(" Appending new content.");
            Console.WriteLine("Appended text: " + builder.ToString());
            Console.ReadLine();
        }
    }
}
  
