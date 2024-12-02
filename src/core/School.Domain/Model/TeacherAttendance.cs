using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model;

public class TeacherAttendance
{
    [Key]
    public Guid Id { get; set; }
    public Guid TeacherId { get; set; }
    public Teachers Teachers { get; set; }
    public DateTime AttendanceDate { get; set; }
    public StudentAttendance statusAttendance { get; set; }
    public  string Remarks { get; set; }
    
}