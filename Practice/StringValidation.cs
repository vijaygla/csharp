using System;
using System.Collections.Generic;


class StringValidation
{
    public static List<int> Check(int n, string[] strings)
    {
        List<int> result = new List<int>();

        for(int i=0; i < n; i++)
        {
            string input = strings[i];
        
            if (input.Length >= 3 &&
                    'A' <= input[0] && input[0] <= 'Z' ||
                    'a' <= input[0] && input[0] <= 'z' &&
                    '0' <= input[input.Length - 1] && input[input.Length - 1] <= '9')
            {
                result.Add(1);
            }
            else
            {
                result.Add(0);
            }
        }

        return result;
    }

    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] strings = new string[n];

        for(int i=0; i<n; i++)
        {
            string input = Console.ReadLine();
            strings[i] = input;
        }

        List<int> result  = Check(n, strings);

        foreach(int a in result)
        {
            Console.WriteLine(a);
        }
    }
}


/* Test case
3  // size
vf4
ghjk
Jo0
*/
