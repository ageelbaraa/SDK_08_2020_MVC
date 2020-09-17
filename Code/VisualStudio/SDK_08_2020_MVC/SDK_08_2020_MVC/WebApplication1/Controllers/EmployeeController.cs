using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ModelEmployee employeeModel = new ModelEmployee();
            List<Employee> employee = employeeModel.Employees.ToList();
            return View(employee);
        }

        public ActionResult Details(int? id)
        {
            ModelEmployee employeeModel = new ModelEmployee();
            Employee employee = employeeModel.Employees.SingleOrDefault(emp => emp.Id == id);
            return View(employee);
        }
    }
}