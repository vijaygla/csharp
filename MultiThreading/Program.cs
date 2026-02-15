// creating thread
// method 1 using thread class
using System;
using System.Threading;

namespace MultiThreading;

public class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Main thread Running");

        Thread t1 = new Thread(PrintNumbers);
        t1.Start(); // start the thread
    }

    static void PrintNumbers()
    {
        for(int i=1; i<=5; i++)  
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}

/*
Thread creates a new thread
Start() begins execution
Sleep() pauses thread
*/
