namespace School.Domain.Model;

public class StudentAttendance
{
    public Guid Id { get; set; }
    public Students Student { get; set; }
    public DateTime Date { get; set; }
    public StudentAttendance Status { get; set; }
    public string Remarks { get; set; }
}