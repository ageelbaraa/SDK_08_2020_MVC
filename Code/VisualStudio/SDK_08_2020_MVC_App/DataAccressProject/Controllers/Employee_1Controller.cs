using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccressProject.Models;

namespace DataAccressProject.Controllers
{
    public class Employee_1Controller : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeModel employeeModel = new EmployeeModel();
            List<Employee_1> employee = employeeModel.Employees.ToList();
            return View(employee);
        }

        public ActionResult Details(int? id)
        {
            EmployeeModel employeeModel = new EmployeeModel();
            Employee_1 employee = employeeModel.Employees.Single(emp => emp.Id == id);
            return View(employee);
        }
    }
}