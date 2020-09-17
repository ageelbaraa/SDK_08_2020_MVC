namespace SDK_08_2020_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Country
    {
        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name="Ios")]
        public string Iso { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [StringLength(3)]
        [Display(Name = "Iso3")]
        public string Iso3 { get; set; }

        [Display(Name = "NumCode")]
        public int? NumCode { get; set; }

        [Display(Name = "PhoneCode")]
        public int PhoneCode { get; set; }
    }
}
