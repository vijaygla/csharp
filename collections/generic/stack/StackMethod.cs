using System;
using System.Collections.Generic;

class StackMethod
{
    // Display stack elements
    static void Display(Stack<int> stack, string message)
    {
        Console.WriteLine(message);
        foreach (var item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n"); // for spacing
    }

    static void Main()
    {
        // Create a new stack
        Stack<int> stack = new Stack<int>();

        // 1. Push() - Add elements
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Display(stack, "After Push:");

        // 2. Pop() - Remove the top element
        int removed = stack.Pop();
        Console.WriteLine("Popped element: " + removed);
        Display(stack, "After Pop:");

        // 3. Peek() - View the top element without removing
        int top = stack.Peek();
        Console.WriteLine("Top element (Peek): " + top);
        Display(stack, "Stack after Peek (unchanged):");

        // 4. Count - Get the size of the stack
        Console.WriteLine("Count of stack: " + stack.Count);
    }
}
