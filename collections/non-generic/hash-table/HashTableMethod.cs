// Stores data as key–value pairs

using System;
using System.Collections;

class HashtableMethodsDemo
{
    static void Main()
    {
        // Create Hashtable
        Hashtable hashTable = new Hashtable();

        // Add(key, value) → Insert elements
        hashTable.Add(1, "Apple");
        hashTable.Add(2, "Banana");
        hashTable.Add(3, "Mango");

        // Display Hashtable
        Console.WriteLine("Initial Hashtable:");
        Display(hashTable);

        // Remove(key) → Delete element using key
        hashTable.Remove(2);
        Console.WriteLine("\nAfter Remove(2):");
        Display(hashTable);

        // ContainsKey() → Check if key exists
        Console.WriteLine("\nContainsKey(1): " + hashTable.ContainsKey(1));
        Console.WriteLine("ContainsKey(5): " + hashTable.ContainsKey(5));

        // ContainsValue() → Check if value exists
        Console.WriteLine("\nContainsValue(Mango): " + hashTable.ContainsValue("Mango"));
        Console.WriteLine("ContainsValue(\"Grapes\"): " + hashTable.ContainsValue("Grapes"));

        // Keys → Get all keys
        Console.WriteLine("\nKeys:");
        foreach (var key in hashTable.Keys)
        {
            Console.WriteLine(key);
        }

        // Values → Get all values
        Console.WriteLine("\nValues:");
        foreach (var value in hashTable.Values)
        {
            Console.WriteLine(value);
        }
    }

    // Method to display Hashtable data
    static void Display(Hashtable table)
    {
        foreach (DictionaryEntry entry in table)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
