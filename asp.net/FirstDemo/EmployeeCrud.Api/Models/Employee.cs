using System.ComponentModel.DataAnnotations;

namespace EmployeeCrud.Api.Models;

public class Employee
{
    public int EmployeeId { get; set; }

    [Required]
    public required string EmployeeName { get; set; }

    public int Age { get; set; }

    [Required]
    public required string Email { get; set; }

    public decimal Salary { get; set; }
}
