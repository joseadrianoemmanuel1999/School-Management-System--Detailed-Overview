using School.Domain.Enums;

namespace School.Domain.Model;

public class FeePayments
{
    public Guid Id { get; set; }
    public Students Student { get; set; }
    public FeeStrutures FeeStruture { get; set; }
    public DateTime PaymentDate { get; set; }
    public Double AmountPaid { get; set; }
    public PaymentStatus  PaymentStatus { get; set; }
}