using System;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
public class Substrings
{
    public static void SubSTR()
    {
        string programVersion = "Visual C# Express";

        Console.WriteLine($"Before Replace:  {programVersion}");

        string substringProgramVersion = programVersion.Substring(7, 2);
        Console.WriteLine($"Substring: {substringProgramVersion}");

        int indexC = programVersion.IndexOf("C");
        int indexShap = programVersion.IndexOf("#");
        Console.WriteLine($"Index \"C\": {indexC}\tIndex \"#\": {indexShap}");

        // Like the Substring method, Replace actually returns a new string and does not modify the original string.
        string newProgramVersion = programVersion.Replace("C#", "Basic");

        Console.WriteLine($"After Replace: {newProgramVersion}");
    }
}
