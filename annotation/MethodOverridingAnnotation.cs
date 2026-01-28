using System;

// Custom Annotation (Attribute)
[AttributeUsage(AttributeTargets.Method)]
class SoundInfoAttribute : Attribute
{
    public string Description { get; }

    public SoundInfoAttribute(string description)
    {
        Description = description;
    }
}

class Animal
{
    [SoundInfo("Generic animal sound")]
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    [SoundInfo("Dog barking sound")]
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        dog.MakeSound();
    }
}
