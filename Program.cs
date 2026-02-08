/**
 * NAME: BRIONES, KATLEEN
 * CREATED: FEB 7 2026
 * UPDATED: FEB 8 2026
 * ACTIVITY#2:  Loop-Based Basic Calculator with Operation Selection
*/
using System;

class Program
{
    public static void Main(string[] args)
    {
        while(true){
            // FIRST OPERAND
            Console.Write("Enter first number: ");
                if (!int.TryParse(Console.ReadLine(), out int fOperand)){
                    Console.WriteLine("\nInvalid input, please enter a whole number\n");
                    continue;
                }
             // SECOND OPERAND
            Console.Write("Enter second number: ");
                if (!int.TryParse(Console.ReadLine(), out int sOperand)){
                    Console.WriteLine("\nInvalid input, please enter a whole number\n");
                    continue;
                }
            // OPERATION
            string operation;
            
            while(true){
                Console.Write("Choose operation (+, -, *, /, %, =): ");
                operation = Console.ReadLine();
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%" || operation == "=")
                     break;
                Console.WriteLine("\nIncorrect Operation Used, please try again\n");
            }
            
            if(operation == "=")
                break;
            
            // CALCULATE
            double? result = Calculator.Calculate(fOperand, sOperand, operation);
            
            // RESULT
            if (result != null)
                Console.WriteLine("\nResult: {0:F2}",result);

            Console.WriteLine();
        }
        Console.WriteLine("\nProgram terminated.");
        
    }
    }
