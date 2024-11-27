namespace School.Domain.Model;

public class Classes
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public Teachers Teachers { get; set; }
}