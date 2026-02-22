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

public class Utility
{
    // Add Student
    public void AddStudent(string name, string subject, int score)
    {
        int key = Program.SortedDict.Count + 1;
        Student student = new Student(name, subject, score);
        Program.SortedDict.Add(key, student);
        Console.WriteLine("Student added successfully");
    }

    // Group by Subject
    public Dictionary<string, List<Student>> GroupStudentBySubject()
    {
        Dictionary<string, List<Student>> result = new Dictionary<string, List<Student>>();

        foreach (var kv in Program.SortedDict)
        {
            var student = kv.Value;

            if (!result.ContainsKey(student.Subject))
            {
                result[student.Subject] = new List<Student>();
            }

            result[student.Subject].Add(student);
        }

        return result;
    }

    // Average Score per Subject
    public Dictionary<string, double> AverageScorePerSubject()
    {
        Dictionary<string, double> result = new Dictionary<string, double>();

        var dict = GroupStudentBySubject();

        foreach (var kv in dict)
        {
            double totalScore = 0;  // Reset inside loop

            foreach (var v in kv.Value)
            {
                totalScore += v.Score;
            }

            result[kv.Key] = totalScore / kv.Value.Count;
        }

        return result;
    }

    // Top Scorer
    public Student? TopScorer()
    {
        Student? topperStudent = null;

        foreach (var kv in Program.SortedDict)
        {
            if (topperStudent == null || kv.Value.Score > topperStudent.Score)
            {
                topperStudent = kv.Value;
            }
        }

        return topperStudent;
    }

    // Filter Student by Min Score
    public List<Student> FilterStudentByMinScore(int minScore)
    {
        List<Student> result = new List<Student>();

        foreach (var kv in Program.SortedDict)
        {
            if (kv.Value.Score >= minScore)
            {
                result.Add(kv.Value);
            }
        }

        return result;
    }
}

public class Program
{
    public static SortedDictionary<int, Student> SortedDict = new SortedDictionary<int, Student>();

    static void Main()
    {
        Utility utility = new Utility();

        while (true)
        {
            Console.WriteLine("=== Student Exam System ===");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. GroupStudentBySubject");
            Console.WriteLine("3. AverageScorePerSubject");
            Console.WriteLine("4. TopScorer");
            Console.WriteLine("5. Filter Score by Minimum Score");
            Console.WriteLine("6. Exit");

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
                    var groupStudentBySubject = utility.GroupStudentBySubject();

                    foreach (var kv in groupStudentBySubject)
                    {
                        Console.WriteLine($"Subject : {kv.Key}");

                        foreach (var v in kv.Value)
                        {
                            Console.WriteLine($"Name : {v.Name} | Score : {v.Score}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    var dict = utility.AverageScorePerSubject();

                    foreach (var kv in dict)
                    {
                        Console.WriteLine($"Subject : {kv.Key} | Average Score : {kv.Value}");
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    var topperStudent = utility.TopScorer();

                    if (topperStudent != null)
                    {
                        Console.WriteLine($"Topper Name : {topperStudent.Name} | Topper Score : {topperStudent.Score}");
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    Console.WriteLine("Enter minScore");
                    int minScore = int.Parse(Console.ReadLine());

                    var list = utility.FilterStudentByMinScore(minScore);

                    foreach (var v in list)
                    {
                        Console.WriteLine($"Name : {v.Name} | Subject : {v.Subject} | Score : {v.Score}");
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