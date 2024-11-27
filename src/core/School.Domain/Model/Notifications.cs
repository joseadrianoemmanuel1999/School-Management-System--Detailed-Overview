namespace School.Domain.Model;

public class Notifications
{
    public Guid Id { get; set; }
    public Users SenderId { get; set; }
    public Users ReceiverId { get; set; }
    public String Message { get; set; }
    public DateTime SentAt { get; set; }
}