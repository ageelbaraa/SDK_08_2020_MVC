using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication8.Models;

namespace WebApplication8.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShipTypes> MemberShipTypeses { get; set; }
        public Customer Customer { get; set; }
    }
}