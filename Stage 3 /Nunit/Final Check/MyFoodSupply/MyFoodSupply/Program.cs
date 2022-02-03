using System;

namespace MyFoodSupply
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program objMainProgram = new Program();
            FoodDetail medicine = new FoodDetail();

            Console.Write("**********************************");
            Console.WriteLine();
            Console.Write("My food supply application");
            Console.WriteLine();
            Console.Write("**********************************");
            Console.WriteLine();
            try
            {
                #region Create food detail
                string foodItemName = string.Empty;
                int foodItemCategory;
                double price = 0;
                DateTime expiryDate;

                Console.WriteLine("Dear chef, please enter the food item detail that you want to create");
                Console.WriteLine();
                Console.WriteLine("1. Main dish");
                Console.WriteLine("2. Side dish");
                Console.WriteLine("3. Dessert");
                Console.WriteLine("4. Beverage");
                Console.WriteLine();

                foodItemCategory = int.Parse(Console.ReadLine());
                Console.WriteLine("Please provide the food item name");
                foodItemName = Console.ReadLine();
                Console.WriteLine("Please provide price in valid format");
                price = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the expiry date for the medicine in mm/dd/yyyy format.");
                expiryDate = DateTime.Parse(Console.ReadLine());
                FoodDetail chosenFoodItem = objMainProgram.CreateFoodDetail(foodItemName.Trim(), foodItemCategory, expiryDate, price);

                Console.WriteLine();
                Console.WriteLine("Dear chef, here are the food item details");
                Console.WriteLine();
                Console.WriteLine("Name: " + chosenFoodItem.Name);
                Console.WriteLine("Type: " + chosenFoodItem.DishType.ToString());
                Console.WriteLine("Price: " + chosenFoodItem.Price);
                Console.WriteLine("Expiry date: " + chosenFoodItem.ExpiryDate.ToShortDateString());
                #endregion

                #region Supply detail
                Console.WriteLine("Do you want to pack and sell it to a food supplier? y/n");
                string response = Console.ReadLine();
                if (response.ToLower().Equals("y"))
                {
                    DateTime requestDate;
                    int count = 0;
                    string supplierName = string.Empty;
                    double packingCharge = 0;

                    Console.WriteLine("Food item expiry date: " + chosenFoodItem.ExpiryDate.ToShortDateString());
                    Console.WriteLine("Please enter the date for which you want to send to supplier in mm/dd/yyyy format. Please check that the request date should be lesser than the expiry date");
                    requestDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("How many items do you want to send to supplier?");
                    count = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please provide the supplier name to whom you want to send the food items to");
                    supplierName = Console.ReadLine();
                    Console.WriteLine("Please provide the packing charge");
                    packingCharge = int.Parse(Console.ReadLine());

                    SupplyDetail supplyDetail = objMainProgram.CreateSupplyDetail(count, requestDate, supplierName, packingCharge, chosenFoodItem);

                    if (supplyDetail != null)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Dear chef, your food item supply details is as follows:");
                        Console.WriteLine();
                        Console.WriteLine("Food item name: " + supplyDetail.FoodItem.Name);
                        Console.WriteLine("Request date to supplier: " + supplyDetail.RequestDate.ToShortDateString());
                        Console.WriteLine("No of items: " + supplyDetail.Count);
                        Console.WriteLine("Supplier name: " + supplyDetail.SellerName);
                        Console.WriteLine("Total amount: " + supplyDetail.TotalCost.ToString());
                    }
                    Console.WriteLine();
                    Console.WriteLine("***Thank you. Have a great day***");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("***Thank you. Have a great day***");
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occured in the process. Please find the detail: " + ex.Message);
                Console.WriteLine("An exception occured in the process. Exception stack trace: " + ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public FoodDetail CreateFoodDetail(string name, int dishType, DateTime expiryDate, double price)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Dish name cannot be empty. Please provide valid value");
            else if (price <= 0)
                throw new Exception("Incorrect value for dish price. Please provide valid value");
            else if (expiryDate < DateTime.Now)
                throw new Exception("Incorrect expiry date. Please provide valid value");


            FoodDetail foodItem = new FoodDetail()
            {
                Name = name,
                ExpiryDate = expiryDate,
                Price = price,
                DishType = (FoodDetail.Category)dishType
            };

            return foodItem;
        }

        public SupplyDetail CreateSupplyDetail(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, FoodDetail foodItem)
        {
            if (foodItem != null)
            {
                if (foodItemCount <= 0)
                    throw new Exception("Incorrect food item count. Please check");
                else if (requestDate < DateTime.Now)
                    throw new Exception("Incorrect food request date. Please provide valid value");
                else if (requestDate > foodItem.ExpiryDate)
                    throw new Exception("Request date greater than expiry date. Please check");
                else if (string.IsNullOrEmpty(sellerName))
                    throw new Exception("Incorrect seller name. Please check");

                SupplyDetail supplyDetail = new SupplyDetail()
                {
                    Count = foodItemCount,
                    RequestDate = requestDate,
                    SellerName = sellerName,
                    FoodItem = foodItem,
                    TotalCost = (foodItem.Price * foodItemCount) + packingCharge
                };

                return supplyDetail;
            }
            return null;
        }
    }
}
