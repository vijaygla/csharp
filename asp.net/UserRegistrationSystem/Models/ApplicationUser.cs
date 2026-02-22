using Microsoft.AspNetCore.Identity;

namespace UserRegistrationSystem.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
}
