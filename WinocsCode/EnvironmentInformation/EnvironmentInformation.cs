using System;
using System.Collections;

// Reference: https://docs.microsoft.com/pt-br/dotnet/api/system.environment?view=netframework-4.7.1
class EnvironmentInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Enrivonment Members --");

        Console.WriteLine($"\n\nCommandLine: {Environment.CommandLine}");

        string[] arguments = Environment.GetCommandLineArgs();
        Console.WriteLine($"\n\nGetCommandLineArgs: {String.Join(", ", arguments)}");

        Console.WriteLine($"\n\nCurrentDirectory: {Environment.CurrentDirectory}");

        Console.WriteLine($"\n\nExitCode: {Environment.ExitCode}");

        Console.WriteLine($"\n\nHasShutDownStarted: {Environment.HasShutdownStarted}");

        Console.WriteLine($"\n\nMachineName: {Environment.MachineName}");

        Console.WriteLine("\n\nNewLine: {0}    first line {0}    second line {0}    third line", Environment.NewLine);

        Console.WriteLine($"\n\nOSVersion: {Environment.OSVersion}");

        Console.WriteLine($"\n\nStackTrace: {Environment.StackTrace}");

        Console.WriteLine($"\n\nSystemDirectory: {Environment.SystemDirectory}");

        Console.WriteLine($"\n\nTickCount: {Environment.TickCount}");

        Console.WriteLine($"\n\nUserDomainName: {Environment.UserDomainName}");

        Console.WriteLine($"\n\nUserInteractive: {Environment.UserInteractive}");

        Console.WriteLine($"\n\nUserName: {Environment.UserName}");

        Console.WriteLine($"\n\nVersion: {Environment.Version}");

        Console.WriteLine($"\n\nWorkingSet: {Environment.WorkingSet}");

        string query = "My system drive is %SystemDrive% and my system root is %SystemRoot%";
        string expEnvironmentVariable = Environment.ExpandEnvironmentVariables(query);
        string newLine = Environment.NewLine;
        Console.WriteLine($"\n\nExpandEnvironmentVariable: {newLine}  {expEnvironmentVariable}");

        Console.WriteLine($"\n\nGetEnvironmentVariable: {newLine}  My temporary directory is {Environment.GetEnvironmentVariable("TEMP")}.");

        Console.WriteLine("\n\nGetEnvironmentVariables: ");
        IDictionary environmentVariables = Environment.GetEnvironmentVariables();
        foreach (DictionaryEntry variable in environmentVariables)
        {
            Console.WriteLine($"    {variable.Key} = {variable.Value}");
        }

        Console.WriteLine($"\n\nGetFolderPath: {Environment.GetFolderPath(Environment.SpecialFolder.System)}");

        string[] drives = Environment.GetLogicalDrives();
        Console.WriteLine($"\n\nGetLogicalDrives: {String.Join(", ", drives)}");

        Console.Write("\n\nPress any key to exit.");
        Console.ReadKey();
    }
}