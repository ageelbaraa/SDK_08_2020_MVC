//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccressProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseTokenByStudentTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourseTokenByStudentTable()
        {
            this.CourseInfoTables = new HashSet<CourseInfoTable>();
        }
    
        public int SCID { get; set; }
        public string CourseName { get; set; }
        public string StudentName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseInfoTable> CourseInfoTables { get; set; }
    }
}
