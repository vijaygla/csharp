using System;

class Student {
    // Private data members (encapsulated)
    private int marks;
    public string name = "vijay kumar";

    // Public method to set data
    public void SetData(int studentMarks) {
        marks = studentMarks;
    }

    // Public method to get data
    public void DisplayMarks() {
        Console.WriteLine("Student marks: " + marks);
    }
}

class StudentData {
    static void Main(String[] args) {
        Student s = new Student();
        Console.WriteLine("Student name: " + s.name);

        // Accessing data via public methods only
        s.SetData(52);
        s.DisplayMarks();
    }
}
