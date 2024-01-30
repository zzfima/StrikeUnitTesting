namespace Calculator
{
	public class SimpleCalculator : ICalculator
	{
		public double Add(double a, double b) => a + b;

		public double Divide(double a, double b) => a / b;

		public double Minus(double a, double b) => a - b;

		public double Multiply(double a, double b) => a * b;

	}
}
