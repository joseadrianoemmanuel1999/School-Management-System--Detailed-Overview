namespace School.Domain.Model;

public class Notifications
{
    public Guid Id { get; set; }
    public NotificationSender SenderId { get; set; }
    public NotificationReceive ReceiverId { get; set; }
    public String Message { get; set; }
    public DateTime SentAt { get; set; }
}