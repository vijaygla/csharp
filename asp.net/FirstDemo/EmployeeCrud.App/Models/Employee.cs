namespace EmployeeCrud.App.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public required string EmployeeName { get; set; }
    public int Age { get; set; }
    public required string Email { get; set; }
    public decimal Salary { get; set; }
}
