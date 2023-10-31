using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Stack elements:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();
        }
    }
}
 
