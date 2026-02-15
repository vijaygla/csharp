using System;
using System.Linq;

class Filter
{
    static void Main(string[] args)
    {
        int[] nums = {3, 4, 5, 6, 1, 2, 0 };

        var decendingOrder = nums.OrderByDescending(num => num);

        Console.WriteLine("Decending order elements : " +  string.Join(", ", decendingOrder));
    }
}
