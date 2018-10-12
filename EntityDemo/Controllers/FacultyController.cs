using EntityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityDemo.Controllers
{
    public class FacultyController : Controller
    {

        private IdentityModel _context;

        public FacultyController()
        {
            _context = new IdentityModel();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
       
        // GET: Faculty
        public ActionResult Index()
        {
            var faculty = _context.Faculty.ToList();
            return View(faculty);
        }
    }
}