namespace DataAccressProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employees")]
    public partial class Employee_1
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [StringLength(100)]
        [DisplayName("Name")]
        public string name { get; set; }

        [StringLength(50)]
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [DisplayName("Departmnet ID")]
        public int? Departmnet { get; set; }
    }
}
