using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFoodSupply
{
    public class SupplyDetail
    {
        public FoodDetail FoodItem { get; set; }
        public int Count { get; set; }
        public double TotalCost { get; set; }
        public DateTime RequestDate { get; set; }
        public string SellerName { get; set; }
        public double PackingCharge { get; set; }
    }
}
