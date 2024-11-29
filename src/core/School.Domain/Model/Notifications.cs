using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Model;

public class Notifications
{
    [Key]
    public Guid Id { get; set; }
    public virtual Users SenderId { get; set; }
    public virtual Users ReceiverId { get; set; }
    public String Message { get; set; }
    public DateTime SentAt { get; set; }
}