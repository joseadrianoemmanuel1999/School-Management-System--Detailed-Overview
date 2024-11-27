namespace School.Domain.Model;

public class Books
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int CopiesAvailable { get; set; }
    
}