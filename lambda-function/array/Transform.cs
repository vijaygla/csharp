using System;
using System.Linq;

class Filter
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6 };

        var square = nums.Select(num => num * num);
        Console.WriteLine("Square of each number : " + string.Join(", ", square));
    }
}
