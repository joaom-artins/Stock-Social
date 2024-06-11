using System.ComponentModel.DataAnnotations;

namespace API.Entities.Models;

public class UserModel
{
    [Key]
    public Guid Id { get; set; }
    [MaxLength(60)]
    public string Name { get; set; } = default!;
    [MaxLength(60)]

    public string Email { get; set; } = default!;
    public string? PhoneNumber { get; set; }
    public string Password { get; set; } = default!;
    public DateOnly BithDate { get; set; }
}
