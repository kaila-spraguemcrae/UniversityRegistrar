using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
    public class CoursesController : Controller
    {
        private readonly RegistrarContext _db;

        public CoursesController(RegistrarContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Course> courseList = _db.Courses.ToList();
            courseList.Sort((x, y) => string.Compare(x.CourseNumber, y.CourseNumber));
            return View(courseList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create (Course course)
        {
            _db.Courses.Add(course);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}