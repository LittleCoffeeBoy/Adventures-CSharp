using System;

// Reference: https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/main-and-command-args/command-line-arguments
// This application needs a numeric argument.
class CmdLineArgsApp
{
    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            PrintHelp();
            Console.ReadKey();
            return 1;
        }

        int number;
        bool test = int.TryParse(args[0], out number);
        if (!test)
        {
            PrintHelp();
            Console.ReadKey();
            return 1;
        }

        long result = Functions.Factorial(number);
        if (result == -1)
        {
            Console.WriteLine("Input must be >= 0 and <= 20.");
        }
        else
        {
            Console.WriteLine($"The Factorial of {number} is {result}");
        }

        Console.Write("Press any key to exit.");
        Console.ReadKey();
        return 0;
    }

    static void PrintHelp()
    {
        Console.WriteLine("Please enter a numeric argument.");
        Console.WriteLine("Usage: Factorial <number>");
    }
}