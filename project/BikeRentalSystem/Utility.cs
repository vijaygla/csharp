namespace BikeRentalSystem;

public class Utility
{
    private SortedDictionary<int, Bike> bikeDetail = new SortedDictionary<int, Bike>();

    // method to add the bike
    public void AddBike(string brand, string model, int pricePerDay)
    {
        int key = bikeDetail.Count + 1;
        Bike bike = new Bike(brand, model, pricePerDay);
        bikeDetail.Add(key, bike);
    }

    // method to group by brand
    public SortedDictionary<string, List<Bike>> GroupByBrand()
    {
        SortedDictionary<string, List<Bike>> ans = new SortedDictionary<string, List<Bike>>();

        foreach(KeyValuePair<int, Bike> entry in bikeDetail)
        {
            Bike bike = entry.Value;

            if(ans.ContainsKey(bike.Brand))
            {
                ans[bike.Brand].Add(bike);
            }
            else
            {
                List<Bike> list = new List<Bike>();
                list.Add(bike);
                ans.Add(bike.Brand, list);
            }
        }

        return ans;
    }

    // display group bike by brand
    public void DisplayGroupByBrand()
    {
        SortedDictionary<string, List<Bike>> dict = GroupByBrand();

        foreach(KeyValuePair<string, List<Bike>> group in dict)
        {
            Console.WriteLine("Brand : " + group.Key);

            foreach(Bike bike in group.Value)
            {
                Console.WriteLine("Model : " + bike.Model + "| price : " + bike.PricePerDay);
            }
            Console.WriteLine();
        }
    }
}
