using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
       
            
                

            static void doApp()
            {
               
                int number = 10;
                if (number > 5)
                {
                    Console.WriteLine("Number is greater than 5.");
                }
                else
                {
                    Console.WriteLine("Number is not greater than 5.");
                }

               
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Iteration " + (i + 1));
                }

               
                int counter = 0;
                while (counter < 3)
                {
                    Console.WriteLine("Counter: " + counter);
                    counter++;
                }

              
                int option = 2;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Option 1 selected.");
                        break;
                    case 2:
                        Console.WriteLine("Option 2 selected.");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            Console.ReadLine();
            }
    }
}


