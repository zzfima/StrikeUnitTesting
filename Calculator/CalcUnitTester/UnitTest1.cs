using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcUnitTester
{
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void TestMethodAdd()
		{
			ICalculator calculator = new SimpleCalculator();
			calculator.Init(0, 0, CalculatorOperation.Add);

			Assert.AreEqual(0, calculator.Add());
		}

		[TestMethod]
		public void TestMethodMinus()
		{
			ICalculator calculator = new SimpleCalculator();
			calculator.Init(7, 4, CalculatorOperation.Minus);

			Assert.AreEqual(3, calculator.Minus());
		}

		[TestMethod]
		public void TestMethodMultiply()
		{
			ICalculator calculator = new SimpleCalculator();
			calculator.Init(1, 1, CalculatorOperation.Multiply);

			Assert.AreEqual(1, calculator.Multiply());
		}

		[TestMethod]
		public void TestMethodDivide()
		{
			ICalculator calculator = new SimpleCalculator();
			calculator.Init(8, 4, CalculatorOperation.Divide);

			Assert.AreEqual(2, calculator.Divide());
		}
	}
}
