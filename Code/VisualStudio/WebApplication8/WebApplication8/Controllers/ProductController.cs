using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Product
        public ActionResult IndexLest()
        {

            var customers = _context.Customers.Include(c => c.MemberShipTypes).ToList();

            return View(customers);


            /*
            var product = new Product() { Name = "Product 1" };
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

            var customers = GetCustomers().ToList();

             */

            //if (customers == null)
            //{
            //    return HttpNotFound();
            //}

            //RandomProductModel model = new RandomProductModel()
            //{
            //    Customers = customers
            //};

        }

        public ActionResult New()
        {
            var memberShipTypes = _context.MemberShipTypeses.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MemberShipTypeses = memberShipTypes
                
            };
            return View(viewModel);
        }

        public ActionResult Detalis(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

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