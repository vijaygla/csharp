
/* requirement------------------------
start from SHIP-
than 6 digit not start from zero
no digit reepeat more than 3 time
date
year month day
1900-2099 01-12 01-31
[1-2][0-9][0-9][0-9]
amount
must not start with zero
6 digit max before decimal
decimal
Ship-129899|AES|1980-12-10|224529.12
*/

using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter any valid input");
//         string input = Console.ReadLine();

//         string pattern = @"^[Ss][Hh][Ii][Pp]-(?!.*[0-9].*\1.*\1.*\1)[1-9][0-9]{5}|(AES|BES|CES|DES|EES|FES)|(19[0-9]{2}|20[0-9]{2})-(0[1-9]|1[0-2])-(0[1-9]|1[0-9]|2[0-9]|3[0-1])[1-9][0-9]{0,5}\.[0-9]{2}$";

//         if (Regex.IsMatch(input, pattern))
//         {
//             Console.WriteLine("Valid");
//         }
//         else
//         {
//             Console.WriteLine("Invalid");
//         }
//     }
// }

// regex email verification---------------------------------------
// FirstName.LastName0-9@[Sales || IT || Marketing ||  Product].company.com

// class Program
// {
//     static void Main()
//     {
//         string pattern = @"^[A-Za-z]{1,}\.[A-Za-z]{1,}[0-9]{1,3}\@(Sales|IT|Marketing|Product)\.company\.com$";
//         Console.WriteLine("Enter number of input");
//         int n = int.Parse(Console.ReadLine());

//         for(int i=0; i<n; i++)
//         {
//             string input = Console.ReadLine();
//             if(Regex.IsMatch(input, pattern))
//             {
//                 Console.WriteLine("Access Granted");
//             }
//             else
//             {
//                 Console.WriteLine("Access Denied");
//             }
//         }
//     }
// }


// --------------------------------------------
// USER-AB2322  - valid
// USER-AB2222  - invalid

class Program
{
    static void Main()
    {
        string pattern = @"^USER-[A-Z]{2}(?!.*([0-9])\1\1\1)[1-9][0-9]{3}$";
        Console.WriteLine("Enter a valid input");
        string input = Console.ReadLine();
        
        if(Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}

