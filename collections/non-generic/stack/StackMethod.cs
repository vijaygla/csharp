// LIFO – Last In First Out

using System;
using System.Collections;

class StackMethodsDemo
{
    static void Main()
    {
        // Create Stack
        Stack stack = new Stack();

        // Push() → Insert elements into stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("After Push():");
        Display(stack);

        // Pop() → Remove and return top element
        int val = (int)stack.Pop();
        Console.WriteLine("\nPopped value: " + val);

        Console.WriteLine("After Pop():");
        Display(stack);

        // Peek() → View top element without removing
        int top = (int)stack.Peek();
        Console.WriteLine("\nTop element using Peek(): " + top);

        // Count → Get total number of elements
        Console.WriteLine("\nStack Count: " + stack.Count);
    }

    // Method to display stack elements
    static void Display(Stack stack)
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
