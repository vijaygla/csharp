using System;
using System.Text.RegularExpressions;

class FindRepeatingWords
{
    static void Main()
    {
        string text = "This is is a repeated repeated word test.";

        // (\b\w+\b) → captures a word
        // \s+\1     → same word repeated
        string pattern = @"\b(\w+)\b\s+\1\b";

        foreach (Match m in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
            Console.WriteLine(m.Groups[1].Value);
    }
}
