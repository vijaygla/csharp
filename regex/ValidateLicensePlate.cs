using System;
using System.Text.RegularExpressions;

class ValidateLicensePlate
{
    static void Main()
    {
        string plate = "AB1234";
        string pattern = @"^[A-Z]{2}[0-9]{4}$";

        Console.WriteLine(Regex.IsMatch(plate, pattern) ? "Valid" : "Invalid");
    }
}
