using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public int Score { get; set; }

    public Student(string name, string subject, int score)
    {
        Name = name;
        Subject = subject;
        Score = score;
    }
}

// utility
public class Utility
{
    // add student
    public void AddStudent(string name, string subject, int score)
    {
        int key = Program.sortedDict.Count + 1;
        Student student = new Student(name, subject, score);

        Program.sortedDict.Add(key, student);
        Console.WriteLine("Student add successfully");
    }

    // GroupStudentBySubject
    public SortedDictionary<string, List<Student>> GroupStudentBySubject()
    {
        SortedDictionary<string, List<Student>> result = new SortedDictionary<string, List<Student>>();

        foreach(var item in Program.sortedDict)
        {
            Student record = item.Value;

            if(!result.ContainsKey(record.Subject))
            {
                result[record.Subject] = new List<Student>();
            }
            result[record.Subject].Add(record);
        }
        return result;
    }

    // average score per subject
    // public Dictionary<string, double> AverageScorePerSubject()
    // {
    //     Dictionary<string, double> averageResult = new Dictionary<string, double>();
    //     Dictionary<string, int> totalScore = new Dictionary<string, int>();
    //     Dictionary<string, int> count = new Dictionary<string, int>();

    //     foreach (var item in Program.sortedDict)
    //     {
    //         Student record = item.Value;

    //         if(!totalScore.ContainsKey(record.Subject))
    //         {
    //             totalScore[record.Subject] = 0;
    //             count[record.Subject] = 0;
    //         }
    //         totalScore[record.Subject] += record.Score;
    //         count[record.Subject]++;
    //     }

    //     foreach(var subject in totalScore.Keys)
    //     {
    //         averageResult[subject] = (double)totalScore[subject] / count[subject]; 
    //     }
    //     return averageResult;
    // }

    public Dictionary<string, double> AverageScorePerSubject()
    {
        Dictionary<string, double> result = new Dictionary<string, double>();
        double averageSubjectWise = 0;

        Utility utility = new Utility();
        var dict = utility.GroupByStudent();

        foreach(var kv in dict)
        {
            foreach(var l in kv.Value)
            {
                averageSubjectWise += l.Score;
            }
            averageSubjectWise /= kv.Value.Count;
            result[kv.Key] = averageSubjectWise;
        }

        return result;
    }

    // TopScorer
    public Student? TopScorer()
    {
        Student? top = null;

        foreach (var item in Program.sortedDict)
        {
            if (top == null || item.Value.Score > top.Score)
            {
                top = item.Value;
            }
        }

        return top;
    }

    // Filter by minimum score
    public List<Student> FilterScoreByMinimumScore(int minScore)
    {
        List<Student> result = new List<Student>();

        foreach(var item in Program.sortedDict)
        {
            if(item.Value.Score >= minScore)
            {
                result.Add(item.Value);
            }
        }

        return result;
    }
}

// main class
public class Program
{
    public static SortedDictionary<int, Student> sortedDict = new SortedDictionary<int, Student>();
    static void Main()
    {
        Utility utility = new Utility();

        while (true)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Group Student by subject");
            Console.WriteLine("3. Average score per subject");
            Console.WriteLine("4. Top Scorer");
            Console.WriteLine("5. Filter score by minimum score");
            Console.WriteLine("6. exit");

            Console.WriteLine("Enter choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter subject");
                    string subject = Console.ReadLine();

                    Console.WriteLine("Enter score");
                    int score = int.Parse(Console.ReadLine());

                    utility.AddStudent(name, subject, score);
                    break;

                case 2:
                    var grouped = utility.GroupStudentBySubject();

                    foreach(var kv in grouped)
                    {
                        Console.WriteLine(kv.Key);

                        foreach(var record in  kv.Value)
                        {
                            Console.WriteLine($"Name : {record.Name} | Score : {record.Score}");
                        }
                    }
                    break;
                
                case 3:
                    var averages = utility.AverageScorePerSubject();

                    foreach(var average in averages)
                    {
                        Console.WriteLine($"Subject : {average.Key} | Average Score : {average.Value}");
                    }
                    break;
                
                case 4:
                    var topScorer = utility.TopScorer();
                    if(topScorer != null)
                        Console.WriteLine($"Topper Name : {topScorer.Name} | Topper Score : {topScorer.Score}");
                    break;

                case 5:
                    Console.WriteLine("Enter minimum score");
                    int minScore = int.Parse(Console.ReadLine());

                    var filtered = utility.FilterScoreByMinimumScore(minScore);

                    foreach(var s in filtered)
                    {
                        Console.WriteLine($"Name : {s.Name} | Score : {s.Score}");
                    }
                    break;

                case 6:
                    Console.WriteLine("Thank You");
                    return;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }            
        }
    }
}





/*=============🧩 Scenario: Student Exam Performance Analyzer==============
John has taken up a freelance project for a coaching institute. The institute wants an application to manage student exam records. Each record includes the student's name, subject, and score. The application should allow adding records, grouping students by subject, and analyzing performance using LINQ.
Help John build this application using your C# skills.
🛠️ Functionalities
 In class Program:
C#
public static SortedDictionary<int, StudentRecord> studentRecords;

 
Show more lines
 
This sorted dictionary is already provided. It stores student exam records with an auto-incremented key.
 In class StudentRecord, implement the following properties:
Data Type	Property Name
string	StudentName
string	Subject
int	Score
 In class RecordUtility, implement the following methods:
Method 1:
 
C#
public void AddStudentRecord(string studentName, string subject, int score)


Show more lines
 
Adds a new student record to the studentRecords dictionary.
The key is set to one more than the current number of items in the dictionary.
Method 2:
 
C#
public SortedDictionary<string, List<StudentRecord>> GroupRecordsBySubject()

 
Show more lines
 
Groups all student records by their subject.
Returns a dictionary where:
Key = Subject name
Value = List of student records under that subject
Method 3:
 
C#
public Dictionary<string, double> GetAverageScorePerSubject()

 
Show more lines
 
Uses LINQ to calculate the average score for each subject.
Method 4:
 
C#
public StudentRecord GetTopScorer()

 
Show more lines
 
Uses LINQ to find the student with the highest score across all subjects.
Method 5:
 
C#
public List<StudentRecord> FilterStudentsByScore(int minScore)

 
Show more lines
 
Returns a list of students whose score is greater than or equal to minScore.
🧪 Sample Input/Output
1. Add Student Record
2. Group Records By Subject
3. Show Average Score Per Subject
4. Show Top Scorer
5. Filter Students By Minimum Score
6. Exit
Enter your choice
1
Enter student name
Alice
Enter subject
Math
Enter score
85
Student record added successfully
Enter your choice
1
Enter student name
Bob
Enter subject
Science
Enter score
90
Student record added successfully
Enter your choice
1
Enter student name
Charlie
Enter subject
Math
Enter score
78
Student record added successfully
Enter your choice
2
Math
Alice - 85
Charlie - 78
Science
Bob - 90
Enter your choice
3
Average Scores:
Math - 81.5
Science - 90.0
Enter your choice
4
Top Scorer:
Bob - 90
Enter your choice
5
Enter minimum score
80
Students with score >= 80:
Alice - 85
Bob - 90
Enter your choice
6

*/