using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcUnitTester
{
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void TestMethodAdd()
		{
			ICalculator calculator = new SimpleCalculator();
			Assert.AreEqual(11, calculator.Add(7, 4));
		}

		[TestMethod]
		public void TestMethodMinus()
		{
			ICalculator calculator = new SimpleCalculator();
			Assert.AreEqual(3, calculator.Minus(7, 4));
		}

		[TestMethod]
		public void TestMethodMultiply()
		{
			ICalculator calculator = new SimpleCalculator();
			Assert.AreEqual(28, calculator.Multiply(7, 4));
		}

		[TestMethod]
		public void TestMethodDivide()
		{
			ICalculator calculator = new SimpleCalculator();
			Assert.AreEqual(2, calculator.Divide(8, 4));
		}
	}
}
