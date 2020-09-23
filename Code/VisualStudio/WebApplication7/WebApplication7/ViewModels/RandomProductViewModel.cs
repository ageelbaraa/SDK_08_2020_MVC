using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models;

namespace WebApplication7.ViewModels
{
    public class RandomProductViewModel
    {
        public Product Product { get; set; }
        public List<Customer> Customers { get; set; } 
    }
}