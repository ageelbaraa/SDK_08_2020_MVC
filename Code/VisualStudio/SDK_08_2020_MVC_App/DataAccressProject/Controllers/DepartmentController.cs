using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccressProject.Models;

namespace DataAccressProject.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            CompanyModel companyModel = new CompanyModel();
            List<DEPARTMENT> dEPARTMENTs = companyModel.DEPARTMENTs.ToList();
            return View(dEPARTMENTs);
        }
    }
}