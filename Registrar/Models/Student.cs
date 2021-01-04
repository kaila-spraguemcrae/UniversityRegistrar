using System;
using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<StudentCourse>();
    }
    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public virtual ICollection<StudentCourse> Courses { get; set; }
  }
}