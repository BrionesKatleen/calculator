using System;

class Program
{
    static void Main()
    {
        string operation;
        int operand1, operand2;
        bool running = true;

        while (running)
        {
            Console.Write("Enter first number: ");
            operand1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            operand2 = int.Parse(Console.ReadLine());

            Console.Write("Choose operation (+,-,*,/,%,=): ");
            operation = Console.ReadLine();

            // Perform the calculation
            double? result = Calculate(operand1, operand2, operation);

            if (result.HasValue)
            {
                Console.WriteLine("Result: " + result.Value);
            }

            // Check if the user wants to terminate
            if (operation == "=")
            {
                Console.WriteLine("Program terminated.");
                running = false;
            }
        }
    }
