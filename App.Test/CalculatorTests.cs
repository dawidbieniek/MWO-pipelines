namespace App.Test
{
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		[DataRow(1, 2, 3)]
		[DataRow(3, -1, 2)]
		public void Add_ShouldReturnSumOf2Numbers_NumbersAreDouble(int a, int b, int expected)
		{
			// Arrange
			Calculator calculator = new(a, b);

			// Act
			int result = calculator.Add();

			// Assert
			Assert.AreEqual(expected, result);
		}
	}
}