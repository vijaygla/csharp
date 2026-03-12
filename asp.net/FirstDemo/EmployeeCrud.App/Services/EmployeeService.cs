using System.Net.Http.Json;
using EmployeeCrud.App.Models;

namespace EmployeeCrud.App.Services;

public class EmployeeService
{
    private static readonly HttpClient _client = new HttpClient
    {
        BaseAddress = new Uri("http://localhost:5195/api/")
    };

    public async Task GetAll()
    {
        try
        {
            var employees = await _client.GetFromJsonAsync<List<Employee>>("employees") ?? [];
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            Console.WriteLine("\nID | Name | Age | Email | Salary");
            Console.WriteLine("----------------------------------");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.EmployeeId} | {emp.EmployeeName} | {emp.Age} | {emp.Email} | {emp.Salary:C}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving employees: {ex.Message}");
        }
    }

    public async Task<Employee?> GetById(int id)
    {
        try
        {
            var response = await _client.GetAsync($"employees/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Employee>();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Console.WriteLine($"Employee with ID {id} not found.");
            }
            else
            {
                Console.WriteLine($"Failed to retrieve employee: {response.ReasonPhrase}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving employee: {ex.Message}");
        }
        return null;
    }

    public async Task Add(Employee employee)
    {
        try
        {
            var response = await _client.PostAsJsonAsync("employees", employee);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Employee added successfully!");
            }
            else
            {
                Console.WriteLine($"Failed to add employee: {response.ReasonPhrase}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding employee: {ex.Message}");
        }
    }

    public async Task Update(int id, Employee employee)
    {
        try
        {
            var response = await _client.PutAsJsonAsync($"employees/{id}", employee);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Employee updated successfully!");
            }
            else
            {
                Console.WriteLine($"Failed to update employee: {response.ReasonPhrase}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating employee: {ex.Message}");
        }
    }

    public async Task Delete(int id)
    {
        try
        {
            var response = await _client.DeleteAsync($"employees/{id}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Employee deleted successfully!");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Console.WriteLine($"Employee with ID {id} not found.");
            }
            else
            {
                Console.WriteLine($"Failed to delete employee: {response.ReasonPhrase}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting employee: {ex.Message}");
        }
    }
}
