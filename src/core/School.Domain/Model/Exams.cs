﻿namespace School.Domain.Model;

public class Exams
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Classes Classes { get; set; }
    public DateTime ExamDate { get; set; }
}