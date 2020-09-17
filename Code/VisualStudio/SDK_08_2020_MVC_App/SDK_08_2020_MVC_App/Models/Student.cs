using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SDK_08_2020_MVC_App.Models
{
   
    public class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Age { get; set; }
    }
}