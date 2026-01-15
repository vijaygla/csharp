using System;

class Animal {
    public void eat() {
        Console.WriteLine("Every animals eat");
    }
}

// inherit animals class using :
class Dog : Animal {
    public void bark() {
        Console.WriteLine("Dog bark");
    }
}

class AnimalAndDog {
    static void Main(String[] args) {
        Dog d = new Dog();
        d.eat(); // inherited method
        d.bark(); // own method
    }
}
