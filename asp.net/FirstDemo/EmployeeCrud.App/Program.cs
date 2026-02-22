using EmployeeCrud.App.Models;
using EmployeeCrud.App.Services;

var service = new EmployeeService();

while (true)
{
    Console.WriteLine("1. Get All");
    Console.WriteLine("2. Add");
    Console.WriteLine("3. Delete");
    Console.WriteLine("4. Exit");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            await service.GetAll();
            break;

        case "2":
            var emp = new Employee();

            Console.Write("Name: ");
            emp.EmployeeName = Console.ReadLine();

            Console.Write("Age: ");
            emp.Age = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            emp.Email = Console.ReadLine();

            Console.Write("Salary: ");
            emp.Salary = decimal.Parse(Console.ReadLine());

            await service.Add(emp);
            break;

        case "3":
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            await service.Delete(id);
            break;

        case "4":
            return;
    }
}
