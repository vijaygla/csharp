using System;
using System.Threading;

namespace MultiThreading;

public class PrintDemo
{
    public static void Print1()
    {
        for(int i=1; i<=10; i++)
        {
            Console.WriteLine("Print 1 : " + i);
        }
        Console.WriteLine("Print 1 exit----------");
    }

    public static void Print2()
    {
        for(int i=1; i<=10; i++)
        {
            Console.WriteLine("Print 2 : " + i);
            if(i == 5) 
            {
                Console.WriteLine("Main thread sleep for 5 second");
                Thread.Sleep(5000);
                Console.WriteLine("Main thread start after 5 second");
            }
        }
        Console.WriteLine("Print 2 exit----------");
    }

    public static void Print3()
    {
        for(int i=1; i<=10; i++)
        {
            Console.WriteLine("Print 3 : " + i);
        }
        Console.WriteLine("Print 3 exit----------");
    }

    static void Main()
    {
        Thread t1 = new Thread(Print1);
        Thread t2 = new Thread(Print2);
        Thread t3 = new Thread(Print3);

        t1.Start();
        t2.Start();
        t3.Start();
    }
}
