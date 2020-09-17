namespace DataAccressProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPARTMENT")]
    public partial class DEPARTMENT
    {
        [Required]
        [StringLength(15)]
        public string Dname { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dnumber { get; set; }

        [StringLength(9)]
        public string Mgr_ssn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Mgr_start_date { get; set; }

        public List<EMPLOYEE> EMPLOYEEs { get; set; }
    }
}
