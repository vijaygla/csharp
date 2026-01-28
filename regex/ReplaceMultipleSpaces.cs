using System;
using System.Text.RegularExpressions;

class ReplaceMultipleSpaces
{
    static void Main()
    {
        string text = "This   is   an   example";
        string result = Regex.Replace(text, @"\s+", " ");

        Console.WriteLine(result);
    }
}
