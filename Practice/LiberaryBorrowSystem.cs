using System;
using System.Text.RegularExpressions;

public class BorrowRecord
{
    public string StudentName { get; set; }
    public string BookTittle {get; set; }
    public string Category { get; set; }
    public int BorrowDay { get; set; }

    public BorrowRecord(string studentName, string bookTittle, string category, int borrowDay)
    {
        StudentName = studentName;
        BookTittle = bookTittle;
        Category = category;
        BorrowDay = borrowDay;
    }
}

public class Utility
{
    public void AddBorrowRecord(string studentName, string bookTittle, string category, int borrowDay)
    {
        int key = Program.SortedDict.Count + 1;
        BorrowRecord borrowRecord = new BorrowRecord(studentName, bookTittle, category, borrowDay);
        Program.SortedDict.Add(key, borrowRecord);
        Console.WriteLine("Record added successfully");
    }

    // group record by category
    public Dictionary<string, List<BorrowRecord>> GroupRecordByCategory()
    {
        Dictionary<string, List<BorrowRecord>> result = new Dictionary<string, List<BorrowRecord>>();

        foreach(var kv in Program.SortedDict)
        {
            var record = kv.Value;

            if(!result.ContainsKey(record.Category))
            {
                List<BorrowRecord> list = new List<BorrowRecord>();
                result[record.Category] = list; 
            }
            result[record.Category].Add(record);
        }
        return result;
    }

    // AverageBorrowDayPerCategory
    public Dictionary<string, double> AverageBorrowDayPerCategory()
    {
        Dictionary<string, double> result = new Dictionary<string, double>();
        
        var dict = GroupRecordByCategory();

        foreach(var kv in dict)
        {
            double totalBorrowDay = 0;

            foreach (var v in kv.Value)
            {
                totalBorrowDay += v.BorrowDay;
            }
            result[kv.Key] = totalBorrowDay / kv.Value.Count;
        }
        return result;
    }

    // LongestborrowBook
    public BorrowRecord LongestBorrowDay()
    {
        BorrowRecord longestBorrowRecord = null;

        foreach(var kv in Program.SortedDict)
        {
            if (longestBorrowRecord == null || kv.Value.BorrowDay > longestBorrowRecord.BorrowDay)
            {
                longestBorrowRecord = kv.Value;
            }
        }
        return longestBorrowRecord;
    }

    // filter record by min borrowDay
    public List<BorrowRecord> FilterRecordByMinimumBorrowDay(int minBorrowDay)
    {
        List<BorrowRecord> result = new List<BorrowRecord>();

        foreach(var kv in Program.SortedDict)
        {
            var record = kv.Value;
            if(record.BorrowDay >= minBorrowDay)
            {
                result.Add(record);
            }
        }
        return result;
    }
}

public class Program
{
    public static SortedDictionary<int, BorrowRecord> SortedDict = new SortedDictionary<int, BorrowRecord>();

    static void Main()
    {
        Utility utility = new  Utility();

        while(true)
        {
            Console.WriteLine("=== Liberary Management System ===");
            Console.WriteLine("1. Add Borrow Record");
            Console.WriteLine("2.Group Records By Category");
            Console.WriteLine("3.Show Average Borrow Days PerCategory");
            Console.WriteLine("4.Show Longest Borrowed Book");
            Console.WriteLine("5.Filter Members By Minimum Days");
            Console.WriteLine("6.Exit");

            Console.WriteLine("Enter choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter StudentName");
                    string studentName = Console.ReadLine();
                    
                    Console.WriteLine("Enter BookTittle ");
                    string bookTittle = Console.ReadLine();
                    
                    Console.WriteLine("Enter Category");
                    string category = Console.ReadLine();
                    
                    Console.WriteLine("Enter BorrowDay");
                    int borrowDay = int.Parse(Console.ReadLine());
                    
                    utility.AddBorrowRecord(studentName, bookTittle, category, borrowDay);
                    break;
                
                case 2:
                    var dict = utility.GroupRecordByCategory();
                    foreach(var kv in dict)
                    {
                        Console.WriteLine($"Category : {kv.Key}");
                        foreach(var v in kv.Value)
                        {
                            Console.WriteLine($"StudentName : {v.StudentName} || BookTittle : {v.BookTittle} || BorrowDay : {v.BorrowDay}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    var avgDict = utility.AverageBorrowDayPerCategory();
                    foreach (var kv in avgDict)
                    {
                        Console.WriteLine($"Category : {kv.Key} || AverageBorrowDayPerCategory : {kv.Value}");
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    var record = utility.LongestBorrowDay();
                    if(record != null)
                    {
                        Console.WriteLine($"StudentName : {record.StudentName} || BookTittle : {record.BookTittle} || Category : {record.Category} || BorrowDay : {record.BorrowDay}");
                    }
                    break;
                
                case 5: 
                    Console.WriteLine("Enter minBorrowDay");
                    int minBorrowDay = int.Parse(Console.ReadLine());
                    List<BorrowRecord> list = utility.FilterRecordByMinimumBorrowDay(minBorrowDay);
                    
                    foreach(var item in list)
                    {
                        Console.WriteLine($"StudentName : {item.StudentName} || BookTittle : {item.BookTittle} || Category : {item.Category} || BorrowDay : {item.BorrowDay}");
                    }
                    Console.WriteLine();
                    break;
                
                case 6: 
                    Console.WriteLine("Thank you");
                    return;
                
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
