using Microsoft.EntityFrameworkCore;
using EmployeeCrud.Api.Models;

namespace EmployeeCrud.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Employee> Employees { get; set; }
}
