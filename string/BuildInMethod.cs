// StringMethodsDemo.cs
// This program demonstrates commonly used String methods in C#

using System;
using System.Linq;   // Required for Reverse()

class BuildInMethod
{
    static void Main()
    {
        // Original string
        string text = "  Hello World  ";

        // 1. Length - Returns total number of characters (including spaces)
        Console.WriteLine("Length: " + text.Length);

        // 2. Trim() - Removes spaces from beginning and end
        string trimmed = text.Trim();
        Console.WriteLine("Trim: " + trimmed);

        // 3. ToUpper() - Converts string to uppercase
        Console.WriteLine("ToUpper: " + trimmed.ToUpper());

        // 4. ToLower() - Converts string to lowercase
        Console.WriteLine("ToLower: " + trimmed.ToLower());

        // 5. Contains() - Checks if substring exists
        Console.WriteLine("Contains 'World': " + trimmed.Contains("World"));

        // 6. StartsWith() - Checks starting characters
        Console.WriteLine("StartsWith 'Hello': " + trimmed.StartsWith("Hello"));

        // 7. EndsWith() - Checks ending characters
        Console.WriteLine("EndsWith 'World': " + trimmed.EndsWith("World"));

        // 8. IndexOf() - Returns first occurrence index
        Console.WriteLine("IndexOf 'o': " + trimmed.IndexOf("o"));

        // 9. LastIndexOf() - Returns last occurrence index
        Console.WriteLine("LastIndexOf 'o': " + trimmed.LastIndexOf("o"));

        // 10. Substring() - Extract part of string (startIndex, length)
        Console.WriteLine("Substring(0,5): " + trimmed.Substring(0, 5));

        // 11. Replace() - Replaces old value with new value
        Console.WriteLine("Replace 'World' with 'C#': " + trimmed.Replace("World", "C#"));

        // 12. Split() - Splits string into array
        string names = "Ram,Shyam,Mohan";
        string[] arr = names.Split(',');
        Console.WriteLine("Split:");
        foreach (string name in arr)
        {
            Console.WriteLine(name);
        }

        // 13. Concat() - Joins multiple strings
        string concatText = string.Concat("Hello", " ", "C#");
        Console.WriteLine("Concat: " + concatText);

        // 14. Join() - Joins array elements with separator
        string joined = string.Join("-", arr);
        Console.WriteLine("Join: " + joined);

        // 15. Compare() - Compares two strings (true = ignore case)
        Console.WriteLine("Compare 'abc' and 'ABC': " + string.Compare("abc", "ABC", true));

        // 16. Equals() - Checks equality with case option
        Console.WriteLine("Equals IgnoreCase: " + "abc".Equals("ABC", StringComparison.OrdinalIgnoreCase));

        // 17. Reverse() - Reverse string using LINQ
        string reversed = new string(trimmed.Reverse().ToArray());
        Console.WriteLine("Reverse: " + reversed);

        // 18. Insert() - Inserts value at specified index
        Console.WriteLine("Insert: " + trimmed.Insert(5, " C#"));

        // 19. Remove() - Removes characters (startIndex, count)
        Console.WriteLine("Remove: " + trimmed.Remove(5, 6));

        // 20. PadLeft() - Adds padding to left side
        Console.WriteLine("PadLeft: " + trimmed.PadLeft(20, '*'));

        // 21. PadRight() - Adds padding to right side
        Console.WriteLine("PadRight: " + trimmed.PadRight(20, '*'));

        // 22. IsNullOrEmpty() - Checks if string is null or empty
        string emptyText = "";
        Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(emptyText));

        // 23. IsNullOrWhiteSpace() - Checks if string is null, empty, or only spaces
        string whiteSpaceText = "   ";
        Console.WriteLine("IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace(whiteSpaceText));
    }
}
