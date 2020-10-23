using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enert Your Name")]
        [StringLength(255)]
        public string Name { get; set; }

     
        public bool IsSubscribedToNewLetter { get; set; }

        public MemberShipTypes MemberShipTypes { get; set; }
        [Display(Name = "MemberShip Type")]
        public byte MemberShipTypeId { get; set; }
        [Display(Name = "Date Of Birth")]
        [Min18YearOldValidation]
        public DateTime? Birthdate { get; set; }


    }
}