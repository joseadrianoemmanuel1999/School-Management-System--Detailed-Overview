namespace School.Domain.Model;

public class Subjects
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Classes Classes { get; set; }
}