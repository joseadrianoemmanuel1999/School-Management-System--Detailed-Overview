namespace School.Domain.Model;

public class Classes
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public Teachers Teachers { get; set; }
    public ICollection<Students>StudentsCollection { get; set; }
    public ICollection<Subjects> Subjects { get; set; }
    public ICollection<Exams>ExamsCollection { get; set; }
}