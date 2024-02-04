using System;
using System.Collections.Generic;
using System.Net;

namespace Calculator
{
	public class SimpleCalculator : ICalculator
	{
		int _a;
		int _b;
		private CalculatorOperation _calculatorOperation;

		public void Init(int a, int b, CalculatorOperation calculatorOperation)
		{
			_a = a;
			_b = b;
			_calculatorOperation = calculatorOperation;
		}

		public int Add() => _a + _b;

		public string AddAsText()
		{
			var res = Add();
			return $"Result of add {_a} to {_b} is a {res} value";
		}

		public double Divide() => _a / _b;

		public int Minus() => _a - _b;

		public int Multiply() => _a * _b;

		public double Root() => Math.Pow(_a, 1 / _b);

		public IEnumerable<BusinessRule> GetRuleViolations()
		{
			if (_calculatorOperation == CalculatorOperation.Divide && _b == 0)
				yield return BusinessRule.DivideByZero;

			if (_calculatorOperation == CalculatorOperation.Root && _a < 0 && _b % 2 == 0)
				yield return BusinessRule.EvenRootFromNegativeNumber;

			yield break;
		}
	}
}
