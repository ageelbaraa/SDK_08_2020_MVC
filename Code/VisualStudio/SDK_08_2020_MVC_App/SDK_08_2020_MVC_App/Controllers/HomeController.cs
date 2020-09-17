using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDK_08_2020_MVC_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index(string name , string id)
        {
            return "Home  \\ Hi " + name + " The ID is : " + id;
        }
    }
}