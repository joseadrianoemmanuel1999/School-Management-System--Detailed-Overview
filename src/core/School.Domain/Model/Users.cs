using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using School.Domain.Enums;

namespace School.Domain.Model;

public class Users
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string CardId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string MiddleName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    public Role Role { get; set; }
    public int PhoneNumber { get; set; }
    public string PasswordHash { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
   [InverseProperty("SenderId")]
    public ICollection<Notifications> SenderId { get; set; }
    [InverseProperty("ReceiverId")]
    public ICollection<Notifications>ReceiverId { get; set; }
    public UserProfiles UserProfiles { get; set; }
}