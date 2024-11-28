using Microsoft.EntityFrameworkCore;
using School.Domain.Model;

namespace School.Data;

public class SchoolDBContext : DbContext
{
    public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
    {

    }

    public DbSet<Users> Users { get; set; }
    public DbSet<UserProfiles> UserProfiles { get; set; }
    public DbSet<Teachers> Teachers { get; set; }
    public DbSet<TeacherAttendance> TeacherAttendances { get; set; }
    public DbSet<Subjects> Subjects { get; set; }
    public DbSet<Students> Students { get; set; }
    public DbSet<StudentRecords> StudentRecords { get; set; }
    

}