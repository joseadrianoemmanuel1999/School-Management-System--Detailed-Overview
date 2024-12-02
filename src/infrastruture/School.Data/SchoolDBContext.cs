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
    public DbSet<Notifications> Notifications { get; set; }
   // public DbSet<NotificationSender> NotificationSenders { get; set; }
 //   public DbSet<NotificationReceive> NotificationReceives { get; set; }
    public DbSet<FeeStrutures> FeeStrutures { get; set; }
    public DbSet<FeePayments> FeePayments { get; set; }
    public DbSet<Exams> Exams { get; set; }
    public DbSet<ExamResults>ExamResults { get; set; }
    public DbSet<Classes>Classes { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<BookLoans>BookLoans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Users>().HasMany(x => x.SenderId)
            .WithOne(x => x.SenderIdUsers).HasForeignKey(x => x.SenderId)
            .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Users>().HasMany(x => x.ReceiverId)
            .WithOne(x => x.ReceiverIdUsers).HasForeignKey(x => x.ReceiverId)
            .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Teachers>().HasMany(x=>x.ClassesCollection
        ).WithOne(x=>x.Teachers).HasForeignKey(x=>x.TeacherId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Teachers>().HasMany(x=>x.TeacherAttendance).WithOne(x=>x.Teachers)
            .HasForeignKey(x=>x.TeacherId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Classes>().HasMany(x=>x.Subjects).WithOne(x=>x.Classes)
            .HasForeignKey(x=>x.ClassesId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Classes>().HasMany(x=>x.FeeStruturesCollection).WithOne(x=>x.Classes)
            .HasForeignKey(x=>x.ClassesId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Classes>().HasMany(x=>x.ExamsCollection).WithOne(x=>x.Classes)
            .HasForeignKey(x=>x.ClassesId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Classes>().HasMany(x=>x.StudentsCollection).WithOne(x=>x.Classes)
            .HasForeignKey(x=>x.ClassesId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Students>().HasMany(x=>x.StudentsCollection).WithOne(x=>x.Student)
            .HasForeignKey(x=>x.StudentId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Students>().HasMany(x=>x.ExamResultsCollection).WithOne(x=>x.Student)
            .HasForeignKey(x=>x.StudentId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Students>().HasMany(x=>x.FeePaymentsCollection).WithOne(x=>x.Student)
            .HasForeignKey(x=>x.StudentId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Students>().HasMany(x=>x.StudentAttendanceCollection).WithOne(x=>x.Student)
            .HasForeignKey(x=>x.StudentId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<FeeStrutures>().HasMany(x=>x.FeePaymentsCollection).WithOne(x=>x.FeeStruture)
            .HasForeignKey(x=>x.FeeStrutureId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Users>().HasOne(x=>x.UserProfiles).WithOne(x=>x.User)
            .HasForeignKey<UserProfiles>().OnDelete(DeleteBehavior.NoAction);
        
    }
}
