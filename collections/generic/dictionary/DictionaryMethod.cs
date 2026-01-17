using System;
using System.Collections.Generic;

class DictionaryMethod
{
    // Display dictionary contents with a message
    static void Display(Dictionary<int, string> dict, string message)
    {
        Console.WriteLine(message);
        foreach (var kvp in dict)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
        Console.WriteLine(); // for spacing
    }

    static void Main()
    {
        // Create a new dictionary
        Dictionary<int, string> dict = new Dictionary<int, string>();

        // 1. Add() - Insert elements
        dict.Add(1, "Apple");
        dict[2] = "Banana"; // another way to add
        dict[3] = "Cherry";
        Display(dict, "After adding elements:");

        // 2. Remove() - Delete element by key
        dict.Remove(2); // removes key 2
        Display(dict, "After Remove(2):");

        // 3. ContainsKey() - Check if key exists
        Console.WriteLine("ContainsKey(1)? " + dict.ContainsKey(1));
        Console.WriteLine("ContainsKey(5)? " + dict.ContainsKey(5));
        Console.WriteLine();

        // 4. ContainsValue() - Check if value exists
        Console.WriteLine("ContainsValue(\"Apple\")? " + dict.ContainsValue("Apple"));
        Console.WriteLine("ContainsValue(\"Mango\")? " + dict.ContainsValue("Mango"));
        Console.WriteLine();

        // 5. TryGetValue() - Safe fetch
        if (dict.TryGetValue(3, out string value))
        {
            Console.WriteLine("TryGetValue(3) found: " + value);
        }
        else
        {
            Console.WriteLine("Key 3 not found!");
        }

        if (dict.TryGetValue(5, out value))
        {
            Console.WriteLine("TryGetValue(5) found: " + value);
        }
        else
        {
            Console.WriteLine("Key 5 not found!");
        }
        Console.WriteLine();

        // 6. Keys - Get all keys
        Console.WriteLine("All Keys: " + string.Join(", ", dict.Keys));

        // 7. Values - Get all values
        Console.WriteLine("All Values: " + string.Join(", ", dict.Values));
    }
}
