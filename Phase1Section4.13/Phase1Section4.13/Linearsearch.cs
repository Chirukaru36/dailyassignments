using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._13
{
    internal class Linearsearch
    {

        public void RunApp()
        {
            int[] array = { 10, 25, 5, 15, 30, 20, 35, 40 };
            Console.WriteLine("Array elements: " + string.Join(", ", array));

            int target = 30;
            int index = LinearSearchValue(array, target);

            if (index != -1)
            {
                Console.WriteLine($"Found {target} at index {index}");
            }
            else
            {
                Console.WriteLine($"{target} not found in the array");
            }
        }

        public int LinearSearchValue(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1; 
        }
    }

}

