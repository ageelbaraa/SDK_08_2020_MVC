using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDK_08_2020_MVC.Models;

namespace SDK_08_2020_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ModelCompanydb model = new ModelCompanydb();
            List<EMPLOYEE> employee = model.EMPLOYEEs.ToList();
            return View(employee);
        }

        public ActionResult Details(int? id)
        {
            ModelCompanydb model = new ModelCompanydb();
            EMPLOYEE employee = model.EMPLOYEEs.Single(emp => emp.Ssn == id);
            //EMPLOYEE employee2 = model.EMPLOYEEs.Where(emp => emp.Ssn == id).SingleOrDefault();

            return View(employee);
        }
    }
}