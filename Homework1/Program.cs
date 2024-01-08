namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        var operationIndex = 0;
        var result = 0.0;
        
        Calculation calculation = new Calculation();

        while (operationIndex != 7)
        {
            bool isValidInput = false;

            Console.WriteLine("Choose operation: ");
            Console.Write("1. Addition | 2. Substraction | 3. Multiplication | 4. Division | 5. Exponentiation | 6. Factorial | 7. EXIT\n");

            isValidInput = int.TryParse(Console.ReadLine(), out operationIndex);

            double[] inputValues = new double[2];
           
            switch(operationIndex)
            {
                case 1:
                    inputValues = GetNumbers(operationIndex);
                    result = calculation.Addition(inputValues[0], inputValues[1]);
                    break;
                case 2:
                    inputValues = GetNumbers(operationIndex);
                    result = calculation.Substraction(inputValues[0], inputValues[1]);
                    break;
                case 3:
                    inputValues = GetNumbers(operationIndex);
                    result = calculation.Multiplication(inputValues[0], inputValues[1]);
                    break;
                case 4:
                    inputValues = GetNumbers(operationIndex);
                    result = calculation.Division(inputValues[0], inputValues[1]);
                    break;
                case 5:
                    inputValues = GetNumbers(operationIndex);
                    result = calculation.Exponentiation(inputValues[0], inputValues[1]);
                    break;
                case 6:
                    inputValues = GetNumbers(operationIndex);
                    result = calculation.Factorial(inputValues[0]);
                    break;
                default:
                    Console.WriteLine("\nIt is not an option.\n");
                    isValidInput = false;
                    break;
            }

            if (isValidInput)
                Console.WriteLine("\nResult is: " + result.ToString() + "\n\n");
        }
    }

    // Returns array with values of input numbers. Numbers are validated so mathematical operation can be executed.
    static public double[] GetNumbers(int operationIndex)
    {
        bool isValid = false;
        bool isFirstNumberValid, isSecondNumberValid;
        double[] inputNumbers = new double[2];

        // Loop end when both numbers are valid
        while (!isValid)
        {
            // If operation is FACTORIAL dont allow negative number
            if (operationIndex == 6) {

                Console.Write("\nInput value: ");
                isFirstNumberValid = double.TryParse(Console.ReadLine(), out inputNumbers[0]);
                isSecondNumberValid = true;

                if (inputNumbers[0] < 0)
                {
                    Console.WriteLine("There is no factorial of negative number");
                    isFirstNumberValid = false;
                }

            }
            // If operation is DIVISION dont allow divider to be 0
            else if (operationIndex == 4)
            {
                Console.Write("\nInput first value: ");
                isFirstNumberValid = double.TryParse(Console.ReadLine(), out inputNumbers[0]);
                Console.Write("\nInput second value: ");
                isSecondNumberValid = double.TryParse(Console.ReadLine(), out inputNumbers[1]);

                if (inputNumbers[1] == 0)
                {
                    Console.WriteLine("Divider cannot be 0.");
                    isFirstNumberValid = false;
                }
            }
            // Other operations, numbers must be double
            else
            {
                Console.Write("\nInput first value: ");
                isFirstNumberValid = double.TryParse(Console.ReadLine(), out inputNumbers[0]);
                Console.Write("\nInput second value: ");
                isSecondNumberValid = double.TryParse(Console.ReadLine(), out inputNumbers[1]);
            }


            if (!isFirstNumberValid || !isSecondNumberValid)
            {
                Console.WriteLine("Wrong values. Try again.");
            }
            else
            {
                isValid = true;
            }
        }

        return inputNumbers;
    }
}
