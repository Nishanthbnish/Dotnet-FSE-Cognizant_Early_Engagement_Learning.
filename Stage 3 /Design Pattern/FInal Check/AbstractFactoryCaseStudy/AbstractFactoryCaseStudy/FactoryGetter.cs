using System;

namespace AbstractFactoryCaseStudy
{
    public class FactoryGetter
    {
        public void PlaceOrder(string channel, string productType)
        {
            if (productType == "Toys")
            {
                Order order = new Toys(channel, productType);
            }
            else if (productType == "Furniture")
            {
                Order order = new Furniture(channel, productType);
            }
            else if (productType == "Electronic Product")
            {
                Order order = new ElectronicProduct(channel, productType);
            }
        }
    }
}
