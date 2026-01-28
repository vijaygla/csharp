using System;
using System.Text.RegularExpressions;

class ValidateIPAddress
{
    static void Main()
    {
        string ip = "192.168.1.1";

        // Matches 0–255 safely
        string pattern = @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}"
                       + @"(25[0-5]|2[0-4]\d|[01]?\d\d?)$";

        Console.WriteLine(Regex.IsMatch(ip, pattern) ? "Valid IP" : "Invalid IP");
    }
}
