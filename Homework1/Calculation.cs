using System;
namespace Homework1
{
	public class Calculation
	{
		public double Operation(double aNumber, double bNumber, int operationIndex)
		{


			return 0;
		}

		public double Addition(double aNumber, double bNumber)
		{
			return aNumber + bNumber;
		}

		public double Substraction(double aNumber, double bNumber)
		{
			return aNumber - bNumber;
		}

		public double Multiplication(double aNumber, double bNumber)
		{
			return aNumber * bNumber;
		}

		public double Division(double aNumber, double bNumber)
		{
			if (bNumber == 0)
				return 0;

			return aNumber / bNumber;
		}

		public double Exponentiation(double aNumber, double bNumber)
		{
			return Math.Pow(aNumber, bNumber);
		}

		public double Factorial(double aNumber)
		{
			if (aNumber < 0)
				return 0;

			if (aNumber == 1 || aNumber == 0)
				return 1;

			return aNumber * Factorial(aNumber - 1);
		}
	}
}

