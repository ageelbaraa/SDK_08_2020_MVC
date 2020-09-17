using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCalculator.Models;

namespace SimpleCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ClaculatorModel model, string command)
        {
            switch (command)
            {
                case "add":
                    {
                        model.Result = model.firstNumber + model.secondNumber;
                    }
                    break;
                case "sub":
                    {
                        model.Result = model.firstNumber - model.secondNumber;
                    }
                    break;

                case "mul":
                    {
                        model.Result = model.firstNumber * model.secondNumber;
                    }
                    break;

                case "div":
                    {
                        model.Result = model.firstNumber / model.secondNumber;
                    }
                    break;
            }
           
            return View(model);
        }
    }
}