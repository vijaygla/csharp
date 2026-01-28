using System;
using System.Text.RegularExpressions;

class ExtractCurrency
{
    static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        string pattern = @"\$ ?\d+(\.\d{2})?";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value);
    }
}
