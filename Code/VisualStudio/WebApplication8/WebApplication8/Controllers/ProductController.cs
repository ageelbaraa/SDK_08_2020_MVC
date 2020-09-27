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
        private ApplicationDbContext _context;

        public ProductController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Product
        public ViewResult IndexLest()
        {
            //var product = new Product() {Name = "Product 1"};
            //var customers = new List<Customer>()
            //{
            //    new Customer(){Name = "Customer 1"} ,
            //    new Customer(){Name = "Customer 2"}
            //};

            //var viewModel = new RandomProductModel()
            //{
            //    Product = product,
            //    Customers = customers
            //};

            var customers = GetCustomers().ToList();

            RandomProductModel model = new RandomProductModel()
            {
                Customers = customers
            };
            return View(model);
        }

        public ActionResult Detalis(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){Id = 1,Name = "Customer 1"} ,
                new Customer(){Id = 2,Name = "Customer 2"}
            };
        }
    }
}