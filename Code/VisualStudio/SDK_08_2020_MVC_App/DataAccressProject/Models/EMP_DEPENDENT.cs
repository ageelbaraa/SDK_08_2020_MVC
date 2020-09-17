namespace DataAccressProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMP_DEPENDENT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string Essn { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string Dependent_name { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Bdate { get; set; }

        [StringLength(8)]
        public string Relationship { get; set; }
    }
}
