namespace MutationTestingDemo.Tests
{
    public class Tests
    {
        [Test]
        public void AdditionTest()
        {
            double result = Calculator.Add(10, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void SubtractionTest()
        {
            double result = Calculator.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }

        // Gap: Missing test for multiplication

        [Test]
        public void DivisionTest()
        {
            double result = Calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }
    }
}