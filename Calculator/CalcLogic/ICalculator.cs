using System.Collections.Generic;

namespace Calculator
{
	public interface ICalculator
	{
		void Init(int a, int b, CalculatorOperation calculatorOperation);

		int Add();
		int Minus();
		int Multiply();
		double Divide();
		double Root();
		string AddAsText();
		IEnumerable<BusinessRule> GetRuleViolations();
	}
}
