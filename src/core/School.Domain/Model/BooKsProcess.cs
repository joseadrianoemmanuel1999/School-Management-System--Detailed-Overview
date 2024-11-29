using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class BooKsProcess
{
    [Key]
    public Guid Id { get; set; }
    public Guid BooksId { get; set; }
    public Books Books { get; set; }
    public Guid BookLoansId { get; set; }
    public BookLoans BookLoans { get; set; }
}