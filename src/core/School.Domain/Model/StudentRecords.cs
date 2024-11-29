using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class StudentRecords
{
    [Key]
    public int Id { get; set; }
    public Students Student { get; set; }
    public DateTime AcademicYear { get; set; }
    public string Grade { get; set; }
    public string BehavioralNotes { get; set; }
}