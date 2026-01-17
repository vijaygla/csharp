using System;
using System.Collections.Generic;

class ListMethod
{
    // Display method to print list elements with a message
    static void Display(List<int> list, string message)
    {
        Console.WriteLine(message + string.Join(", ", list));
    }

    static void Main()
    {
        // Create a new list
        List<int> list = new List<int>();

        // 1. Add() - Add single element
        list.Add(10);
        list.Add(20);
        list.Add(30);
        Display(list, "After Add: ");

        // 2. AddRange() - Add multiple elements
        list.AddRange(new int[] { 40, 50, 60 });
        Display(list, "After AddRange: ");

        // 3. Remove() - Remove a value
        list.Remove(20);
        Display(list, "After Remove(20): ");

        // 4. RemoveAt() - Remove by index
        list.RemoveAt(2); // removes the 3rd element (index 2)
        Display(list, "After RemoveAt(2): ");

        // 5. Insert() - Insert at specific index
        list.Insert(1, 25);
        Display(list, "After Insert(1, 25): ");

        // 6. Contains() - Check if list contains a value
        Console.WriteLine("Contains 50? " + list.Contains(50));
        Console.WriteLine("Contains 100? " + list.Contains(100));

        // 7. Sort() - Sort the list
        list.Sort();
        Display(list, "After Sort: ");

        // 8. Reverse() - Reverse the list
        list.Reverse();
        Display(list, "After Reverse: ");

        // 9. Count - Get number of elements
        Console.WriteLine("Count: " + list.Count);

        // 10. Clear() - Remove all elements
        list.Clear();
        Display(list, "After Clear, Count: "); // Will show an empty list
    }
}
