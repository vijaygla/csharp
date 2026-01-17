// FIFO – First In First Out

using System;
using System.Collections;

class QueueMethodsDemo
{
    static void Main()
    {
        // Create Queue
        Queue queue = new Queue();

        // Enqueue() → Insert elements into queue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("After Enqueue():");
        Display(queue);

        // Dequeue() → Remove and return first element
        int removed = (int)queue.Dequeue();
        Console.WriteLine("\nDequeued value: " + removed);

        Console.WriteLine("After Dequeue():");
        Display(queue);

        // Peek() → View first element without removing
        int first = (int)queue.Peek();
        Console.WriteLine("\nFirst element using Peek(): " + first);

        // Count → Get total number of elements
        Console.WriteLine("\nQueue Count: " + queue.Count);
    }

    // Method to display queue elements
    static void Display(Queue queue)
    {
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
