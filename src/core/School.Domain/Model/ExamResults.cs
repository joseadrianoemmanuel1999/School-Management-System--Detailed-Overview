using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class ExamResults
{
    [Key]
    public Guid Id { get; set; }
    public Guid ExamId { get; set; }
    public Exams Exam { get; set; }
    public Guid StudentId { get; set; }
    public Students Student { get; set; }
    public Guid SubjectId { get; set; }
    public Subjects  Subjects  { get; set; }
    public float MarkObtained { get; set; }
    public float MaxMarks { get; set; }
}