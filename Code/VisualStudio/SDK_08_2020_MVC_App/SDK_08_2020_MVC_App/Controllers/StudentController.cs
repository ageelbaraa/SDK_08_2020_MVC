using SDK_08_2020_MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDK_08_2020_MVC_App.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        private StudentContext Context = new StudentContext();
        public ActionResult Index()
        {
            List<Student> student = Context.students.ToList<Student>();
            return View();
        }

        public ActionResult Details(string id)
        {
            StudentContext studentContext = new StudentContext();


            Student student = studentContext.students.Single(item => item.StudentId == id);
            return View(student);


        }
    }
}