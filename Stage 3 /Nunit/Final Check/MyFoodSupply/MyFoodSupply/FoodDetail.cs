using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFoodSupply
{
    public class FoodDetail
    {
        public enum Category
        {
            MainDish = 1,
            SideDish = 2,
            Dessert = 3,
            Beverage = 4
        }

        public string Name { get; set; }
        public Category DishType { get; set; }
        public double Price { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
