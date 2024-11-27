using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class UserProfiles
{
    public Guid Id { get; set; }
    public Users? User { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public string? Address { get; set; }
    [Required]
    public string? ProfilePicture { get; set; }
}