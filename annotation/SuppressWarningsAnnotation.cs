using System;
using System.Collections;

class Program
{
    static void Main()
    {
#pragma warning disable 618
#pragma warning disable CS0618

        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");

        Console.WriteLine(list[0]);
        Console.WriteLine(list[1]);

#pragma warning restore CS0618
    }
}
