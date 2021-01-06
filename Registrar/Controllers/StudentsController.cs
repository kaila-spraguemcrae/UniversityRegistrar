using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
    public class StudentsController : Controller
    {
        private readonly RegistrarContext _db;
        public StudentsController(RegistrarContext db)
        {
          _db = db;
        }
        public ActionResult Index()
        {
          return View(_db.Students.ToList()); // refers to List on Index View page to pass x data to said view
        }

        public ActionResult Create()
        {
          ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
          return View();
        }

        [HttpPost]
        public ActionResult Create(Student student, int CourseId)
        {
          _db.Students.Add(student);
          if (CourseId != 0)
          {
            _db.StudentCourse.Add(new StudentCourse() { CourseId = CourseId, StudentId = student.StudentId });
          }
          _db.SaveChanges();
          return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
          var thisStudent = _db.Students
            .Include(student => student.Courses)
            .ThenInclude(join => join.Course)
            .FirstOrDefault(student => student.StudentId == id);
          return View(thisStudent);
        }

        public ActionResult AddCourse(int id)
        {
          var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
          ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
          return View(thisStudent);
        }

        [HttpPost]
        public ActionResult AddCourse(Student student, int CourseId)
        {
            if (CourseId != 0)
            {
              _db.StudentCourse.Add(new StudentCourse() { CourseId = CourseId, StudentId = student.StudentId });
            }
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = student.StudentId });
        }

        public ActionResult Edit(int id)
        {
          var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
          ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
          return View(thisStudent);
        }

        [HttpPost]
        public ActionResult Edit(Student student, int CourseId)
        {
          if (CourseId != 0)
          {
            _db.StudentCourse.Add(new StudentCourse() { CourseId = CourseId, StudentId = student.StudentId });
          }
          _db.Entry(student).State = EntityState.Modified;
          _db.SaveChanges();
          return RedirectToAction("Details", new { id = student.StudentId });
        }

        public ActionResult Delete(int id)
        {
          var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
          return View(thisStudent);
        }
        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
          var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
          _db.Students.Remove(thisStudent);
          _db.SaveChanges();
          return RedirectToAction("Index");
        }
    }
}