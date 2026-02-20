public class Bike
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int PricePerDay { get; set; }

    public Bike(string brand, string model, int pricePerDay)
    {
        Brand = brand;
        Model = model;
        PricePerDay = pricePerDay;
    }
}

public class Utility
{
    // add bike method
    public void AddBike(string brand, string model, int pricePerDay)
    {
        int key = Program.sortedDict.Count + 1;
        Bike bike = new Bike(brand, model, pricePerDay);
        Program.sortedDict.Add(key, bike);
        Console.WriteLine("Bike added successfully");
    }

    // group bike by brand
    public void GroupByBrand()
    {
        Dictionary<string, List<Bike>> brandGroup = new Dictionary<string, List<Bike>>();
        if(brandGroup.Count == 0)
        {
            Console.WriteLine("===> No Bike Exist");
        }

        foreach(var kv in Program.sortedDict)
        {
            string brand = kv.Value.Brand;

            if (!brandGroup.ContainsKey(brand))
            {
                List<Bike> list = new List<Bike>();
                brandGroup[brand] = list;
            }

            brandGroup[brand].Add(kv.Value);
        }

        foreach(var kv in brandGroup)
        {
            Console.WriteLine("Brand : " + kv.Key);

            foreach(var item in kv.Value)
            {
                Console.WriteLine($"Model : {item.Model} | PricePerDay : {item.PricePerDay}");
            }
            Console.WriteLine(); 
        }
    }
}

public class Program
{
    public static SortedDictionary<int, Bike> sortedDict = new SortedDictionary<int, Bike>();
    static void Main()
    {
        Utility utility = new Utility();
        while (true)
        {
            Console.WriteLine("1. Add Bike");
            Console.WriteLine("2. Group By Brand");
            Console.WriteLine("3. Exit");

            Console.WriteLine("Enter choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter brand");
                    string brand = Console.ReadLine();

                    Console.WriteLine("Enter model");
                    string model = Console.ReadLine();

                    Console.WriteLine("Enter pricePerDay");
                    int pricePerDay = Convert.ToInt32(Console.ReadLine());
                    
                    utility.AddBike(brand, model, pricePerDay);
                    break;
                
                case 2: 
                    utility.GroupByBrand();
                    break;
                
                case 3:
                    Console.WriteLine("Thank You");
                    return;
                
                default:
                    Console.WriteLine("INVALID INPUT");
                    break;
            }
        }
    }
}



/* Scenario: CityRide – Bike Rental Management System

CityRide Rentals provides bikes on rent to customers on a daily basis.
The manager wants a simple console-based application to:

Add new bike details (Brand, Model, Price Per Day).

Group bikes brand-wise to easily view available bikes of each brand.

Display grouped bikes in sorted brand order.

The system should:

Use SortedDictionary to maintain sorted data.

Avoid using LINQ.

Use proper OOP principles.

Be menu-driven.
*/
