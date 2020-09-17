using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculatorClass model , string commad)
        {
            switch (commad)
            {
                case "Add":
                    {
                        model.result = model.firstNumber + model.secondNumber;
                    }break;

                case "sub":
                    {
                        model.result = model.firstNumber - model.secondNumber;
                    }
                    break;
                case "mul":
                    {
                        model.result = model.firstNumber * model.secondNumber;
                    }
                    break;

                case "div":
                    {
                        model.result = model.firstNumber / model.secondNumber;
                    }
                    break;
            }

            return View(model);
        }
    }
}