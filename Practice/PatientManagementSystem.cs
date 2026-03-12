using System;
using System.Collections.Generic;

public class OverCapacityException : Exception
{
    public OverCapacityException(string message) : base(message)
    {

    }
}
public class PatientNotFoundException : Exception
{
    public PatientNotFoundException(string message) : base(message)
    {

    }
}
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {

    }
}


public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Patient(int id, string name, int age)
    {
        if (age <= 0 || age > 100)
        {
            throw new InvalidAgeException("Age must be 1-100");
        }
        Id = id;
        Name = name;
        Age = age;
    }
}

public class Utility
{
    public List<Patient> list = new List<Patient>();
    const int MAX_PATIENT_CAPACITY = 5;

    public void AddAppointment(Patient patient)
    {
        if (list.Count >= MAX_PATIENT_CAPACITY)
        {
            throw new OverCapacityException("No more patient today");
        }
        list.Add(patient);
        Console.WriteLine("Patient added successfully");
    }

    public void SearchPatient(int id)
    {
        foreach (var item in list)
        {
            if (item.Id == id)
            {
                Console.WriteLine($"Patient Id : {item.Id} || PatientName : {item.Name} || PatientAge : {item.Age}");
                return;
            }
        }
        throw new PatientNotFoundException("Patient Not found");
    }

    public void DisplayAllAppointment()
    {
        foreach (var item in list)
        {
            Console.WriteLine($"Patient Id : {item.Id} || PatientName : {item.Name} || PatientAge : {item.Age}");
        }
    }
}

class Program
{
    static void Main()
    {
        Utility utility = new Utility();
        while (true)
        {
            Console.WriteLine("1. AddAppointment");
            Console.WriteLine("2. SearchPatient");
            Console.WriteLine("3. DisplayAllAppointment");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter choice");
            int choice = int.Parse(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter patient id");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter patient name");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter patient age");
                        int age = int.Parse(Console.ReadLine());

                        Patient patient = new Patient(id, name, age);

                        utility.AddAppointment(patient);
                        break;

                    case 2:
                        Console.WriteLine("Enter patient id");
                        id = int.Parse(Console.ReadLine());

                        utility.SearchPatient(id);
                        break;

                    case 3:
                        utility.DisplayAllAppointment();
                        break;

                    case 4:
                        Console.WriteLine("Thank you");
                        return;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            catch (OverCapacityException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PatientNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidAgeException e)
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
