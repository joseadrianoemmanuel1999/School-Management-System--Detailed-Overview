﻿using System.ComponentModel.DataAnnotations;
using School.Domain.Enums;

namespace School.Domain.Model;

public class FeePayments
{
    [Key]
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Students Student { get; set; }
    public Guid FeeStrutureId { get; set; }
    public FeeStrutures FeeStruture { get; set; }
    public DateTime PaymentDate { get; set; }
    public Double AmountPaid { get; set; }
    public PaymentStatus  PaymentStatus { get; set; }
}