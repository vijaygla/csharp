using System;
using System.Collections;

class SortedListMethod
{
    static void Main()
    {
        // Create SortedList
        SortedList sl = new SortedList();

        // Add(key, value)
        sl.Add(3, "C");
        sl.Add(1, "A");
        sl.Add(2, "B");

        // Display SortedList (sorted by key)
        Console.WriteLine("Initial SortedList:");
        Display(sl);

        // Count - total elements
        Console.WriteLine("Count: " + sl.Count);

        // Capacity - internal capacity
        Console.WriteLine("Capacity: " + sl.Capacity);

        // Access value using indexer
        Console.WriteLine("Value at key 1: " + sl[1]);

        // Update value using key
        sl[1] = "Updated A";

        // Contains / ContainsKey
        Console.WriteLine("Contains key 2: " + sl.Contains(2));
        Console.WriteLine("ContainsKey 3: " + sl.ContainsKey(3));

        // ContainsValue
        Console.WriteLine("ContainsValue B: " + sl.ContainsValue("B"));

        // GetByIndex - value by index
        Console.WriteLine("Value at index 0: " + sl.GetByIndex(0));

        // GetKey - key by index
        Console.WriteLine("Key at index 0: " + sl.GetKey(0));

        // IndexOfKey
        Console.WriteLine("Index of key 3: " + sl.IndexOfKey(3));

        // IndexOfValue
        Console.WriteLine("Index of value B: " + sl.IndexOfValue("B"));

        // SetByIndex - update value at index
        sl.SetByIndex(0, "Z");

        // Keys collection
        Console.WriteLine("Keys:");
        foreach (object key in sl.Keys)
        {
            Console.WriteLine(key);
        }

        // Values collection
        Console.WriteLine("Values:");
        foreach (object value in sl.Values)
        {
            Console.WriteLine(value);
        }

        // Remove by key
        sl.Remove(2);

        // RemoveAt by index
        sl.RemoveAt(0);

        // Properties
        Console.WriteLine("IsReadOnly: " + sl.IsReadOnly);
        Console.WriteLine("IsFixedSize: " + sl.IsFixedSize);
        Console.WriteLine("IsSynchronized: " + sl.IsSynchronized);

        // SyncRoot
        object syncObj = sl.SyncRoot;

        // Trim excess capacity
        sl.TrimToSize();

        // Display after removals
        Console.WriteLine("After Remove operations:");
        Display(sl);

        // Clear all elements
        sl.Clear();
        Console.WriteLine("After Clear(), Count: " + sl.Count);
    }

    // Method to display SortedList
    static void Display(SortedList sl)
    {
        foreach (DictionaryEntry item in sl)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
        Console.WriteLine();
    }
}
