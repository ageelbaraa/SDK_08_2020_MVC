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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MemberShipTypeses = _context.MemberShipTypeses.ToList()
                };
                return View("CustomerForm", viewModel);
            }
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
                customerInDb.IsSubscribedToNewLetter = customer.IsSubscribedToNewLetter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
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