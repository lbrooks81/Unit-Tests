namespace FactorialTests
{
    [TestClass]
    public sealed class FactorialTests
    {
        [TestMethod]
        public void Factorial_WhenNumberIsZero_ReturnsOne()
        {
            // Arrange
            int number = 0;
            int expectedFactorial = 1;
            
            // Act
            int factorial = FactorialCalculator.FactorialCalculator.CalculateFactorial(number);

            // Assert
            Assert.AreEqual(expectedFactorial, factorial);
        }
        
        [TestMethod]
        public void Factorial_NumberIsValidAndPositive_ReturnsFactorial()
        {
            // Arrange
            int number = 7;
            int expectedFactorial = 5040;

            // Act
            int factorial = FactorialCalculator.FactorialCalculator.CalculateFactorial(number);

            // Assert
            Assert.AreEqual(expectedFactorial, factorial);
        }

        [TestMethod]
        public void Factorial_WhenNumberIsNegative_ThrowsOutOfRangeException()
        {
            // Arrange
            int number = -2;

            // Act and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => FactorialCalculator.FactorialCalculator.CalculateFactorial(number));
        }

        [TestMethod]
        public void Factorial_WhenNumberIsTooHigh_ThrowsOverflowException()
        {
            // Arrange
            int number = int.MaxValue;

            // Act and Assert
            Assert.ThrowsException<OverflowException>(() => FactorialCalculator.FactorialCalculator.CalculateFactorial(number));
        }
    }
}
