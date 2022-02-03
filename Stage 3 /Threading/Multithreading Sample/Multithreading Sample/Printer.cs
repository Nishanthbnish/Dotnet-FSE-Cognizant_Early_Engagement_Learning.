using System;
using System.Threading;

namespace Multithreading_Sample
{
    public class Printer
    {
        private object lockToken = new object();

        public void PrintNumber()
        {
            lock (lockToken)
            {
                Console.WriteLine($"Thread-> {Thread.CurrentThread.ManagedThreadId} started @{DateTime.Now.ToLongTimeString()} and executing PrintNUmber() method");

                Console.WriteLine("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{i}, ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
        }
    }
}
