using System;
using System.Threading;

namespace ThreadStartSample
{
    class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

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
