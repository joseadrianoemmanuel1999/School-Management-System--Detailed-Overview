using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Model;

public class Notifications
{
    [Key]
    public Guid Id { get; set; }
    public Guid SenderId { get; set; }
    public  Users SenderIdUsers { get; set; }
    public Guid ReceiverId { get; set; }
    public  Users ReceiverIdUsers { get; set; }
    public String Message { get; set; }
    public DateTime SentAt { get; set; }
}