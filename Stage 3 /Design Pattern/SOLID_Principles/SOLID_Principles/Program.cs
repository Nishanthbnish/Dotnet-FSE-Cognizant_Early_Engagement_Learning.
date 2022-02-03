using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our site. Would you like to order or repair?");
            string processOption = Console.ReadLine().ToLower().Trim();

            string productDetail;

            switch (processOption)
            {
                case "order":
                    Console.WriteLine("Please provide the phone model name");
                    productDetail = Console.ReadLine().Trim();
                    var phoneOrder = new PhoneOrder();
                    phoneOrder.ProcessOrder(productDetail);
                    break;

                case "repair":
                    Console.WriteLine("Is it the phone or the accessory that you want to be repaired?");
                    string productType = Console.ReadLine().ToLower();
                    if(productType.Equals("phone"))
                    {
                        Console.WriteLine("Please provide the phone model name");
                        productDetail = Console.ReadLine().Trim();
                        var phoneRepair = new PhoneRepair();
                        phoneRepair.ProcessPhoneRepair(productDetail);
                    }
                    else
                    {
                        Console.WriteLine("Please provide the accessory detail, like headphone, tempered glass");
                        productDetail = Console.ReadLine().Trim();
                        var accessoryRepair = new AccessoryRepair();
                        accessoryRepair.ProcessAccessoryRepair(productDetail);
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine("Thanks for choosing us. Have a great day.");
        }
    }
}
