using System;
using System.Linq;
using System.Collections.Generic;

namespace LambdaArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 2, 3 };

            Console.WriteLine("Original Array:");
            Print(numbers);

            // 1. Where() - Filter elements
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("\nWhere() - Even numbers:");
            Print(evenNumbers);

            // 2. Select() - Transform elements
            var squares = numbers.Select(n => n * n);
            Console.WriteLine("\nSelect() - Squares:");
            Print(squares);

            // 3. OrderBy()
            var ascending = numbers.OrderBy(n => n);
            Console.WriteLine("\nOrderBy() - Ascending:");
            Print(ascending);

            // 4. OrderByDescending()
            var descending = numbers.OrderByDescending(n => n);
            Console.WriteLine("\nOrderByDescending():");
            Print(descending);

            // 5. Any() - Check if any element matches condition
            bool hasEven = numbers.Any(n => n % 2 == 0);
            Console.WriteLine("\nAny() - Has even number: " + hasEven);

            // 6. All() - Check if all elements match condition
            bool allPositive = numbers.All(n => n > 0);
            Console.WriteLine("All() - All positive: " + allPositive);

            // 7. Count()
            int evenCount = numbers.Count(n => n % 2 == 0);
            Console.WriteLine("Count() - Even count: " + evenCount);

            // 8. First()
            int firstEven = numbers.First(n => n % 2 == 0);
            Console.WriteLine("First() - First even: " + firstEven);

            // 9. FirstOrDefault()
            int firstGreaterThanTen = numbers.FirstOrDefault(n => n > 10);
            Console.WriteLine("FirstOrDefault() (>10): " + firstGreaterThanTen);

            // 10. Last()
            int lastEven = numbers.Last(n => n % 2 == 0);
            Console.WriteLine("Last() - Last even: " + lastEven);

            // 11. LastOrDefault()
            int lastGreaterThanTen = numbers.LastOrDefault(n => n > 10);
            Console.WriteLine("LastOrDefault() (>10): " + lastGreaterThanTen);

            // 12. Single()
            int singleValue = numbers.Single(n => n == 4);
            Console.WriteLine("Single() - Value 4: " + singleValue);

            // 13. SingleOrDefault()
            int singleDefault = numbers.SingleOrDefault(n => n == 100);
            Console.WriteLine("SingleOrDefault() (100): " + singleDefault);

            // 14. Contains()
            bool containsThree = numbers.Contains(3);
            Console.WriteLine("Contains(3): " + containsThree);

            // 15. Sum()
            int sum = numbers.Sum();
            Console.WriteLine("Sum(): " + sum);

            // 16. Max()
            int max = numbers.Max();
            Console.WriteLine("Max(): " + max);

            // 17. Min()
            int min = numbers.Min();
            Console.WriteLine("Min(): " + min);

            // 18. Average()
            double avg = numbers.Average();
            Console.WriteLine("Average(): " + avg);

            // 19. Take()
            var firstThree = numbers.Take(3);
            Console.WriteLine("\nTake(3):");
            Print(firstThree);

            // 20. Skip()
            var skipTwo = numbers.Skip(2);
            Console.WriteLine("\nSkip(2):");
            Print(skipTwo);

            // 21. Distinct()
            var unique = numbers.Distinct();
            Console.WriteLine("\nDistinct():");
            Print(unique);

            // 22. Reverse()
            var reversed = numbers.Reverse();
            Console.WriteLine("\nReverse():");
            Print(reversed);

            // 23. ToArray()
            int[] evenArray = numbers.Where(n => n % 2 == 0).ToArray();

            // 24. ToList()
            List<int> evenList = numbers.Where(n => n % 2 == 0).ToList();

            // 25. GroupBy()
            var groups = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
            Console.WriteLine("\nGroupBy() - Even / Odd:");
            foreach (var group in groups)
            {
                Console.Write(group.Key + ": ");
                Print(group);
            }

            // 26. SelectMany()
            int[][] matrix =
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };
            var flat = matrix.SelectMany(a => a);
            Console.WriteLine("\nSelectMany() - Flatten array:");
            Print(flat);

            // 27. Zip()
            int[] a1 = { 1, 2, 3 };
            int[] a2 = { 10, 20, 30 };
            var zipped = a1.Zip(a2, (x, y) => x + y);
            Console.WriteLine("\nZip() - Sum of arrays:");
            Print(zipped);

            // 28. Aggregate()
            int product = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("\nAggregate() - Product: " + product);

            Console.WriteLine("\n--- End of Demo ---");
        }

        // Helper method to print collections
        static void Print(IEnumerable<int> data)
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
