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
  //  public DbSet<Notifications> Notifications { get; set; }
   //public DbSet<NotificationSender> NotificationSenders { get; set; }
  //public DbSet<NotificationReceive> NotificationReceives { get; set; }
    public DbSet<FeeStrutures> FeeStrutures { get; set; }
    public DbSet<FeePayments> FeePayments { get; set; }
    public DbSet<Exams> Exams { get; set; }
    public DbSet<ExamResults>ExamResults { get; set; }
    public DbSet<Classes>Classes { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<BookLoans>BookLoans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       /* modelBuilder.Entity<Users>().HasMany(x => x.SenderId).WithOne(x => x.SenderId).HasForeignKey(x => x.SenderId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Users>().HasMany(x => x.ReceiverId).WithOne(x => x.ReceiverId).HasForeignKey(x => x.SenderId)
            .OnDelete(DeleteBehavior.Cascade);*/
    }
}
