//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;

    public partial class tblEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public Nullable<int> DepartmnetId { get; set; }
        [NotMapped]
        public List<tblDepartmnet> DeList { get; set; }
    
        public virtual tblDepartmnet tblDepartmnet { get; set; }
    }
}
