namespace BikeRentalSystem;

public class Bike
{
    public string Brand {get; set; }
    public string Model {get; set; }
    public int PricePerDay {get; set;}

    public Bike(string brand, string model, int pricePerDay)
    {
        Brand = brand;
        Model = model;
        PricePerDay = pricePerDay;
    }
}
