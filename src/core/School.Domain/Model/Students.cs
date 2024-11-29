using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class Students
{
    [Key]
    public Guid Id { get; set; }
    public Users? User { get; set; }
    public string? AdmissionNumber { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public Classes Classes { get; set; }
    public ICollection<FeePayments> FeePaymentsCollection { get; set; }
    public ICollection<Students>StudentsCollection { get; set; }
    public ICollection<ExamResults> ExamResultsCollection { get; set; }
}