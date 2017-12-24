using System;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum
enum TaskImportance
{
    None,
    Regular,
    Important,
    Critical
}

public class Program
{
    static string taskName = String.Empty;
    static int importanceLevel = 1;
    static TaskImportance importanceInformed = TaskImportance.None;

    static void Main(string[] args)
    {
        Console.WriteLine("-- Set Up a Task --");

        Console.Write("Task Name: ");
        taskName = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("Select the importance level for your task:");
        Console.WriteLine("[1] - None");
        Console.WriteLine("[2] - Regular");
        Console.WriteLine("[3] - Important");
        Console.WriteLine("[4] - Critical");
        Console.Write("> ");
        importanceLevel = Int32.Parse(Console.ReadLine());

        switch (importanceLevel)
        {
            case 1:
                importanceInformed = TaskImportance.None;
                break;
            case 2:
                importanceInformed = TaskImportance.Regular;
                break;
            case 3:
                importanceInformed = TaskImportance.Important;
                break;
            case 4:
                importanceInformed = TaskImportance.Critical;
                break;
        }

        Console.Clear();

        Console.WriteLine($"Task: {taskName}");
        Console.WriteLine($"Importance Level: {importanceInformed}");

        Console.Write("\nPress any key to exit.");
        Console.ReadKey();
    }
}