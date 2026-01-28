using System;
using System.Text.RegularExpressions;

class CensorBadWords
{
    static void Main()
    {
        string text = "This is a damn bad example with some stupid words.";
        string pattern = @"\b(damn|stupid)\b";

        // RegexOptions.IgnoreCase → handles DAMN, Damn, etc.
        string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);

        Console.WriteLine(result);
    }
}
