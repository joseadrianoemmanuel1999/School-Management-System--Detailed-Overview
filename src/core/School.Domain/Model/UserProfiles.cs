namespace School.Domain.Model;

public class UserProfiles
{
    public Guid Id { get; set; }
    public Users? User { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Address { get; set; }
    public string? ProfilePicture { get; set; }
}