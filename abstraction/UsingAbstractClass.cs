using System;

abstract class Vehicle {
    public abstract void Start();

    public virtual void Fuel() {
        Console.WriteLine("Every vehicle need fuel");
    }
}

class Bike : Vehicle {
    public override void Start() {
        Console.WriteLine("Bike start by kick");
    }

    // we can override or may not both are fine if we override it will use the child class methiod
    // public override void Fuel() {
    //     Console.WriteLine("Bike need pertrol");
    // }
}

class UsingAbstractClass {
    static void Main(String[] args) {
        Vehicle v = new Bike();

        // use the non abstract method
        v.Fuel();
        // use the abstract method
        v.Start();
    }
}
