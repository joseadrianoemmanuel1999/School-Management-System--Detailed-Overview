using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class FeeStrutures
{
    [Key]
    public Guid Id { get; set; }
    public Guid ClassesId { get; set; }
    public Classes Classes { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; }
    public ICollection<FeePayments>FeePaymentsCollection { get; set; }
}