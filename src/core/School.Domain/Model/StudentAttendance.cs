using System.ComponentModel.DataAnnotations;
using School.Domain.Enums;

namespace School.Domain.Model;

public class StudentAttendance
{
    [Key]
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Students Student { get; set; }
    public DateTime Date { get; set; }
    public StudentAttendanceEnum Status { get; set; }
    public string Remarks { get; set; }
}