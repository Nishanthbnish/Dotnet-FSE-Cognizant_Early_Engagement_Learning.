using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await_1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await PrintString();
        }

        static async Task PrintString()
        {
            string str = await StringWithDelay();
            Console.WriteLine(str);
        }

        static async Task<string> StringWithDelay()
        {
            Thread.Sleep(3000);
            return "String With Delay";
        }
    }
}
