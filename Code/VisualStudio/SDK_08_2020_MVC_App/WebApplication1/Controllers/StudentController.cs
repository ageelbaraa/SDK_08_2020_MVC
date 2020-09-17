using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Country()
        {
            ViewBag.Countries = new List<string>()
            { 
                "Jordan",
                "US",
                "UK"
            };

            return View();
        }

        public ActionResult Details(int? id)
        {
            StudentContext studentContext = new StudentContext();
            if(id != null)
            {
                Student student = studentContext.students.Single(item => item.StudentId == id);
                return View(student);
            }
            return View();
          

           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public StudentController()
        {
        }

        [ActionName("Find")]
        public string GetById(int id)
        {
            // get student from the database 
            return "id = " + id;
        }

        [HttpPost]
       public ActionResult Caluclator(string firstNumber , string secoundNumber , string Cal )
        {
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secoundNumber);
            int c = 0;
            switch (Cal)
            {
                case "Add":
                    {
                        c = a + b;
                    }break;

                case "sub":
                    {
                        c = a - b;
                    }break;

                case "mul":
                    {
                        c = a * b;
                    }break;

                case "div":
                    {
                        c = a / b;
                    }
                    break;

            }
            ViewBag.Result = c;
            return View();
        }

    }
}