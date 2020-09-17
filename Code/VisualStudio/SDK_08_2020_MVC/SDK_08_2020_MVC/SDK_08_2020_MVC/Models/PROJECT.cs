namespace SDK_08_2020_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROJECT")]
    public partial class PROJECT
    {
        [Required]
        [StringLength(15)]
        public string Pname { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pnumber { get; set; }

        [StringLength(15)]
        public string Plocation { get; set; }

        public int Dnum { get; set; }
    }
}
