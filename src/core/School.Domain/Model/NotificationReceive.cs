using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class NotificationReceive
{
    [Key]
    public Guid Id { get; set; }
    public Users Users { get; set; }
}