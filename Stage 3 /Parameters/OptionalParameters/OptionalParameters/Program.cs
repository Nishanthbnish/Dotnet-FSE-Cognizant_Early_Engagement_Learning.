using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails("Rupesh", "ABC");

            OrderDetails("Rupesh", "ABC", 2, false);
        }

        static void OrderDetails(string sellerName, string productName, int orderQuantity = 1, bool isRetunable = true)
        {
            Console.WriteLine($"Here is the order detail – {orderQuantity} number of {productName} by {sellerName} is ordered. It’s returnable status is {isRetunable}");
        }
    }
}
