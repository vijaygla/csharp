using EmployeeCrud.App.Models;
using EmployeeCrud.App.Services;

var service = new EmployeeService();

while (true)
{
    Console.WriteLine("\n--- Employee Management ---");
    Console.WriteLine("1. Get All");
    Console.WriteLine("2. Get By Id");
    Console.WriteLine("3. Add");
    Console.WriteLine("4. Update");
    Console.WriteLine("5. Delete");
    Console.WriteLine("6. Exit");
    Console.Write("Choose option: ");

    var choice = Console.ReadLine();

    try
    {
        switch (choice)
        {
            case "1":
                await service.GetAll();
                break;

            case "2":
                int getById;
                Console.Write("Enter Employee Id: ");
                if (int.TryParse(Console.ReadLine(), out getById))
                {
                    var emp = await service.GetById(getById);
                    if (emp != null)
                    {
                        Console.WriteLine($"\nID: {emp.EmployeeId}\nName: {emp.EmployeeName}\nAge: {emp.Age}\nEmail: {emp.Email}\nSalary: {emp.Salary:C}");
                    }
                }
                break;

            case "3":
                await service.Add(PromptForEmployeeInfo());
                break;

            case "4":
                int updateId;
                Console.Write("Enter Employee Id to Update: ");
                if (int.TryParse(Console.ReadLine(), out updateId))
                {
                    var existing = await service.GetById(updateId);
                    if (existing != null)
                    {
                        var updatedEmp = PromptForEmployeeInfo();
                        updatedEmp.EmployeeId = updateId;
                        await service.Update(updateId, updatedEmp);
                    }
                }
                break;

            case "5":
                int deleteId;
                Console.Write("Enter Id to delete: ");
                if (int.TryParse(Console.ReadLine(), out deleteId))
                {
                    await service.Delete(deleteId);
                }
                break;

            case "6":
                return;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

static Employee PromptForEmployeeInfo()
{
    // Prompt for Name
    string name;
    do
    {
        Console.Write("Name: ");
        name = Console.ReadLine() ?? "";
    } while (string.IsNullOrWhiteSpace(name));

    // Prompt for Age
    int age;
    while (true)
    {
        Console.Write("Age: ");
        if (int.TryParse(Console.ReadLine(), out age) && age > 0) break;
        Console.WriteLine("Invalid age. Please enter a positive integer.");
    }

    // Prompt for Email
    string email;
    do
    {
        Console.Write("Email: ");
        email = Console.ReadLine() ?? "";
    } while (string.IsNullOrWhiteSpace(email));

    // Prompt for Salary
    decimal salary;
    while (true)
    {
        Console.Write("Salary: ");
        if (decimal.TryParse(Console.ReadLine(), out salary) && salary >= 0) break;
        Console.WriteLine("Invalid salary. Please enter a non-negative decimal.");
    }

    return new Employee
    {
        EmployeeName = name,
        Age = age,
        Email = email,
        Salary = salary
    };
}
