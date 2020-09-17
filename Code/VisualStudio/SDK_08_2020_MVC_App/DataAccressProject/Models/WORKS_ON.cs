namespace DataAccressProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WORKS_ON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string Essn { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pno { get; set; }

        public decimal Emp_Hours { get; set; }
    }
}
