using System; 

class Animal {
    // regular method
    public void Eat() {
        Console.WriteLine("Animal eats");
    }

    // virtual method
    public virtual void Sound() {
        Console.WriteLine("Animals make sound");
    }

    // virtual method
    public virtual bool IsDomestic() {
        return false;
    }
}

// Derived class
class Dog : Animal {
    // overriding method
    public override void Sound() {
        Console.WriteLine("Dog barks");
    }

    // overriding method
    public override bool IsDomestic() {
        return true;
    }
}

// Another derived class
class Tiger : Animal {
    public override void Sound() {
        Console.WriteLine("Tiger roars");
    }

    public override bool IsDomestic() {
        return false;
    }
}

// Main class
class RunTimePolymorphismMethodOverriding {
    static void Main(string[] args) {
        Animal dog = new Dog();
        Animal tiger = new Tiger();

        dog.Eat(); // Inherited method call
        dog.Sound(); // Overridden method runtime polymorphism
        Console.WriteLine("Is Dog domestic? " + dog.IsDomestic());
        Console.WriteLine("--------------------------");

        tiger.Eat(); // Inherited method call
        tiger.Sound(); // Overridden method runtime polymorphism
        Console.WriteLine("Is Tiger domestic? " + tiger.IsDomestic());
    }
}
