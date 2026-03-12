// public static string ValidateEmailUsingRegex(string email)
// {
//     string pattern = @"^[A-Za-z]+\.[A-Za-z]+\d*@(?:Sales|IT|Marketing|Product)\.company\.com$";
//     if(Regex.IsMatch(email, pattern))
//     {
//         return "Access Granted";
//     }
//     else
//     {
//         return "Access Denied";
//     }
// }

class ValidateEmail
{
    public static string ValidateEmailAddress(string email)
    {
        string[] emails = email.Split('@');
        if (emails.Length != 2)
        {
            return "Access Denied";
        }

        string fullName = emails[0];
        string domainName = emails[1];

        string[] domainSplit = domainName.Split('.');
        if (domainSplit.Length != 3)
        {
            return "Access Denied";
        }
        string department = domainSplit[0];
        string company = domainSplit[1];
        string domain = domainSplit[2];

        if (department != "Sales" && department != "Marketing" && department != "IT" && department != "Product")
        {
            return "Access Denied";
        }
        else if (company != "company")
        {
            return "Access Denied";
        }
        else if (domain != "com")
        {
            return "Access Denied";
        }

        string[] nameSplit = fullName.Split('.');
        string firstName = nameSplit[0];
        string lastName = nameSplit[1];

        foreach (var c in firstName)
        {
            if (!char.IsLetter(c))
            {
                return "Access Denied";
            }
        }

        foreach (var c in lastName)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return "Access Denied";
            }
        }

        return "Access Granted";
    }
    static void Main()
    {
        Console.WriteLine("Enter a valid email");
        // C:\v\Practice.cs(63,24): warning CS8600: Converting null literal or possible null value to non-nullable type.
        string? email = Console.ReadLine();

        // C:\v\Practice.cs(65,46): warning CS8604: Possible null reference argument for parameter 'email' in 'string ValidateEmail.ValidateEmailAddress(string email)
        if (string.IsNullOrEmpty(email)) return;

        string result = ValidateEmailAddress(email);
        Console.WriteLine(result);
    }
}
