using System;
using System.Collections.Generic;

class LinkedListMethod
{
    // Display LinkedList elements
    static void Display(LinkedList<int> list, string message)
    {
        Console.WriteLine(message);
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n"); // for spacing
    }

    static void Main()
    {
        // Create a new LinkedList
        LinkedList<int> list = new LinkedList<int>();

        // 1. AddFirst() - Insert at the start
        list.AddFirst(10);
        list.AddFirst(5); // adding another at start
        Display(list, "After AddFirst:");

        // 2. AddLast() - Insert at the end
        list.AddLast(20);
        list.AddLast(25);
        Display(list, "After AddLast:");

        // 3. RemoveFirst() - Delete first element
        list.RemoveFirst();
        Display(list, "After RemoveFirst:");

        // 4. RemoveLast() - Delete last element
        list.RemoveLast();
        Display(list, "After RemoveLast:");

        // 5. Find() - Search for a value
        LinkedListNode<int> node = list.Find(10);
        if (node != null)
        {
            Console.WriteLine("Found element: " + node.Value);
        }
        else
        {
            Console.WriteLine("Element not found!");
        }
    }
}
