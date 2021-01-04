using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public Course()
    {
      this.Students = new HashSet<StudentCourse>();
    }
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseNumber { get; set; }
    public virtual ICollection<StudentCourse> Students { get; set; }
  }
}