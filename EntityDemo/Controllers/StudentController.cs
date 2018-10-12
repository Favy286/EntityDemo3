using EntityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityDemo.Controllers
{
    public class StudentController : Controller
    {
        private IdentityModel _context;

        public StudentController()
        {
            _context = new IdentityModel();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Student
        public ActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
    }
}