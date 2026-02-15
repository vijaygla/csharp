/*
🚲 Scenario: CityRide – Bike Rental Management System

Company Name: BikeRentalSystem
Location: Mumbai

CityRide Rentals provides bikes on rent to customers on a daily basis.
The manager wants a simple console-based application to:

Add new bike details (Model, Brand, Price Per Day).

Store bikes in a sorted manner based on Bike ID.

Group bikes brand-wise to easily view available bikes of each brand.

Display grouped bikes in sorted brand order.

The system should:

Use SortedDictionary to maintain sorted data.

Avoid using LINQ.

Use proper OOP principles.

Be menu-driven.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BikeRentalSystem;

public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();
    static void Main()
    {
        Utility utility = new Utility();
        while(true)
        {
            Console.WriteLine("------ CityRide Bike Rental ------");
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.Write("Enter Brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter Model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter Price Per Day: ");
                    int pricePerDay = Convert.ToInt32(Console.ReadLine());

                    utility.AddBike(brand, model, pricePerDay);
                    Console.WriteLine("Bike add successfully");
                    break;

                case 2:
                    utility.DisplayGroupByBrand();
                    break;
                
                case 3:
                    return;
                
                default: 
                    Console.WriteLine("Enter the valid input");
                    break;
            }
        }
    }
}
