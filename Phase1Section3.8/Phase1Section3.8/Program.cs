using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        

            static void doApp()
            {
                
                DateTime currentDate = DateTime.Now;
                Console.WriteLine("Current Date and Time: " + currentDate);

                
                DateTime specificDate = new DateTime(2023, 10, 29);
                Console.WriteLine("Specific Date: " + specificDate);

                
                DateTime futureDate = specificDate.AddDays(7);
                Console.WriteLine("Date 7 days from Specific Date: " + futureDate);

                
                string formattedDate = currentDate.ToString("MM/dd/yyyy");
                Console.WriteLine("Formatted Date: " + formattedDate);

                
                if (specificDate > currentDate)
                {
                    Console.WriteLine("Specific Date is in the future.");
                }
                else if (specificDate < currentDate)
                {
                    Console.WriteLine("Specific Date is in the past.");
                }
                else
                {
                    Console.WriteLine("Specific Date is today.");
                }
                Console.ReadLine();
            }
    }
}


