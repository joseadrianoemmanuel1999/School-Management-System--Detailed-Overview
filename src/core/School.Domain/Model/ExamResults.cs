namespace School.Domain.Model;

public class ExamResults
{
    public Guid Id { get; set; }
    public Exams Exam { get; set; }
    public Students Student { get; set; }
    public Subjects  Subjects  { get; set; }
    public float MarkObtained { get; set; }
    public float MaxMarks { get; set; }
}