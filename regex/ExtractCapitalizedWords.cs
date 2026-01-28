using System;
using System.Text.RegularExpressions;

class ExtractCapitalizedWords
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        string pattern = @"\b[A-Z][a-z]*\b";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
