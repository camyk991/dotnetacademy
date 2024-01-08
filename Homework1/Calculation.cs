using System;
namespace Homework1
{
	// Simple class with calculation methods. All methods return double value.
	public class Calculation
	{

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

		public double Factorial(double aNumber)//2.2
		{
			if (aNumber < 0)
				return 0;

			if (aNumber == 1 || aNumber == 0)
				return 1;

			return aNumber * Factorial(aNumber - 1);
		}
	}
}

