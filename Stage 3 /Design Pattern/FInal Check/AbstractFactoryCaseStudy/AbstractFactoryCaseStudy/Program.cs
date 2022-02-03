using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string channel = "E-commerce";
            string productType = "Toys";

            var fg = new FactoryGetter();
            fg.PlaceOrder(channel, productType);

        }
    }
}
