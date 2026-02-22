using System.Net.Http.Json;
using EmployeeCrud.App.Models;

namespace EmployeeCrud.App.Services;

public class EmployeeService
{
    private readonly HttpClient _client;

    public EmployeeService()
    {
        _client = new HttpClient();
        _client.BaseAddress = new Uri("https://localhost:5001/api/");
    }

    public async Task GetAll()
    {
        var employees = await _client.GetFromJsonAsync<List<Employee>>("employees");

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.EmployeeId} - {emp.EmployeeName} - {emp.Salary}");
        }
    }

    public async Task Add(Employee employee)
    {
        await _client.PostAsJsonAsync("employees", employee);
    }

    public async Task Delete(int id)
    {
        await _client.DeleteAsync($"employees/{id}");
    }
}
