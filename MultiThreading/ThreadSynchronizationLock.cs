using System;
using System.Threading;

class ThreadSynchronizationLock
{
    private int value = 0;
    private object lockObject = new object();

    public void Increment()
    {
        lock (lockObject)
        {
            value++;
        }
    }

    public int GetValue()
    {
        return value;
    }

    static void Main(string[] args)
    {
        ThreadSynchronizationLock counter = new ThreadSynchronizationLock();

        Thread t1 = new Thread(() =>
        {
            for (int i = 1; i <= 1000; i++)
            {
                counter.Increment();
            }
        });

        Thread t2 = new Thread(() =>
        {
            for (int i = 1; i <= 1000; i++)
            {
                counter.Increment();
            }
        });

        t1.Start();
        t2.Start();

        t1.Join();   // Wait for thread 1
        t2.Join();   // Wait for thread 2
        // Join() : ----> Makes the current thread wait until another thread finishes.

        Console.WriteLine("Final Value: " + counter.GetValue());
    }
}
