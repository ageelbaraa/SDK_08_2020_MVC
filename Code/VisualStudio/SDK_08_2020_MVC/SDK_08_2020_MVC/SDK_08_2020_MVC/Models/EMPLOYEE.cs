namespace SDK_08_2020_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYEE")]
    public partial class EMPLOYEE
    {
        [Required]
        [StringLength(15)]
        public string Fname { get; set; }

        [StringLength(1)]
        public string Minit { get; set; }

        [Required]
        [StringLength(15)]
        public string Lname { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ssn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Bdate { get; set; }

        [StringLength(30)]
        public string Emp_Address { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        public decimal? Salary { get; set; }

        [StringLength(9)]
        public string Super_ssn { get; set; }

        public int Dno { get; set; }
    }
}
