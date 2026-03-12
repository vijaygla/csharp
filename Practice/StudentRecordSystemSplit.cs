using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Student
{
    public string Name { get; set; }
    public string Department { get; set; }
    public int Q1 { get; set; }
    public int Q2 { get; set; }
    public int Q3 { get; set; }

    public Student(string name, string departement, int q1, int q2, int q3)
    {
        Name = name;
        Department = departement;
        Q1 = q1;
        Q2 = q2;
        Q3 = q3;
    }

    public int TotalMarks()
    {
        return Q1 + Q2 + Q3;
    }
}

public class Utility
{
    public void AddStudentRecord(string name, string departement, int q1, int q2, int q3)
    {
        Student student = new Student(name, departement, q1, q2, q3);
        Program.list.Add(student);
        Console.WriteLine($"Record {student.Name} {student.Department}");
    }

    public Student TopByQuizz(int quizzNumber)
    {
        Student topperStudent = null;

        foreach(var item in Program.list)
        {
            int marks = 0;

            if(quizzNumber == 1)
            {
                marks += item.Q1;
            }
            else if(quizzNumber == 2)
            {
                marks += item.Q2;
            }
            else if(quizzNumber == 3)
            {
                marks += item.Q3;
            }

            if(topperStudent == null)
            {
                topperStudent = item;
            }
            else
            {
                int topMarks = 0;
                if(quizzNumber == 1)
                {
                    topMarks += topperStudent.Q1;
                }
                else if(quizzNumber == 2)
                {
                    topMarks += topperStudent.Q2;
                }
                else if(topMarks == 3)
                {
                    topMarks += topperStudent.Q3;
                }

                if(marks > topMarks)
                {
                    topperStudent = item;
                }
            }
        }
        return topperStudent;
    }

    public Student TopByDepartment(string departement)
    {
        Student topperStudent = null;

        foreach(var item in Program.list)
        {
            if(item.Department == departement)
            {
                if (topperStudent == null || item.TotalMarks() > topperStudent.TotalMarks())
                {
                    topperStudent = item;
                }
            }   
        }

        return topperStudent;
    }
}

class Program
{
    public static List<Student> list = new List<Student>();
    static void Main(String[] args)
    {
        Utility utility = new Utility();
        int n = int.Parse(Console.ReadLine());
        
        while(n-- > 0)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(" ");

            if(inputs[0] == "Record")
            {
                string name = inputs[1];
                string departement = inputs[2];
                int q1 = int.Parse(inputs[3]);
                int q2 = int.Parse(inputs[4]);
                int q3 = int.Parse(inputs[5]);

                utility.AddStudentRecord(name, departement, q1, q2, q3);
            }
            else if(inputs[0] == "Top")
            {
                Student topperStudent = null;
                if(inputs[1] == "q1")
                {
                    topperStudent = utility.TopByQuizz(1);
                }
                else if((inputs[1] == "q2")) {
                    topperStudent = utility.TopByQuizz(2);
                }
                else
                {
                    topperStudent = utility.TopByQuizz(3);
                }
                Console.WriteLine($"{topperStudent.Name}");
            }
            else
            {
                string department = inputs[1];
                Student topperStudent = utility.TopByDepartment(department);
                Console.WriteLine($"{topperStudent.Name} {department}");
            }
        }
    }
}
