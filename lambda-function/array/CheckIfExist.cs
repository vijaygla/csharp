using System;
using System.Linq;
using System.Reflection.Metadata;

class Filter
{
    static void Main(string[] args)
    {
        int[] nums = { 3, 4, 5, 6, 1, 2, 0 };

        var anyOdd = nums.Any(num => num % 2 != 0);
        Console.WriteLine("Any Odd elements : " + string.Join(", ", anyOdd));
    }
}
