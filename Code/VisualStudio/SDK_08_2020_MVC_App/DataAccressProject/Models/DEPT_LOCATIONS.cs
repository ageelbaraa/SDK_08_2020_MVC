namespace DataAccressProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEPT_LOCATIONS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dnumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string Dlocation { get; set; }
    }
}
