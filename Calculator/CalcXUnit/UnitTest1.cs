using Calculator;
using FluentAssertions;

namespace CalcXUnit
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(1, 2, 3)]
		[InlineData(-4, -6, -10)]
		[InlineData(-2, 2, 0)]
		public void TestAdd_ShallPass(int a, int b, int res)
		{
			ICalculator calculator = new SimpleCalculator();
			calculator.Init(a, b, CalculatorOperation.Add);
			calculator.Add().Should().Be(res);
		}

		[Theory]
		[InlineData(1, 2, 3)]
		[InlineData(-4, -6, -10)]
		[InlineData(-2, 2, 0)]
		[InlineData(-41, -60, -101)]
		public void TestAddAsText_ShallPass(int a, int b, int res)
		{
			ICalculator calculator = new SimpleCalculator();
			calculator.Init(a, b, CalculatorOperation.AddAsText);

			calculator.AddAsText()
				.Should()
				.StartWith("Result")
				.And.EndWith("value")
				.And.Contain("is a")
				.And.Contain(res.ToString());

			calculator.AddAsText().Split().Should().HaveCount(10, "because there is 10 words in string");
		}

		[Theory]
		[InlineData(1, 0, 3)]
		[InlineData(-4, 0, -10)]
		[InlineData(-2, 0, 0)]
		[InlineData(-41, 0, -101)]
		public void TestDivide_ShallFailed(int a, int b, double res)
		{
			ICalculator calculator = new SimpleCalculator();
			calculator.Init(a, b, CalculatorOperation.Divide);
			calculator.GetRuleViolations().Should().Contain(BusinessRule.DivideByZero);

			Action action = () => calculator.Divide();
			action
				.Should().Throw<DivideByZeroException>()
				.WithMessage("Attempted to divide by zero.");
		}
	}
}