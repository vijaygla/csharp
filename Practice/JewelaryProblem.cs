using System;

class Jewelary
{
    public string Id {get; set; }
    public string Type { get; set; }
    public int Price { get; set; }
}


class Utility
{
    public void GetDetail()
    {
        Console.WriteLine($"Jewelary Details : {Program.jewelary.Id} {Program.jewelary.Type} {Program.jewelary.Price}");
    }

    public void UpdatePrice(int newPrice)
    {
        Program.jewelary.Price = newPrice;
        Console.WriteLine($"Updated Details : {Program.jewelary.Id} {Program.jewelary.Type} {Program.jewelary.Price}");
    }
}


class Program
{
    public static Jewelary jewelary = new Jewelary();
    static void Main()
    {
        Utility utility = new Utility();
        string[] arr = Console.ReadLine().Split(" ");

        jewelary.Id = arr[0];
        jewelary.Type = arr[1];
        jewelary.Price = Convert.ToInt32(arr[2]);

        while (true)
        {
            string[] nums = Console.ReadLine().Split(" ");
            switch(nums[0])
            {
                case "1":
                    utility.GetDetail();
                    break;

                case "2":
                    int newPrice = int.Parse(nums[1]);
                    utility.UpdatePrice(newPrice);
                    break;
                
                case "3":
                    Console.WriteLine("Thank You");
                    return;
            }
        }
    }
}
