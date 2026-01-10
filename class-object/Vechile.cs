using System;

class Car {
    public static string brand;
    public static int speed;

    public void Drive() {
        Console.WriteLine(brand + " is driving at speed of " + speed + " km/h");
    }
}

class Vechile {
    static void Main() {
        Car c = new Car(); // object creation using the default constructor
        Car.brand = "BMW";
        Car.speed = 120;

        c.Drive();
    }
}
