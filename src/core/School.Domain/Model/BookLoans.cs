﻿using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class BookLoans
{
    [Key]
    public Guid Id { get; set; }
    public Students Students { get; set; }
    public List<Books> Books { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public Double Fine { get; set; }
}