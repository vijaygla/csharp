using System;
using System.Text.RegularExpressions;

class ValidateCreditCard
{
    static void Main()
    {
        string card = "4111111111111111";

        string visa = @"^4\d{15}$";
        string master = @"^5\d{15}$";

        if (Regex.IsMatch(card, visa))
            Console.WriteLine("Visa Card");
        else if (Regex.IsMatch(card, master))
            Console.WriteLine("MasterCard");
        else
            Console.WriteLine("Invalid Card");
    }
}
