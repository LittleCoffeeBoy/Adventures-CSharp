using System;
using System.Text;

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
public class STRBuilder
{
    public static void StringB()
    {
        string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
        Console.WriteLine($"Before StringBuilder Operation: {question}");

        StringBuilder newQuestionSB = new StringBuilder(question);

        for (int i = 0; i < newQuestionSB.Length; i++)
        {
            if (Char.IsLower(newQuestionSB[i]) == true)
            {
                newQuestionSB[i] = Char.ToUpper(newQuestionSB[i]);
            }
            else if (Char.IsUpper(newQuestionSB[i]) == true)
            {
                newQuestionSB[i] = Char.ToLower(newQuestionSB[i]);
            }
        }

        string strNewQuestion = newQuestionSB.ToString();
        Console.WriteLine($"After: {strNewQuestion}");
    }
}
