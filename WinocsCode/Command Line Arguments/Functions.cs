using System;

// Reference: https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/main-and-command-args/command-line-arguments

public class Functions
{
    public static long Factorial(int number)
    {
        if ((number < 0) || (number > 20))
        {
            return -1;
        }

        long tempResult = 1;
        for (int i = 1; i <= number; i++)
        {
            tempResult *= i;
        }

        return tempResult;
    }
}