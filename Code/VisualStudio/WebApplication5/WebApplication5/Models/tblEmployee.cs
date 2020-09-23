namespace WebApplication5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("tblEmployee")]
    public partial class tblEmployee
    {
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(100)]
        [Display(Name="Emplpoyee Name")]
        public string Name { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        [Display(Name= "cityList")]
        public string City { get; set; }
        [NotMapped]
        public List<SelectListItem> cityList { get; set; }
        public int? DepartmnetId { get; set; }

        public virtual tblDepartmnet tblDepartmnet { get; set; }
        
      
    }

    public enum Empyoyee
    {
        Ali , 
        Ahmad , 
        Salim
    }

    public enum City 
    {
        
    }
}
