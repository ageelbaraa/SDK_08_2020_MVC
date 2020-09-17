using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetIndex()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult PostIndex()
        {
            return View("Index");
        }

        [HttpPut]
        public ActionResult PutIndex()
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionIndex()
        {
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteIndex()
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchIndex()
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadIndex()
        {
            return View("Index");
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult DDIndex()
        {
            return View("Index");
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


    }
}