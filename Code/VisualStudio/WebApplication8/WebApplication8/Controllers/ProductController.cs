using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;
using WebApplication8.ViewModels;

namespace WebApplication8.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var product = new Product() {Name = "Product 1"};
            var customers = new List<Customer>()
            {
                new Customer(){Name = "Customer 1"} ,
                new Customer(){Name = "Customer 2"}
            };

            var viewModel = new RandomProductModel()
            {
                Product = product,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}