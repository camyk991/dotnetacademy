namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        int operationIndex = 0 ;

        while (operationIndex != 7)
        {
            bool isValidInput = false;

            Console.WriteLine("Choose operation: ");
            Console.Write("1. Addition | 2. Substraction | 3. Multiplication | 4. Division | 5. Exponentiation | 6. Factorial | 7. EXIT\n");

            isValidInput = int.TryParse(Console.ReadLine(), out operationIndex);

            if (isValidInput)
            {
                switch(operationIndex)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("\nIt is not an option.");
                        break;
                }
            } else
            {
                Console.WriteLine("\nWrong value. Try again.");
            }

            Console.WriteLine("");
        }
    }
}
