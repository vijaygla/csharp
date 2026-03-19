// The special regex characters (metacharacters) are:

// . ^ $ *+ ? ( )[ ] { } | \ 


// using System.Text.RegularExpressions;
// class EmailValidation
// {
//     static void Main()
//     {
//         List<string> list = new List<string>();
//         string pattern = @"^[a-z]{3,}\.[a-z]{3,}[0-9]{4,}\@(sales|marketing|IT|product)\.company\.com";
//         Console.WriteLine("Enter number of email");
//         int n = int.Parse(Console.ReadLine());

//         for(int i=0; i<n; i++)
//         {
//             string input = Console.ReadLine();
//             if(Regex.IsMatch(input, pattern))
//             {
//                 list.Add("Access Granted");
//             }
//             else
//             {
//                 list.Add("Access Denied");
//             }
//         }

//         foreach(var item in list)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }

// // ===================================================================
// using System.Text.RegularExpressions;
// class Program
// {
//     static string ValidateInput(string input)
//     {
//         /*
//         string datePattern = @"^\$\{DATE:(0[1-9]|1[0-9]|2[0-9]|3[0-1])-(0[1-9]|1[0-2])-(20[0-9]{2})\}$";
//         string upperPattern = @"^\$\{UPPER:[A-Za-z]+\}$";
//         string lowerPattern = @"^\$\{LOWER:[A-Za-z]+\}$";
//         string repeatPattern = @"^\$\{REPEAT:[A-Za-z]+\,[1-5]\}$";
//         */
//         string pattern = @"\$\{(.*?):(.*?)\}";
//         MatchCollection matches = Regex.Matches(input, pattern);

//         foreach(Match m in matches)
//         {
//             string full = m.Value;
//             string type = m.Groups[1].Value;
//             string value = m.Groups[2].Value;

//             string replacement = "INVALID";

//             if(type == "UPPER")
//             {
//                 if(Regex.IsMatch(value, @"^[A-Za-z]+$"))
//                 {
//                     replacement = value.ToUpper();
//                 }
//             }
//             else if (type == "LOWER")
//             {
//                 if (Regex.IsMatch(value, @"^[A-Za-z]+$"))
//                 {
//                     replacement = value.ToLower();
//                 }
//             }
//             else if(type == "DATE")
//             {
//                 if(Regex.IsMatch(value, @"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])-(0[1-9]|1[0-2])-(20[0-9]{2})$"))
//                 {
//                     string[] arr = value.Split('-');
//                     string year = arr[2];
//                     string month = arr[1];
//                     string day = arr[0];

//                     replacement = year + "/" + month + "/" + day;
//                 }
//             }
//             else if(type == "REPEAT")
//             {
//                 if(Regex.IsMatch(value, @"^[A-Za-z]+\,[1-5]$"))
//                 {
//                     replacement = "";
//                     string[] arr = value.Split(',');
//                     int count = int.Parse(arr[1]);
//                     string word = arr[0];

//                     for(int i=0; i<count; i++)
//                     {
//                         replacement += word;
//                     }
//                 }
//             }
//             input = input.Replace(full, replacement);
//         }
//         return input;
//     }
//     static void Main()
//     {
//         Console.WriteLine("Enter number of input");
//         int n = int.Parse(Console.ReadLine());

//         for (int i = 0; i < n; i++)
//         {
//             string input = Console.ReadLine();
//             Console.WriteLine(ValidateInput(input));
//         }
//     }
// }


// // ===========================================================================
// using System.Text.RegularExpressions;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter number of input");
//         int n = int.Parse(Console.ReadLine());

//         for(int i=0; i<n; i++)
//         {
//             string input = Console.ReadLine();
//             ValidateInput(input);
//         }
//     }

//     static void ValidateInput(string input)
//     {
//         if(input.Length < 6)
//         {
//             Console.WriteLine("Invalid Input (length < 6)");
//             return;
//         }
//         if(Regex.IsMatch(input, @" ")) // @"\s"
//         {
//             Console.WriteLine("Invalid Input (contains space)");
//             return;
//         }
//         if(Regex.IsMatch(input, @"\d"))
//         {
//             Console.WriteLine("Invalid Input (contains digits)");
//         }
//         if(!Regex.IsMatch(input, @"[A-Za-z]+"))
//         {
//             Console.WriteLine("Invalid Input (contains special character)");
//         }

//         input = input.ToLower();

//         string filter = "";

//         for(int i=0; i<input.Length; i++)
//         {
//             int asciiValue = (int)input[i];
//             if(asciiValue % 2 != 0)
//             {
//                 filter += input[i];
//             }
//         }

//         if(filter.Length == 0)
//         {
//             Console.WriteLine("Invalid Input (empty string)");
//             return;
//         }

//         char[] arr = filter.ToCharArray();
//         Array.Reverse(arr);

//         string reverse = new string(arr);

//         char[] newArr = reverse.ToCharArray();

//         for(int i=0; i<newArr.Length; i++)
//         {
//             if(i % 2 == 0)
//             {
//                 newArr[i] = char.ToUpper(newArr[i]);
//             }
//         }
//         string result = new string(newArr);

//         Console.WriteLine(result);
//     }
// }


// ================================================================
using System.Text.RegularExpressions;
class Program
{
    static string ValidateInput(string input)
    {
        string[] inputs = input.Split('|');
        if (inputs.Length != 5)
        {
            return "NON-COMPLIANT RECORD";
        }
        string first = inputs[0];
        string second = inputs[1];
        string third = inputs[2];
        string forth = inputs[3];
        string fifth = inputs[4];

        // validate first
        if (!Regex.IsMatch(first, @"^SHIP-[1-9][0-9]{5}$"))
        {
            return "NON-COMPLIANT RECORD";
        }
        string digit = first.Substring(5); // start index 5
        if (Regex.IsMatch(digit, @"([0-9])\1\1\1"))
        {
            return "NON-COMPLIANT RECORD";
        }

        // validate second
        if(!Regex.IsMatch(second, @"^(20[0-9]{2})-(0[1-9]|1[0-2])-(0[1-9]|1[0-9]|2[0-9]|3[0-1])$"))
        {
            return "NON-COMPLIANT RECORD";
        }

        // validate third
        if(!Regex.IsMatch(third, @"^(AIR|SEA|ROAD|RAIL|EXPRESS|FREIGHT)$"))
        {
            return "NON-COMPLIANT RECORD";
        }

        // validate forth
        if(!Regex.IsMatch(forth, @"^(0|[1-9][0-9]+)(\.[0-9]{1,2})$"))
        {
            return "NON-COMPLIANT RECORD";
        }
        double forth_Weight = double.Parse(forth);
        if(forth_Weight > 999999.99)
        {
            return "NON-COMPLIANT RECORD";
        }

        // validate fifth
        if (!Regex.IsMatch(fifth, @"^(DELIVERED|CANCELLED|IN_TRANSIT)$"))
        {
            return "NON-COMPLIANT RECORD";
        }

        return "COMPLIANT RECORD";
    }
    static void Main()
    {
        Console.WriteLine("Enter number of input");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ValidateInput(input));
        }
    }
}
