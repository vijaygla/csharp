using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public int Marks { get; set; }
    }

    static void Main()
    {
        var students = new List<Student>
        {
            new Student{ Id=1, Name="Aman", Age=20, Course="CS", Marks=80},
            new Student{ Id=2, Name="Ravi", Age=18, Course="IT", Marks=70},
            new Student{ Id=3, Name="John", Age=20, Course="CS", Marks=90},
            new Student{ Id=4, Name="Sara", Age=22, Course="IT", Marks=85},
            new Student{ Id=5, Name="Neha", Age=21, Course="CS", Marks=60}
        };

        // WHERE (Filter)
        var filtered = students.Where(s => s.Marks > 70);

        // SELECT (Projection)
        var names = students.Select(s => s.Name);

        // ORDER BY + THEN BY
        var sorted = students.OrderBy(s => s.Age).ThenBy(s => s.Name);

        // GROUP BY
        var grouped = students.GroupBy(s => s.Course);

        // COUNT, SUM, AVG, MIN, MAX
        var count = students.Count();
        var sum = students.Sum(s => s.Marks);
        var avg = students.Average(s => s.Marks);
        var min = students.Min(s => s.Marks);
        var max = students.Max(s => s.Marks);

        // FIRST, FIRST OR DEFAULT
        var first = students.First();
        var firstOrDefault = students.FirstOrDefault(s => s.Marks > 100);

        // LAST, LAST OR DEFAULT
        var last = students.Last();
        var lastOrDefault = students.LastOrDefault(s => s.Marks > 100);

        // SINGLE, SINGLE OR DEFAULT
        var single = students.Single(s => s.Id == 1);
        var singleOrDefault = students.SingleOrDefault(s => s.Id == 100);

        // ANY, ALL
        var anyHigh = students.Any(s => s.Marks > 85);
        var allPass = students.All(s => s.Marks > 50);

        // TAKE, SKIP
        var take2 = students.Take(2);
        var skip2 = students.Skip(2);

        // DISTINCT
        var distinctCourses = students.Select(s => s.Course).Distinct();

        // JOIN
        var courses = new List<string> { "CS", "IT" };
        var joinData = students.Join(courses,
            s => s.Course,
            c => c,
            (s, c) => new { s.Name, c });

        // UNION, INTERSECT, EXCEPT
        var list1 = new List<int> { 1, 2, 3 };
        var list2 = new List<int> { 3, 4, 5 };

        var union = list1.Union(list2);
        var intersect = list1.Intersect(list2);
        var except = list1.Except(list2);

        // CONCAT
        var concat = list1.Concat(list2);

        // REVERSE
        list1.Reverse();

        // ELEMENT AT
        var elementAt = students.ElementAt(1);

        // DEFAULT IF EMPTY
        var emptyList = new List<int>();
        var defaultIfEmpty = emptyList.DefaultIfEmpty(0);

        // TO LIST, TO ARRAY, TO DICTIONARY
        var list = students.ToList();
        var array = students.ToArray();
        var dictionary = students.ToDictionary(s => s.Id);

        // FOR EACH PRINT
        Console.WriteLine("--- Filtered ---");
        foreach (var s in filtered)
            Console.WriteLine(s.Name);

        Console.WriteLine("--- Sorted ---");
        foreach (var s in sorted)
            Console.WriteLine(s.Name + " " + s.Age);

        Console.WriteLine("--- Grouped ---");
        foreach (var g in grouped)
        {
            Console.WriteLine(g.Key);
            foreach (var s in g)
                Console.WriteLine("  " + s.Name);
        }

        Console.WriteLine("Count: " + count);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Avg: " + avg);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
    }
}
