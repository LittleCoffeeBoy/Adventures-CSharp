using System;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
public class NullAndEmptyStrings
{
    public static void NullAndEmpty()
    {
        string helloStr = "Hello";
        string nullStr = null;
        string emptyStr = String.Empty;
        string tempStr = helloStr + nullStr;

        Console.WriteLine($"helloStr + nullStr = {tempStr}");

        Console.WriteLine();

        bool isEmptyEqualsNull = (emptyStr == nullStr);
        Console.WriteLine($"Is an empty string equals a null string? -> {isEmptyEqualsNull}");

        Console.WriteLine();

        string newEmptyStr = emptyStr + nullStr;

        Console.WriteLine($"Empty string length: {emptyStr.Length}");
        Console.WriteLine($"New empty string length: {newEmptyStr.Length}");

        Console.WriteLine();

        try
        {
            Console.WriteLine($"Null string length: {nullStr.Length}");
        }
        catch (NullReferenceException nullRefEx)
        {
            Console.WriteLine($"Null string length:\n\t{nullRefEx.ToString()}");
        }

        Console.WriteLine();

        // The null character can be displayed and counted, like other chars.
        string nullChar1 = "\x0" + "abc";
        string nullChar2 = "abc" + "\x0";

        Console.WriteLine($"Null character first example: *{nullChar1}*");
        Console.WriteLine($"Null character second example: *{nullChar2}*");
        Console.WriteLine($"Length null character + \"abc\" string: {nullChar2.Length}");
    }
}
