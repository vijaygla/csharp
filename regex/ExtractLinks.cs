using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org";
        string pattern = @"https?://[^\s]+";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
