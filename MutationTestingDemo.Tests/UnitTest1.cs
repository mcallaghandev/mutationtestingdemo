namespace MutationTestingDemo.Tests
{
    public class Tests
    {
        [Test]
        public void Add_WhenCalled_ReturnsSum()
        {
            double result = Calculator.Add(3, 4);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsDifference()
        {
            double result = Calculator.Subtract(7, 4);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsProduct()
        {
            double result = Calculator.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Divide_WhenDividingByNonZero_ReturnsQuotient()
        {
            double result = Calculator.Divide(12, 4);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Divide_WhenDividingByZero_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Calculator.Divide(12, 0));
        }

        [Test]
        public void Power_WhenCalled_ReturnsPower()
        {
            double result = Calculator.Power(2, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void SquareRoot_WhenCalledWithPositiveNumber_ReturnsSquareRoot()
        {
            double result = Calculator.SquareRoot(9);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void SquareRoot_WhenCalledWithNegativeNumber_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Calculator.SquareRoot(-9));
        }
    }
}