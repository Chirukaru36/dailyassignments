using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, smartphone> dic1 = new Dictionary<string, smartphone>();
            dic1.Add("IMEI001", new smartphone { IMEINO = "IMEI001", Name = "iPhone", Model = "12", Price = 999.99M });
            dic1.Add("IMEI002", new smartphone { IMEINO = "IMEI002", Name = "Samsung", Model = "Galaxy S21", Price = 799.99M });
            dic1.Add("IMEI003", new smartphone { IMEINO = "IMEI003", Name = "Google", Model = "Pixel 5", Price = 699.99M });


            Dictionary<string, smartphone> dictionary2 = new Dictionary<string, smartphone>();

            dictionary2.Add("IMEI002", new smartphone { IMEINO = "IMEI002", Name = "Samsung", Model = "Galaxy S21", Price = 799.99M });
            dictionary2.Add("IMEI003", new smartphone { IMEINO = "IMEI003", Name = "Google", Model = "Pixel 5", Price = 699.99M });
            dictionary2.Add("IMEI004", new smartphone { IMEINO = "IMEI004", Name = "OnePlus", Model = "8T", Price = 699.99M });

            IEnumerable<KeyValuePair<string, smartphone>> concatenatedans = dic1.Concat(dictionary2);

            foreach (var item in concatenatedans)
            {
                Console.WriteLine($"the concatenated answer is {item.Key} , {item.Value}");
            }

            Console.ReadLine();
        }
    }
}

