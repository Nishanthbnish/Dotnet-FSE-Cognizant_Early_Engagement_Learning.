using NUnit.Framework;
using System;

namespace CalcLibrary.UnitTest
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator _simpleCalculator;

        [SetUp]
        public void SetUp()
        {
            _simpleCalculator = new SimpleCalculator();
        }

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, 3)]
        public void Addition_WhenCalled_ReturnSum(double a, double b, double expected)
        {
            var result = _simpleCalculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(2, 1, 1)]
        [TestCase(1, 2, -1)]
        public void Substraction_WhenCalled_ReturnSubstration(double a, double b, double expected)
        {
            var result = _simpleCalculator.Substraction(a, b);
            Assert.That(result, Is.EqualTo(expected)); 
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(0, 1, 0)]
        [TestCase(-1, 2, -2)]
        public void Multiplication_WhenCalled_ReturnProduct(double a, double b, double expected)
        {
            var result = _simpleCalculator.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, 2, 0.5)]
        [TestCase(2, 2, 1)]
        [TestCase(1, 1, 1)]
        public void Divison_WhenCalled_ReturnDivision(double a, double b, double expected)
        {
            try
            {
                var result = _simpleCalculator.Division(a, b);
                Assert.That(result, Is.EqualTo(expected));
            }
            catch
            {
                Assert.Fail("Division by zero");
            }
        }

        [Test]
        public void TestAddAndClear()
        {
            var result = _simpleCalculator.Addition(1, 2);
            Assert.AreEqual(_simpleCalculator.GetResult, result);

            _simpleCalculator.AllClear();
            Assert.AreEqual(_simpleCalculator.GetResult, 0);
        }
    }
}
