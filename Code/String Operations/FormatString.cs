using System;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
public class FormatString
{
    /*
        One overload of the WriteLine method takes a format string as a parameter.
        Therefore, you can just embed a format string literal without an explicit call to the method.
        However, if you use the WriteLine method to display debug output in the Visual Studio Output window, you have to explicitly call the Format method because WriteLine only accepts a string, not a format string.
    */
    public static void FormatSTR()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        int numberInformed;
        Int32.TryParse(input, out numberInformed);

        string stringFormated;
        for (int i = 0; i <= 10; i++)
        {
            stringFormated = String.Format("{0} times {1} = {2}", i, numberInformed, (i * numberInformed));
            Console.WriteLine(stringFormated);
        }
    }
}
