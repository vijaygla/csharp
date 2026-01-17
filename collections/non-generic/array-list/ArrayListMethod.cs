// ArrayList (Non-Generic)

// ✔ Dynamic size
// ❌ Not type-safe

using System;
using System.Collections;

class ArrayListMethod
{
    static void Main(String[] args)
    {
        ArrayList list = new ArrayList();

        // Add()
        list.Add(10);
        list.Add(30);
        list.Add(20);
        Console.WriteLine("After Add():");
        Print(list);

        // Insert()
        list.Insert(1, 15);
        Console.WriteLine("\nAfter Insert(1, 15):");
        Print(list);

        // Remove()
        list.Remove(30);
        Console.WriteLine("\nAfter Remove(30):");
        Print(list);

        // RemoveAt()
        list.RemoveAt(0);
        Console.WriteLine("\nAfter RemoveAt(0):");
        Print(list);

        // Count
        Console.WriteLine("\nCount: " + list.Count);

        // Contains()
        Console.WriteLine("\nContains 20: " + list.Contains(20));
        Console.WriteLine("Contains 50: " + list.Contains(50));

        // Sort()
        list.Sort();
        Console.WriteLine("\nAfter Sort():");
        Print(list);

        // Clear()
        list.Clear();
        Console.WriteLine("\nAfter Clear():");
        Console.WriteLine("Count: " + list.Count);
    }

    static void Print(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
