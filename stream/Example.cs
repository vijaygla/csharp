using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "example.txt";

        // Writing to a file using StreamWriter
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("Hello, this is the first line.");
            sw.WriteLine("This is the second line.");
            sw.WriteLine("StreamWriter makes writing easy!");
        }

        Console.WriteLine("Data written to file successfully.\n");

        // Reading from a file using StreamReader
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            Console.WriteLine("Reading data from file:");
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
