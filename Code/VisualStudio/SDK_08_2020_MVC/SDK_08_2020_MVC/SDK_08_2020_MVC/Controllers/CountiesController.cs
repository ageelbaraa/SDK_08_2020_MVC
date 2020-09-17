using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using SDK_08_2020_MVC.Models;

namespace SDK_08_2020_MVC.Controllers
{
    public class CountiesController : Controller
    {
        ModelCounties model = new ModelCounties();
        // GET: Counties
        public ActionResult Index()
        {
            
            List<Country> countries = model.Countries.ToList();
            return View(countries);
        }

        public ActionResult Details(int? id)
        {
            //try
            //{
            //    ModelCounties model = new ModelCounties();
            //    Country countries = model.Countries.Single(emp => emp.Id == id);
            //    return View(countries);
            //}catch(Exception ex)
            //{
            //    ScriptManager.RegisterStartupScript(this, this.GetType(),
            //        "Script", "alert('" + ex.Message"');", true);
            //}

            //Country countries = model.Countries.Find(id);
           Country countries = model.Countries.Single(emp => emp.Id == id);
            return View(countries);

        }
    }
}