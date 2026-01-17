using System;
using System.Collections.Generic;

class HashSetMethod
{
    // Display HashSet elements
    static void Display(HashSet<int> set, string message)
    {
        Console.WriteLine(message + string.Join(", ", set));
    }

    static void Main()
    {
        // Create a new HashSet
        HashSet<int> set = new HashSet<int>();

        // 1. Add() - Insert elements
        set.Add(10);
        set.Add(20);
        set.Add(30);
        set.Add(10); // duplicate, will be ignored
        Display(set, "After Add: ");

        // 2. Remove() - Delete element
        set.Remove(20);
        Display(set, "After Remove(20): ");

        // 3. Contains() - Check if element exists
        Console.WriteLine("Contains 10? " + set.Contains(10));
        Console.WriteLine("Contains 50? " + set.Contains(50));
        Console.WriteLine();

        // 4. UnionWith() - Combine two sets
        HashSet<int> set2 = new HashSet<int>() { 30, 40, 50 };
        set.UnionWith(set2); // adds all elements from set2
        Display(set, "After UnionWith set2: ");

        // 5. IntersectWith() - Keep only common elements
        HashSet<int> set3 = new HashSet<int>() { 30, 50, 60 };
        set.IntersectWith(set3); // keeps only 30 and 50
        Display(set, "After IntersectWith set3: ");

        // 6. ExceptWith() - Remove elements of another set
        HashSet<int> set4 = new HashSet<int>() { 50 };
        set.ExceptWith(set4); // removes 50
        Display(set, "After ExceptWith set4: ");
    }
}
