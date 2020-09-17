namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [Display(Name ="ID")]
        public int Id { get; set; }

        [Display(Name = "name")]
        [StringLength(100)]
        public string name { get; set; }

        [Display(Name = "Gender")]
        [StringLength(50)]
        public string Gender { get; set; }

        [Display(Name = "Departmnet")]
        public int? Departmnet { get; set; }
    }
}
