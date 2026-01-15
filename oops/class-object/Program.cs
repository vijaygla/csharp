using System;

class Student {
    public int Id;
    public string Name;

    public void Display() {
        Console.WriteLine("Student id: " + Id);
        Console.WriteLine("Student name: " + Name);
    }
}

class Program {
    static void Main(string[] args) {
        Student s = new Student();

        s.Id = 101;
        s.Name = "Vijay Kumar";
        s.Display();
    }
}
