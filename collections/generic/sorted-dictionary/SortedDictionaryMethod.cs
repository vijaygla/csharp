using System;
using System.Collections.Generic;

class SortedDictionaryMethod
{
    // Display SortedDictionary elements
    static void DisplaySortedDict(SortedDictionary<int, string> dict, string message)
    {
        Console.WriteLine(message);
        foreach (var kvp in dict)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Create a SortedDictionary
        SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();

        // Add elements
        sortedDict.Add(2, "B");
        sortedDict.Add(1, "A");
        sortedDict[3] = "C"; // another way to add
        DisplaySortedDict(sortedDict, "After Add:");

        // Remove element
        sortedDict.Remove(1);
        DisplaySortedDict(sortedDict, "After Remove(1):");

        // Access by key
        Console.WriteLine("Value with key 3: " + sortedDict[3]);

        // Check contains
        Console.WriteLine("Contains key 2? " + sortedDict.ContainsKey(2));
        Console.WriteLine("Contains value 'C'? " + sortedDict.ContainsValue("C"));
        Console.WriteLine();
    }
}
