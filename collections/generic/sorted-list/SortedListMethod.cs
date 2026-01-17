using System;
using System.Collections.Generic;

class SortedListMethod
{
    // Display SortedList elements
    static void DisplaySortedList(SortedList<int, string> list, string message)
    {
        Console.WriteLine(message);
        foreach (var kvp in list)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Create a SortedList
        SortedList<int, string> sortedList = new SortedList<int, string>();

        // Add elements
        sortedList.Add(2, "B");
        sortedList.Add(1, "A");
        sortedList.Add(3, "C");
        DisplaySortedList(sortedList, "After Add:");

        // Remove element
        sortedList.Remove(2);
        DisplaySortedList(sortedList, "After Remove(2):");

        // Access by key
        Console.WriteLine("Value with key 1: " + sortedList[1]);

        // Check contains
        Console.WriteLine("Contains key 3? " + sortedList.ContainsKey(3));
        Console.WriteLine("Contains value 'C'? " + sortedList.ContainsValue("C"));
        Console.WriteLine();
    }
}
