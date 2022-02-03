using System;

namespace AbstractFactoryCaseStudy
{
    public class Furniture : Order
    {
        public Furniture(string channel, string productType) 
            : base(channel, productType)
        {
            processOrder();
        }

        public override void processOrder()
        {
            Console.WriteLine("Furniture order accepted");
            Console.WriteLine(base.ToString());
        }
    }
}
