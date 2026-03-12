using System;
using System.IO;
using System.Collections.Generic;

public class DuplicateStudentException : Exception
{
    public DuplicateStudentException(string message) : base(message)
    {

    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }

    public Student(int id, string name, int marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }
}

public class Utility
{
    public Dictionary<int, Student> Dict = new Dictionary<int, Student>();

    public void AddStudent(Student student)
    {
        if (Dict.ContainsKey(student.Id))
        {
            throw new DuplicateStudentException("Student Already exist with this id");
        }
        Dict.Add(student.Id, student);
        Console.WriteLine("Student added successfully");
    }

    public void UpdateMarks(int id, int newMarks)
    {
        if (!Dict.ContainsKey(id))
        {
            throw new Exception("Student not exist with this id");
        }
        Dict[id].Marks = newMarks;
        Console.WriteLine("Student marks updated succesfully");
    }

    public void DeleteStudent(int id)
    {
        if (!Dict.ContainsKey(id))
        {
            throw new Exception("Student not found with this id");
        }
        Dict.Remove(id);
        Console.WriteLine("Student delteted successfully");
    }

    public Student ShowTopper()
    {
        if (Dict.Count == 0)
        {
            throw new Exception("no Student found");
        }

        Student topper = null;

        foreach (var kv in Dict)
        {
            var v = kv.Value;
            if (topper == null || v.Marks > topper.Marks)
            {
                topper = v;
            }
        }
        return topper;
    }

    public double ShowAverage()
    {
        if (Dict.Count == 0)
        {
            throw new Exception("No student found");
        }
        double totalMarks = 0;
        foreach (var v in Dict.Values)
        {
            totalMarks += v.Marks;
        }
        return totalMarks / Dict.Count;
    }

    public void SaveToFile(string path)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            foreach (var student in Dict.Values)
            {
                sw.WriteLine($"{student.Id},{student.Name},{student.Marks}");
            }
        }
        Console.WriteLine("Data save to file at given path");
    }

    public void LoadFromFile(string path)
    {
        if (!File.Exists(path))
        {
            throw new Exception("File Not found");
        }
        Dict.Clear();
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] arr = line.Split(",");

                if (arr.Length != 3)
                {
                    throw new Exception("Invlid file Exception");
                }
                int id = int.Parse(arr[0]);
                string name = arr[1];
                int marks = int.Parse(arr[2]);

                Student student = new Student(id, name, marks);
                Dict.Add(id, student);
            }
        }
        Console.WriteLine("Data loaded successfully");
    }
}

class Program
{
    static void Main()
    {
        Utility utility = new Utility();
        while (true)
        {
            Console.WriteLine("1. AddStudent");
            Console.WriteLine("2. UpdateMarks");
            Console.WriteLine("3. DeleteStudent");
            Console.WriteLine("4. ShowTopper");
            Console.WriteLine("5. ShowAverage");
            Console.WriteLine("6. Save data to file");
            Console.WriteLine("7. Load from File");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter choice");

            int choice = int.Parse(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Student Id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Student Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Student Marks");
                        int marks = int.Parse(Console.ReadLine());
                        Student student = new Student(id, name, marks);
                        utility.AddStudent(student);
                        break;

                    case 2:
                        Console.WriteLine("Enter id");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("New Marks");
                        int newMarks = int.Parse(Console.ReadLine());
                        utility.UpdateMarks(id, newMarks);
                        break;

                    case 3:
                        Console.WriteLine("Enter id");
                        id = int.Parse(Console.ReadLine());
                        utility.DeleteStudent(id);
                        break;

                    case 4:
                        Student topper = utility.ShowTopper();
                        Console.WriteLine($"Topper: {topper.Name} | Marks: {topper.Marks}");
                        break;

                    case 5:
                        double avg = utility.ShowAverage();
                        Console.WriteLine($"Average Marks: {avg:F2}");
                        break;

                    case 6:
                        Console.Write("Enter file path: ");
                        string savePath = Console.ReadLine();
                        utility.SaveToFile(savePath);
                        break;

                    case 7:
                        Console.Write("Enter file path: ");
                        string loadPath = Console.ReadLine();
                        utility.LoadFromFile(loadPath);
                        break;

                    case 8:
                        Console.WriteLine("Thanks");
                        return;
                }
            }
            catch (DuplicateStudentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
