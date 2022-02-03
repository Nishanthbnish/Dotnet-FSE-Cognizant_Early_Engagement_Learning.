using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new BugattiVeyron();
            var adapter = new MovableAdapterImpl(car);

            Console.WriteLine($"Speed in MPH: {car.GetSpeed()}");
            Console.WriteLine($"Price in USD: {car.GetPrice()}");

            Console.WriteLine();

            Console.WriteLine($"Speed in KPH: {adapter.GetSpeed()}");
            Console.WriteLine($"Price in euro: {adapter.GetPrice()}");
        }
    }
}
