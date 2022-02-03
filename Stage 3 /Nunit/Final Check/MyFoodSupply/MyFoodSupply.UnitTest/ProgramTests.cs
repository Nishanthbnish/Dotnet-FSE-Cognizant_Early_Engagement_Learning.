using System;
using NUnit.Framework;

namespace MyFoodSupply.UnitTest
{
    [TestFixture]
    public class ProgramTests
    {

        private Program _program;

        [SetUp]
        public void SetUp()
        {
            _program = new Program();
        }

        //NUnit Test cases for CreateFoodDetail Method
        [Test]
        [TestCase("abc", 2, "2021-04-09", 20.50)]
        public void CreateFoodDetail_WhenCalled_ReturnFoodDetail(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = _program.CreateFoodDetail(name, dishType, expiryDate, price);

            Assert.That(result, Is.TypeOf<FoodDetail>());
        }

        [Test]
        [TestCase(null, 2, "2021-04-09", 20.50)]
        [TestCase("", 2, "2021-04-09", 20.50)]
        public void CreateFoodDetail_FoodNameIsNullOrEmpty_RaiseException(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => _program.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase("abc", 2, "2021-04-09", 0)]
        [TestCase("abc", 2, "2021-04-09", -1)]
        public void CreateFoodDetail_PriceLessThanZero_RaiseException(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => _program.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        [Test]
        [TestCase("abc", 2, "2021-01-09", 20.50)]
        public void CreateFoodDetail_ExpiryDateLessThanCurrentDate_RaiseException(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => _program.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        //NUnit Test cases for CreateSupplyDetail Method
        [Test]
        [TestCase(10, "2021-04-10", "abc", 10.50)]
        public void CreateSupplyDetail_WhenCalled_ReturnSupplyDetail(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var foodItem = new FoodDetail()
            {
                Name = "abc",
                DishType = (FoodDetail.Category)1,
                ExpiryDate = new DateTime(2021, 6, 9),
                Price = 30.75
            };

            var result = _program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem);

            Assert.That(result, Is.TypeOf<SupplyDetail>());
        }

        [Test]
        [TestCase(0, "2021-04-07", "abc", 10.50)]
        [TestCase(-1, "2021-04-07", "abc", 10.50)]
        public void CreateSupplyDetail_FoodItemCountLessThanZero_RaiseException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var foodItem = new FoodDetail()
            {
                Name = "abc",
                DishType = (FoodDetail.Category)1,
                ExpiryDate = new DateTime(2021, 5, 8),
                Price = 30.75
            };

            Assert.Throws<Exception>(() => _program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem));
        }

        [Test]
        [TestCase(10, "2021-02-07", "abc", 10.5)]
        public void CreateSupplyDetail_RequestDateLessThanCurrentDate_RaiseException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var foodItem = new FoodDetail()
            {
                Name = "abc",
                DishType = (FoodDetail.Category)1,
                ExpiryDate = new DateTime(2021, 5, 8),
                Price = 30.75
            };

            Assert.Throws<Exception>(() => _program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem));
        }

        [Test]
        [TestCase(10, "2021-04-07", "abc", 10.50, null)]
        public void CreateSupplyDetail_NullFoodDetail_RaiseException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, FoodDetail foodItem)
        {
            var result = _program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem);

            Assert.That(result, Is.EqualTo(null));
        }
    }
}
