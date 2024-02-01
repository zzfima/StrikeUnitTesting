using Calculator;

namespace CalcXUnit
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(1, 2, 3)]
		[InlineData(-4, -6, -10)]
		[InlineData(-2, 2, 0)]
		public void Test1(int a, int b, int res)
		{
			ICalculator calculator = new SimpleCalculator();
			Assert.Equal(3, calculator.Add(1, 2));
		}
	}
}