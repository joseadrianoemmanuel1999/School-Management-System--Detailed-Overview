﻿using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class Classes
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public Guid TeacherId { get; set; }
    public Teachers Teachers { get; set; }
    public ICollection<Students>StudentsCollection { get; set; }
    public ICollection<Subjects> Subjects { get; set; }
    public ICollection<Exams>ExamsCollection { get; set; }
    public ICollection<FeeStrutures> FeeStruturesCollection { get; set; }
}