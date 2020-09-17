using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SDK_08_2020_MVC_App.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("Student")
        {

        }
        public DbSet<Student> students { get; set; }

      

    }
}