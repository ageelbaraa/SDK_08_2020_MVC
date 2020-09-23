using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
using WebApplication7.ViewModels;

namespace WebApplication7.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var product = new Product() {Name = "Product 1"};
            var customers = new List<Customer>
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 1"}
            };

            var ViewModel = new RandomProductViewModel
            {
                Customers = customers,
                Product = product
            };

            return View(ViewModel);
        }
    }
}