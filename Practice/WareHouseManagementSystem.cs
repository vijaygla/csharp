// smart ware house management system

public abstract class Entity
{
    protected int Id;

    public Entity(int id)
    {
        Id = id;
    }

    public int GetId()
    {
        return Id;
    }
}

public class OutOfStockException : Exception
{
    public OutOfStockException(string message) : base(message)
    {

    }
}

public class Product : Entity
{
    private string Name { get; set; }
    private double Price { get; set; }
    private int StockCount { get; set; }

    public Product(int id, string name, double price, int stockCount) : base(id)
    {
        Name = name;
        Price = price;
        StockCount = stockCount;
    }

    // getter setter for encapsulated private field
    public string GetName()
    {
        return Name;
    }

    public double GetPrice()
    {
        return Price;
    }
    public int GetStockCount()
    {
        return StockCount;
    }

    // sell method
    public void SellProduct(int quantity)
    {
        if (quantity > StockCount)
        {
            throw new OutOfStockException($"Not Enough product for {Name}");
        }
        else
        {
            StockCount -= quantity;
        }
    }
}


public class Utility
{
    public List<Product> list = new List<Product>();

    public void AddProduct(Product product)
    {
        list.Add(product);
        Console.WriteLine("Product added successfully");
    }

    public double NetWorth()
    {
        double result = 0;
        foreach (var item in list)
        {
            result += item.GetPrice() * item.GetStockCount();
        }
        return result;
    }

    public Product FindCheapestProduct()
    {
        if (list.Count == 0)
        {
            return null;
        }
        Product cheapest = list[0];

        foreach (var item in list)
        {
            if (item.GetPrice() < cheapest.GetPrice())
            {
                cheapest = item;
            }
        }
        return cheapest;
    }
}

class Program
{
    static void Main()
    {
        Utility utility = new Utility();

        Product laptop = new Product(101, "Laptop", 45000, 2);
        Product mouse = new Product(101, "mouse", 1000, 2);
        Product keyboard = new Product(101, "keyboard", 1500, 2);
        Product charger = new Product(101, "charger", 2500, 2);

        utility.AddProduct(laptop);
        utility.AddProduct(mouse);
        utility.AddProduct(keyboard);
        utility.AddProduct(charger);

        try
        {
            keyboard.SellProduct(1);
        }
        catch (OutOfStockException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"NetWorth of ware house product : {utility.NetWorth()}");
        Console.WriteLine($"Cheapest Product : {utility.FindCheapestProduct().GetName()} || Price : {utility.FindCheapestProduct().GetPrice()}");
    }
}




/*
🏆 The Scenario: "Smart Warehouse Management System"
A warehouse needs to track its inventory. You must build a system that manages Product objects, handles stock errors, and stores data efficiently.

1. The Requirements (OOP)
Create an Abstract Class Entity with a protected id (int).

Create a Class Product that inherits from Entity:

Attributes: name (String), price (double), and stockCount (int).

Encapsulation: Use private attributes with Getter/Setter methods.

Constructor: Initialize all fields via a constructor.

2. Custom Exception Handling
Create a custom exception class OutOfStockException.

In your Product class, create a method sellProduct(int quantity).

Logic: If quantity > stockCount, throw the OutOfStockException with the message: "Not enough stock for [productName]".

Otherwise, subtract the quantity from stockCount.

3. Collection Management
Create a Class WarehouseManager.

Use an ArrayList<Product> to store the inventory.

Methods to implement:

addProduct(Product p): Adds a product to the list.

findCheapestProduct(): Returns the Product with the lowest price using a loop.

getTotalInventoryValue(): Returns the sum of (price * stockCount) for all products.

🧪 Practice Task: The Coding Logic
Write a Main class to test the following flow:

Add 3 products: Laptop ($1200, 5 units), Mouse ($25, 10 units), and Keyboard ($50, 2 units).

Try to sell 3 Keyboards.

Catch the OutOfStockException and print the error message.

Print the total value of the remaining inventory.
*/
