using System;

namespace AbstractFactoryCaseStudy
{
    public class ElectronicProduct : Order
    {
        public ElectronicProduct(string channel, string productType) 
            : base(channel, productType)
        {
            processOrder();
        }

        public override void processOrder()
        {
            Console.WriteLine("Electronic product order accepted");
            Console.WriteLine(base.ToString());
        }
    }
}
