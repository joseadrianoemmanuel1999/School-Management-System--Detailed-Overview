namespace School.Domain.Model;

public class FeeStrutures
{
    public Guid Id { get; set; }
    public Classes Classes { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; }
}