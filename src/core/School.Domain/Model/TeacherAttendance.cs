namespace School.Domain.Model;

public class TeacherAttendance
{
    public Guid Id { get; set; }
    public Teachers Teachers { get; set; }
    public DateTime AttendanceDate { get; set; }
    public StudentAttendance statusAttendance { get; set; }
    public  string Remarks { get; set; }
    
}