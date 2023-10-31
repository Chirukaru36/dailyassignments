using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15 }; 
            int targetValue = 7; 

            int result = BinarySearch(array, targetValue);

            if (result == -1)
            {
                Console.WriteLine($"Value {targetValue} not found in the array.");
            }
            else
            {
                Console.WriteLine($"Value {targetValue} found at index {result} in the array.");
            }
        }

        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

                
            }
            return -1;
            Console.ReadLine();
            

           
        }
       
    }
}
 
