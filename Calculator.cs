using System;

public static double? Calculate(int first, int second, string operation)
    {
        double? result = null;

        switch (operation)
        {
            case "+":
                result = first + second;
                break;

            case "-":
                result = first - second;
                break;

            case "*":
                result = first * second;
                break;

            case "/":
                if (second == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return null;
                }
                result = (double)first / second;  // Cast to double to avoid integer division
                break;

            case "%":
                if (second == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return null;
                }
                result = first % second;
                break;

            case "=":
                // Program termination handled in Main
                break;

            default:
                Console.WriteLine("Incorrect Operation Used, please try again");
                break;
        }

        return result;
    }
}

