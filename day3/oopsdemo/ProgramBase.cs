using System;

namespace oopsdemo
{
    internal class ProgramBase
    {

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            swapNo(ref a, ref b);
            Console.WriteLine($"the value of a = {a}");
            Console.WriteLine($"the value of b = {b}");
            Console.ReadLine();

        }
        static void swapNo(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
            Console.WriteLine($"the value of i = {i}");
            Console.WriteLine($"the value of j = {j}");


        }
    }
}