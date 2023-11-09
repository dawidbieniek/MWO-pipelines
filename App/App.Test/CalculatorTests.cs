
namespace App.Test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(1.5, 2.1, 3.6)]
        public void Add_ShouldReturnSumOf2Numbers_NumbersAreDouble(float a, float b, float expected)
        {
            // Arrange
            Calculator calculator = new(a, b);

            // Act
            double result = calculator.Add();

            // Assert
            Assert.Equals(expected, result);
        }
    }
}