using Microsoft.Extensions.Configuration;
using SqlConnection.Data;

class Program
{
    static void Main()
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrEmpty(connectionString))
        {
            Console.WriteLine("Connection string 'DefaultConnection' not found in appsettings.json");
            return;
        }

        DatabaseHelper db = new DatabaseHelper(connectionString);

        db.AddEmployee("Vijay", 45000);
        db.AddEmployee("Ravi", 38000);

        db.GetEmployees();

        Console.ReadLine();
    }
}
