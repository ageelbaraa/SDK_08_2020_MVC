using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccressProject.Models
{
    public class StudentClass
    {
       [Display(Name ="ID")] 
        public int SID { get; set; }

       
        public string SName { get; set; }

        
        public string SBirthDate { get; set; }

        
        public string SUserName { get; set; }

       
        public string SPassword { get; set; }

        
        public string SGPA { get; set; }
    }
}