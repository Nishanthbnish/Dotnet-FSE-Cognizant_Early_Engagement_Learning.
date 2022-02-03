using System;

namespace AbstractFactoryCaseStudy
{
    public class Toys : Order
    {
        public Toys(string channel, string productType) : base(channel, productType)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine("Toys order accepted");
            Console.WriteLine(base.ToString());
        }
    }
}
