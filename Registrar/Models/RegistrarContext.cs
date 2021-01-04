using Microsoft.EntityFrameworkCore;

namespace Registrar.Models
{
  public class RegistrarContext : DbContext
  {
      //public virtual DbSet<Course> Courses { get; set; }
      public virtual DbSet<Student> Students { get; set; }
      //public DbSet<StudentCourse> StudentCourse { get; set; }
      public RegistrarContext(DbContextOptions options) : base(options){ }
  }
}