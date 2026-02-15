using System;
using System.Threading;

class PrintThreadName
{
    static void Main()
    {
        Thread t = Thread.CurrentThread;
        t.Name = "My Main thread";

        Console.WriteLine("My thread name is : " + Thread.CurrentThread.Name);
    }
}
