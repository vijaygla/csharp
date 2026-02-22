using System.ComponentModel.DataAnnotations;

namespace UserRegistrationSystem.Models;

public class UpdateUserModel
{
    [Required]
    public string FullName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
