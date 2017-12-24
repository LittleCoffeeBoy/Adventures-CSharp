using System;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
public class IndividualCharacters
{
    // You can use array notation with an index value to acquire read-only access to individual characters:
    public static void IndividualChars()
    {
        string characters = "Printing backwards";

        for (int i = 0; i < characters.Length; i++)
        {
            Console.Write(characters[(characters.Length - i) - 1]);
        }

        Console.WriteLine();
    }
}
