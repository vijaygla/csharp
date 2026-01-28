using System;
using System.Text.RegularExpressions;

class ValidateUsername
{
    static void Main()
    {
        string username = "user_123";

        // ^           → start of string
        // [A-Za-z]    → must start with a letter
        // [A-Za-z0-9_]→ allowed characters
        // {4,14}      → remaining length (total 5–15)
        // $           → end of string
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

        Console.WriteLine(Regex.IsMatch(username, pattern) ? "Valid" : "Invalid");
    }
}
