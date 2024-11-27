namespace School.Domain.Model;

public class Students
{
    public Guid Id { get; set; }
    public Users? User { get; set; }
    public string? AdmissionNumber { get; set; }
    public DateTime EnrollmentDate { get; set; }
    //
}