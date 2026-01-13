using System;

class Student
{
    public int Id;
    public string Name;

    // Normal constructor
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    // Copy constructor
    public Student(Student s)
    {
        Id = s.Id;
        Name = s.Name;
    }
}

class CopyConstructor
{
    static void Main()
    {
        Student s1 = new Student(101, "Vijay");
        Student s2 = new Student(s1);   // Copy constructor

        Console.WriteLine(s2.Id);    
        Console.WriteLine(s2.Name);  
    }
}
