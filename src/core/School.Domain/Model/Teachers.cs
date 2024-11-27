namespace School.Domain.Model;

public class Teachers
{
    public Guid Id { get; set; }
    public Users User { get; set; }
    public DateTime HireDate { get; set; }
    public string SubjectSpecialization { get; set; }
}
