using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class Program
    {
        public static void print()
        {
            int i = 9;
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(j);
            }
        }
        static void Main(string[] args)
        {

            //currentthreadExamples();

            Thread th = Thread.CurrentThread;
            th.Name = "main thread is running";
            Console.WriteLine(th.Name);
            Console.WriteLine(th.ManagedThreadId);
            Console.WriteLine("------------");


            Thread t = new Thread(new ThreadStart(Program.print));
            t.Start();
            
            Console.WriteLine($"the managedthreadID = {t.ManagedThreadId}");
            
            Console.ReadLine();
        }


        private static void currentthreadExamples()
        {
            Thread th = Thread.CurrentThread;
            th.Name = "main thread is running";
            Console.WriteLine(th.Name);
            Console.WriteLine(th.ManagedThreadId);
        }
    }
}

