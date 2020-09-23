using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication8.Models;

namespace WebApplication8.ViewModels
{
    public class RandomProductModel
    {
        public Product Product { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Employee> Employees { get; set; }
    }
}