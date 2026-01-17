using System;
using System.Collections.Generic;

class QueueMethod
{
    // Display the queue elements
    static void Display(Queue<int> queue, string message)
    {
        Console.WriteLine(message + string.Join(", ", queue));
    }

    static void Main()
    {
        // Create a new queue
        Queue<int> queue = new Queue<int>();

        // 1. Enqueue() - Add elements
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        Display(queue, "After Enqueue: ");

        // 2. Dequeue() - Remove the first element
        int removed = queue.Dequeue();
        Console.WriteLine("Dequeued element: " + removed);
        Display(queue, "After Dequeue: ");

        // 3. Peek() - View the first element without removing
        int first = queue.Peek();
        Console.WriteLine("First element (Peek): " + first);
        Display(queue, "Queue after Peek (unchanged): ");

        // 4. Count - Get the size of the queue
        Console.WriteLine("Count of queue: " + queue.Count);
    }
}
