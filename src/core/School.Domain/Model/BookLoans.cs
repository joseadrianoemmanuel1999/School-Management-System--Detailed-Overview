namespace School.Domain.Model;

public class BookLoans
{
    public Guid id { get; set; }
    public Students Students { get; set; }
    public Books Books { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public Double Fine { get; set; }
}