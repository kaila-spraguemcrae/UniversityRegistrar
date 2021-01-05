using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

        [DisplayName("Add Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<StudentCourse> Courses { get; set; }
    }
}