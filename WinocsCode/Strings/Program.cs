using System;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/string
// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
public class Program
{
    public static void Main(string[] args)
    {
        /*
         * OBS: lthough string is a reference type, the equality operators (== and !=) are defined to compare the values of string objects, not references. 
         * Value comparison: Console.WriteLine(a == b);
         * Reference comparison: Console.WriteLine((object)a == (object)b);
        */

        /*
        // Simple String Test:
        string a = "\u0068ello ";
        string b = "world";

        Console.WriteLine(a + b);
        // Performs a case-sensetive comparison:
        Console.WriteLine(a + b == "Hello World");
        */

        /* First Example:
        // Declaring and initializing strings:
        string message1;
        string message2 = null;
        // OBS: By initializing strings with the Empty value instead of null, you can reduce the chances of a NullReferenceException occurring.
        string message3 = String.Empty;

        // Relugar string:
        string oldPath = "C:\\Program Files\\Microsoft Visual Studio 8.0";

        // Verbatim string:
        string newPath = @"C:\Program Files\Microsoft Vissual Studio 9.0";

        String greeting = "Hello World!";

        // In local variables you can use implicit typing:
        var temp = "I'm still a strongly-typed System.String!";

        //Use a const string to prevent 'message4' from being used to store another string value.
        const string message4 = "You can't get rid of me!";

        // Use the String constructor only when creating a string from a char*, char[], or sbyte*.
        char[] letters = { 'A', 'B', 'C' };
        // Output: ABC
        string alphabet = new string(letters);
        */

        /* Second Example:
        //  The += operator creates a new string that contains the combined contents. That new object is assigned to the variable s1, and the original object that was assigned to s1 is released for garbage collection because no other variable holds a reference to it.
        string s1 = "A string is more ";
        string s2 = "than the sum of its chars.";

        s1 += s2;

        Console.WriteLine(s1);
        */

        /* Third Example:
        string s1 = "Hello ";
        string s2 = s1;

        s1 += "World";

        Console.WriteLine(s2);
        */

        /* Fourth Example:
        // Use regular string literals when you must embed escape characters provided by C#, as shown in the following example:
        string columns = "Column 1\tColumn 2\tColumn 3";
        Console.WriteLine(columns);

        string rows = "Row 1\r\nRow 2\r\nRow 3\r";
        Console.WriteLine(rows);

        string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge.";
        Console.WriteLine(title);
        */

        /* Fifth Example:
        // Use verbatim strings for convenience and better readability when the string text contains backslash characters, for example in file paths.
        string filePath = @"C:\Users\scoleridge\Documents\";
        Console.WriteLine(filePath);

        Console.WriteLine();

        string text = @"My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...";
        Console.WriteLine(text);

        Console.WriteLine();

        string quote = @"Her name was ""Sara.""";
        Console.WriteLine(quote);
        */

        /* -> String Escape Sequences
        
        Escape sequence     	Character name	                             Unicode encoding
        \'	                    Single quote	                             0x0027
        \"	                    Double quote	                             0x0022
        \\	                    Backslash	                                 0x005C
        \0	                    Null	                                     0x0000
        \a	                    Alert	                                     0x0007
        \b	                    Backspace	                                 0x0008
        \f	                    Form feed	                                 0x000C
        \n	                    New line	                                 0x000A
        \r	                    Carriage return	                             0x000D
        \t	                    Horizontal tab	                             0x0009
        \U                      Unicode escape sequence for surrogate pairs. \Unnnnnnnn
        \u	                    Unicode escape sequence	                     \u0041 = "A"
        \v	                    Vertical tab	                             0x000B
        \x	                    Unicode escape sequence similar
                                 to "\u" except with variable length.	     \x0041 = "A"

        */

        Console.Write("Press any key to exit.");
        Console.ReadKey();
    }
}
 