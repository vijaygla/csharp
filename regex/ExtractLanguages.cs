using System;
using System.Text.RegularExpressions;

class ExtractLanguages
{
    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string pattern = @"\b(Java|Python|JavaScript|Go)\b";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
