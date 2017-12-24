using System;
using System.Text;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
public class FastStringCreation
{
    public static void FastSTR()
    {
        // The StringBuilder class creates a string buffer that offers better performance if your program performs many string manipulations.
        StringBuilder numbers = new StringBuilder();

        for (int i = 0; i < 10; i++)
        {
            numbers.Append(i.ToString());
        }

        Console.WriteLine($"Before the mutable string of characters (numbers) be modified: {numbers}");
        
        // Copy one character of the string (not possible with a System.String).
        numbers[0] = numbers[9];

        Console.WriteLine($"After: {numbers}");
    }
}
