class Program
{
    public static SortedDictionary<char, int> CountCharacter(string s)
    {
        SortedDictionary<char, int> result = new SortedDictionary<char, int>();

        foreach (char c in s)
        {
            if (result.ContainsKey(c))
            {
                result[c]++;
            }
            else
            {
                // result.Add(c, 1);
                result[c] = 1;
            }
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter any String");
        string s = Console.ReadLine();

        var dict = CountCharacter(s);

        foreach (var kv in dict)
        {
            Console.WriteLine($"{kv.Key}: {kv.Value}");
        }
    }
}
