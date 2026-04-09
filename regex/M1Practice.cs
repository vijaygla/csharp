// The special regex characters (metacharacters) are:
// . ^ $ *+ ? ( )[ ] { } | \ 

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        string pattern = @"^[a-z]{3,}\.[a-z]{3,}[0-9]{4,}\@(sales|marketing|IT|product)\.company\.com";
        Console.WriteLine("Enter number of email");
        int n = int.Parse(Console.ReadLine());

        for(int i=0; i<n; i++)
        {
            string input = Console.ReadLine();
            if(Regex.IsMatch(input, pattern))
            {
                list.Add("Access Granted");
            }
            else
            {
                list.Add("Access Denied");
            }
        }

        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

// ===============================================================
class Program
{
    static string ValidateString(string input)
    {
        string placeHolderPattern = @"\$\{([A-Z]+):([A-Za-z0-9,-]+)\}";
        MatchCollection matches = Regex.Matches(input, placeHolderPattern);

        foreach (Match m in matches)
        {   
            string typeValue = m.Value;
            string type = m.Groups[1].Value;
            string value = m.Groups[2].Value;

            string result = "INVALID";

            if (type == "DATE")
            {
                string datePattern = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-(20[0-9]{2})$";
                if (Regex.IsMatch(value, datePattern))
                {
                    string[] dateSplit = value.Split('-');
                    result = $"{dateSplit[2]}/{dateSplit[1]}/{dateSplit[0]}";
                }
            }
            else if (type == "UPPER")
            {
                if (Regex.IsMatch(value, @"^[A-Za-z]+$"))
                {
                    result = value.ToUpper();
                }
            }
            else if (type == "LOWER")
            {
                if (Regex.IsMatch(value, @"^[A-Za-z]+$"))
                {
                    result = value.ToLower();
                }
            }
            else if (type == "REPEAT")
            {
                if (Regex.IsMatch(value, @"^[A-Za-z]+,[1-5]$"))
                {
                    string[] repeatSplit = value.Split(',');
                    string word = repeatSplit[0];
                    int count = int.Parse(repeatSplit[1]);
                    string temp = "";
                    for (int i = 0; i < count; i++)
                    {
                        temp += word;
                    }
                    result = temp;
                }
            }
            input = input.Replace(typeValue, result);
        }
        return input;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ValidateString(input));
        }
    }
}

// ===============================================================
class Program
{
    public static string ValidateString(string input)
    {
        if (input.Length < 6)
        {
            return "Invalid Input (length < 6)";
        }
        if (Regex.IsMatch(input, @"\s"))
        {
            return "Invalid Input (contains space)";
        }
        if (Regex.IsMatch(input, @"\d"))
        {
            return "Invalid Input (contains digits)";
        }
        if (!Regex.IsMatch(input, @"^[A-Za-z]+$"))
        {
            return "Invalid Input (contains special character)";
        }
        input = input.ToLower();
        string filter = "";

        for (int i = 0; i < input.Length; i++)
        {
            int asciiValue = (int)input[i];
            if (asciiValue % 2 != 0)
            {
                filter += input[i];
            }
        }
        if (filter.Length == 0)
        {
            return "Invalid Input (empty string)";
        }
        string reverse = "";
        for (int i = filter.Length - 1; i >= 0; i--)
        {
            reverse += filter[i];
        }
        string result = "";
        for (int i = 0; i < reverse.Length; i++)
        {
            if (i % 2 == 0)
            {
                result += char.ToUpper(reverse[i]);
            }
            else
            {
                result += reverse[i];
            }
        }
        return $"The generated key is - {result}";
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ValidateString(input));
        }
    }
}


// ===============================================================
class Program
{
    static bool IsLeapYear(int year)
    {
        return year % 4 == 0;
    }

    static string ValidateString(string input)
    {
        string[] inputs = input.Split('|');
        if (inputs.Length != 5) return "NON-COMPLIANT RECORD";
        string first = inputs[0];
        string second = inputs[1];
        string third = inputs[2];
        string forth = inputs[3];
        string fifth = inputs[4];

        // validate shipment code
        if (!Regex.IsMatch(first, @"^SHIP-[1-9]\d{5}$")) return "NON-COMPLIANT RECORD";

        string[] firstSplit = first.Split('-');
        string digit = firstSplit[1];
        if (Regex.IsMatch(digit, @"(\d){\1\1\1}")) return "NON-COMPLIANT RECORD";

        // valdidate date
        if (!Regex.IsMatch(second, @"^\d{4}-\d{2}-\d{2}$")) return "NON-COMPLIANT RECORD";

        string[] secondSplit = second.Split('-');
        int year = int.Parse(secondSplit[0]);
        int month = int.Parse(secondSplit[1]);
        int day = int.Parse(secondSplit[2]);

        if (year < 2000 || year > 2099) return "NON-COMPLIANT RECORD";
        if (month < 1 || month > 12) return "NON-COMPLIANT RECORD";
        int[] days = { 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (day < 1 || day > days[month - 1]) return "NON-COMPLIANT RECORD";

        // validate mode
        if (!Regex.IsMatch(third, @"^(AIR|SEA|ROAD|RAIL|EXPRESS|FREIGHT)$")) return "NON-COMPLIANT RECORD";

        // validate weight
        if (!Regex.IsMatch(forth, @"^(0|[1-9]\d{0,5})(\.\d{2})?$")) return "NON-COMPLIANT RECORD";
        double weight = double.Parse(forth);
        if (weight < 0 || weight > 999999.99) return "NON-COMPLIANT RECORD";

        // validate delevery status
        if (!Regex.IsMatch(fifth, @"^(DELIVERED|CANCELLED|IN_TRANSIT)$")) return "NON-COMPLIANT RECORD";

        return "COMPLIANT RECORD";
    }

    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ValidateString(input));
        }
    }
}

// ====================================================================
class Program
{
    public static string ValidateString(string input)
    {
        // Rule 1: Mask IPv4 Addresses
        string ipPattern = @"IP:(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)";
        input = Regex.Replace(input, ipPattern, "IP:***.***.***.$4");

        // Rule 2: Mask Email Username
        string emailPattern = @"Email:([a-zA-Z0-9._%+-]+)@([a-zA-Z0-9.-]+\.[a-zA-Z]{2,})";
        input = Regex.Replace(input, emailPattern, "Email:****@$2");

        // Rule 3: Collapse Repeated Error Codes
        string errorPattern = @"\b(ERROR\d+)( \1\b)+";
        input = Regex.Replace(input, errorPattern, "$1");

        // Rule 4: Normalize Timestamp
        string datePattern = @"\[(\d{2})/(\d{2})/(\d{4}) (\d{2}:\d{2}:\d{2})\]";
        input = Regex.Replace(input, datePattern, "[$3-$2-$1 $4]");

        return input;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(ValidateString(input));
    }
}
