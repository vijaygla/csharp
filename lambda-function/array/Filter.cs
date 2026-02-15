using System;
using System.Linq;

class Filter
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 4, 5, 6};

        var even = nums.Where(num => num % 2 == 0);
        Console.WriteLine("Even elements: " + string.Join(", ", even));
    }
}
